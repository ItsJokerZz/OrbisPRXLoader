using libframe4;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbisPRXLoader
{
    public partial class App : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private Dictionary<int, string> 
            prxHandleMapping = new Dictionary<int, string>();

        private FRAME4 api; private Socket socket;

        private string status = "Awaiting Connection";
     
        private bool ConnectToBinLoader(string ip, string port)
        {
            WebClient client = new WebClient();
            status = "Awaiting Connection";
            bool ret = false;

            if (!IPAddress.TryParse(ip, out var ipAddress) || !int.TryParse(port, out var portNumber))
            {
                status = "Invalid IP or Port";
                return false;
            }

            try
            {
                if (client.DownloadString($"http://{ipAddress}:9090/status").Contains("{ \"status\": \"ready\" }"))
                {
                    try
                    {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socket.ReceiveTimeout = 3000;
                        socket.SendTimeout = 3000;
                        socket.Connect(new IPEndPoint(ipAddress, portNumber));

                        ret = true;
                    }
                    catch (Exception)
                    {
                        status = "Failed to Send Payload";
                        ret = false;
                    }
                }
                else
                {
                    status = "Bin Loader Not Ready";
                    ret = false;
                }
            }
            catch (WebException)
            {
                status = "Bin Server Not Found";
                ret = false;
            }

            return ret;
        }

        private string Payload()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "frame4.bin");
        }

        private async Task ConnectViaAPI(TextBox ip, Label status, Button connectButton)
        {
            api = new FRAME4(ip.Text);

            await Task.Delay(1000);

            try
            {
                api.Connect();
            }
            catch (Exception)
            {
                status.Text = "Failed to Reconnect";
                connectButton.Text = "Connect via API";
            }

            if (api.IsConnected)
            {
                status.Text = "Awaiting to load SPRX";
                connectButton.Text = "Reconnect via API";
                api.Notify(222, "ItsJokerZz's\nMulti-COD GSC Loader:\n\nConnected Successfully!");
            }

            status.Text = $"Status: {status.Text}";
        }

        private async Task AnimateResizeAsync(int finalHeight, int step, bool grow = false)
        {
            SemaphoreSlim resizeSemaphore = new SemaphoreSlim(1, 1);

            await resizeSemaphore.WaitAsync();

            try
            {
                while ((grow && Size.Height < finalHeight) || (!grow && Size.Height > finalHeight))
                {
                    int newHeight = grow ? Math.Min(Size.Height + step, finalHeight)
                        : Math.Max(Size.Height - step, finalHeight);

                    Size = new Size(264, newHeight);
                    await Task.Delay(10);
                }
            }
            finally
            {
                resizeSemaphore.Release();
            }
        }

        public App() => InitializeComponent();

        private void App_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.ip))
                IP.Text = Properties.Settings.Default.ip;
            else return;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.port))
                Port.Text = Properties.Settings.Default.port;
            else return;

            api = new FRAME4(IP.Text);

            try
            {
                api.Connect();
            }
            catch (Exception)
            {
                /* do nothing */
            }

            if (api.IsConnected)
            {
                Initiate.Text = "Reconnect via API";
                Status.Text = "Status: Awaiting to load SPRX";
                api.Notify(222, "ItsJokerZz's\nSPRXLoader:\n\nConnected Successfully!");
                // await AnimateResizeAsync(274, 14, true);
            }
            else
            {
                api = null;
            }
        }

        private new void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (api != null && api.IsConnected) api.UnloadPayload();
        }

        private async void Exit_Click(object sender, EventArgs e)
        {
            /* await AnimateResizeAsync(30, 14, false); */
            Application.Exit();
        }

        private async void Initiate_Click(object sender, EventArgs e)
        {
            try
            {
                if (api == null)
                {
                    if (ConnectToBinLoader(IP.Text, Port.Text))
                    {
                        socket.SendFile(Payload());
                        socket.Close();
                    }
                }
            }
            catch (Exception) { /* do nothing */ }

            Status.Text = $"Status: {status}";
            if (Status.Text.Contains("Failed") || Status.Text.Contains("Not")) return;

            await ConnectViaAPI(IP, Status, Initiate);

            if (Status.Text.Contains("Failed") &&
                Size != new Size(Size.Width, 144)) return;
            //  await AnimateResizeAsync(144, 14, false);
            else
            {
                //  await AnimateResizeAsync(274, 14, true);

                Properties.Settings.Default.ip = IP.Text;
                Properties.Settings.Default.port = Port.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Processes_MouseDown(object sender, MouseEventArgs e)
        {
            Processes.Items.Clear();

            if (api != null && api.IsConnected)
            {
                try
                {
                    foreach (var process in api.GetProcessList().processes)
                    {
                        Processes.Items.Add($"[{process.pid}] {process.name}");
                        Processes.Text = Processes.Items[0].ToString();
                    }
                }
                catch
                {
                    Status.Text = "Status: Game Process Not Found";
                    return;
                }
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string Process = Processes.Text;
            Process = Regex.Replace(Process, @"^\[\s*\d+\s*\]\s*", "");

            try
            {
                int prxHandle = api.LoadPRX(Process, PRXPath.Text);
                Status.Text = "Status: Loaded Successfully";

                prxHandleMapping[prxHandle] = PRXPath.Text;

                string itemToAdd = $"{prxHandle} [{PRXPath.Text}]";

                if (!comboBox1.Items.Contains(itemToAdd))
                    comboBox1.Items.Add(itemToAdd);

                if (comboBox1.Items.Count == 0)
                    comboBox1.Text = "";
                else
                    comboBox1.Text = itemToAdd;
            }
            catch
            {
                Status.Text = "Status: Failed to Load";
            }
        }

        private void Unload_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.Text;
            string handleText = Regex.Match(selectedItem, @"\d+").Value;

            if (int.TryParse(handleText, out int prxHandle))
            {
                try
                {
                    if (prxHandleMapping.TryGetValue(prxHandle, out _))
                    {

                        api.UnloadPRX(Processes.Text, prxHandle);
                        comboBox1.Items.Remove(selectedItem);

                        prxHandleMapping.Remove(prxHandle);

                        if (comboBox1.Items.Count == 0)
                            comboBox1.Text = "";
                        else
                            comboBox1.Text = comboBox1.Items[comboBox1.Items.Count - 1].ToString();

                        Status.Text = "Status: Unloaded Successfully";
                    }
                    else
                    {
                        Status.Text = "Status: Failed to Unload";
                    }
                }
                catch
                {
                    Status.Text = "Status: Failed to Unload";
                }
            }
            else
            {
                Status.Text = "Status: Failed to Unload";
            }
        }
    }
}