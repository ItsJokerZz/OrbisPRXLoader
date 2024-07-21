namespace OrbisPRXLoader
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.controlBox = new System.Windows.Forms.Panel();
            this.Credits = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Panel();
            this.ProcessTitle = new System.Windows.Forms.Label();
            this.HandleIDTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UnloadPRX = new System.Windows.Forms.Button();
            this.LoadPRX = new System.Windows.Forms.Button();
            this.Processes = new System.Windows.Forms.ComboBox();
            this.PRXPathTitle = new System.Windows.Forms.Label();
            this.PRXPath = new System.Windows.Forms.TextBox();
            this.IPTitle = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.PortTitle = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.Initiate = new System.Windows.Forms.Button();
            this.Botttom = new System.Windows.Forms.Panel();
            this.Status = new System.Windows.Forms.Label();
            this.controlBox.SuspendLayout();
            this.background.SuspendLayout();
            this.Botttom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.Title.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 30);
            this.Title.TabIndex = 0;
            this.Title.Text = "OrbisPRXLoader";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(338, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "✘";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // controlBox
            // 
            this.controlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.controlBox.Controls.Add(this.Credits);
            this.controlBox.Controls.Add(this.Title);
            this.controlBox.Controls.Add(this.Exit);
            this.controlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlBox.Location = new System.Drawing.Point(0, 0);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(368, 30);
            this.controlBox.TabIndex = 1;
            this.controlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // Credits
            // 
            this.Credits.BackColor = System.Drawing.Color.Transparent;
            this.Credits.Dock = System.Windows.Forms.DockStyle.Left;
            this.Credits.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits.ForeColor = System.Drawing.Color.White;
            this.Credits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Credits.Location = new System.Drawing.Point(139, 0);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(90, 30);
            this.Credits.TabIndex = 1;
            this.Credits.Text = "by ItsJokerZz";
            this.Credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Credits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.background.Controls.Add(this.ProcessTitle);
            this.background.Controls.Add(this.HandleIDTitle);
            this.background.Controls.Add(this.comboBox1);
            this.background.Controls.Add(this.UnloadPRX);
            this.background.Controls.Add(this.LoadPRX);
            this.background.Controls.Add(this.Processes);
            this.background.Controls.Add(this.PRXPathTitle);
            this.background.Controls.Add(this.PRXPath);
            this.background.Controls.Add(this.IPTitle);
            this.background.Controls.Add(this.IP);
            this.background.Controls.Add(this.PortTitle);
            this.background.Controls.Add(this.Port);
            this.background.Controls.Add(this.Initiate);
            this.background.Location = new System.Drawing.Point(4, 34);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(360, 172);
            this.background.TabIndex = 37;
            this.background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // ProcessTitle
            // 
            this.ProcessTitle.BackColor = System.Drawing.Color.Transparent;
            this.ProcessTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessTitle.ForeColor = System.Drawing.Color.White;
            this.ProcessTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProcessTitle.Location = new System.Drawing.Point(5, 89);
            this.ProcessTitle.Name = "ProcessTitle";
            this.ProcessTitle.Size = new System.Drawing.Size(72, 22);
            this.ProcessTitle.TabIndex = 57;
            this.ProcessTitle.Text = "Process:";
            this.ProcessTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HandleIDTitle
            // 
            this.HandleIDTitle.BackColor = System.Drawing.Color.Transparent;
            this.HandleIDTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HandleIDTitle.ForeColor = System.Drawing.Color.White;
            this.HandleIDTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HandleIDTitle.Location = new System.Drawing.Point(185, 89);
            this.HandleIDTitle.Name = "HandleIDTitle";
            this.HandleIDTitle.Size = new System.Drawing.Size(81, 22);
            this.HandleIDTitle.TabIndex = 56;
            this.HandleIDTitle.Text = "Handle ID:";
            this.HandleIDTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 320;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 23);
            this.comboBox1.TabIndex = 55;
            // 
            // UnloadPRX
            // 
            this.UnloadPRX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.UnloadPRX.FlatAppearance.BorderSize = 0;
            this.UnloadPRX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.UnloadPRX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.UnloadPRX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnloadPRX.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.UnloadPRX.ForeColor = System.Drawing.Color.White;
            this.UnloadPRX.Location = new System.Drawing.Point(188, 140);
            this.UnloadPRX.Name = "UnloadPRX";
            this.UnloadPRX.Size = new System.Drawing.Size(162, 23);
            this.UnloadPRX.TabIndex = 54;
            this.UnloadPRX.Text = "Unload PRX/SPRX";
            this.UnloadPRX.UseVisualStyleBackColor = false;
            this.UnloadPRX.Click += new System.EventHandler(this.Unload_Click);
            // 
            // LoadPRX
            // 
            this.LoadPRX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LoadPRX.FlatAppearance.BorderSize = 0;
            this.LoadPRX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LoadPRX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.LoadPRX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadPRX.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.LoadPRX.ForeColor = System.Drawing.Color.White;
            this.LoadPRX.Location = new System.Drawing.Point(9, 140);
            this.LoadPRX.Name = "LoadPRX";
            this.LoadPRX.Size = new System.Drawing.Size(162, 23);
            this.LoadPRX.TabIndex = 53;
            this.LoadPRX.Text = "Load PRX/SPRX";
            this.LoadPRX.UseVisualStyleBackColor = false;
            this.LoadPRX.Click += new System.EventHandler(this.Load_Click);
            // 
            // Processes
            // 
            this.Processes.DropDownWidth = 220;
            this.Processes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Processes.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.Processes.FormattingEnabled = true;
            this.Processes.Location = new System.Drawing.Point(9, 111);
            this.Processes.Name = "Processes";
            this.Processes.Size = new System.Drawing.Size(162, 23);
            this.Processes.TabIndex = 52;
            this.Processes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Processes_MouseDown);
            // 
            // PRXPathTitle
            // 
            this.PRXPathTitle.BackColor = System.Drawing.Color.Transparent;
            this.PRXPathTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRXPathTitle.ForeColor = System.Drawing.Color.White;
            this.PRXPathTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PRXPathTitle.Location = new System.Drawing.Point(185, 39);
            this.PRXPathTitle.Name = "PRXPathTitle";
            this.PRXPathTitle.Size = new System.Drawing.Size(72, 22);
            this.PRXPathTitle.TabIndex = 47;
            this.PRXPathTitle.Text = "PRX Path:";
            this.PRXPathTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PRXPath
            // 
            this.PRXPath.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRXPath.Location = new System.Drawing.Point(188, 64);
            this.PRXPath.Name = "PRXPath";
            this.PRXPath.Size = new System.Drawing.Size(162, 23);
            this.PRXPath.TabIndex = 48;
            this.PRXPath.Text = "/data/gscloader/iw6/120.sprx";
            // 
            // IPTitle
            // 
            this.IPTitle.BackColor = System.Drawing.Color.Transparent;
            this.IPTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTitle.ForeColor = System.Drawing.Color.White;
            this.IPTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IPTitle.Location = new System.Drawing.Point(6, 6);
            this.IPTitle.Name = "IPTitle";
            this.IPTitle.Size = new System.Drawing.Size(87, 22);
            this.IPTitle.TabIndex = 39;
            this.IPTitle.Text = "IP Address:";
            this.IPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP.Location = new System.Drawing.Point(8, 31);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(118, 23);
            this.IP.TabIndex = 40;
            // 
            // PortTitle
            // 
            this.PortTitle.BackColor = System.Drawing.Color.Transparent;
            this.PortTitle.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortTitle.ForeColor = System.Drawing.Color.White;
            this.PortTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PortTitle.Location = new System.Drawing.Point(129, 6);
            this.PortTitle.Name = "PortTitle";
            this.PortTitle.Size = new System.Drawing.Size(48, 22);
            this.PortTitle.TabIndex = 38;
            this.PortTitle.Text = "Port:";
            this.PortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(133, 31);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(37, 23);
            this.Port.TabIndex = 41;
            this.Port.Text = "9090";
            // 
            // Initiate
            // 
            this.Initiate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Initiate.FlatAppearance.BorderSize = 0;
            this.Initiate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Initiate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.Initiate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Initiate.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.Initiate.ForeColor = System.Drawing.Color.White;
            this.Initiate.Location = new System.Drawing.Point(8, 63);
            this.Initiate.Name = "Initiate";
            this.Initiate.Size = new System.Drawing.Size(162, 23);
            this.Initiate.TabIndex = 42;
            this.Initiate.Text = "Connect via API";
            this.Initiate.UseVisualStyleBackColor = false;
            this.Initiate.Click += new System.EventHandler(this.Initiate_Click);
            // 
            // Botttom
            // 
            this.Botttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Botttom.Controls.Add(this.Status);
            this.Botttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Botttom.Location = new System.Drawing.Point(0, 209);
            this.Botttom.Name = "Botttom";
            this.Botttom.Size = new System.Drawing.Size(368, 19);
            this.Botttom.TabIndex = 38;
            this.Botttom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Status.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Status.Location = new System.Drawing.Point(0, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(368, 19);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status: Awaiting Connection";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Status.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(368, 228);
            this.ControlBox = false;
            this.Controls.Add(this.Botttom);
            this.Controls.Add(this.background);
            this.Controls.Add(this.controlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrbisPRXLoader";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.App_FormClosing);
            this.Load += new System.EventHandler(this.App_Load);
            this.controlBox.ResumeLayout(false);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.Botttom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel controlBox;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Button Initiate;
        public System.Windows.Forms.Label PortTitle;
        private System.Windows.Forms.TextBox Port;
        public System.Windows.Forms.Label IPTitle;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Panel Botttom;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.Label Credits;
        public System.Windows.Forms.Label PRXPathTitle;
        private System.Windows.Forms.TextBox PRXPath;
        private System.Windows.Forms.ComboBox Processes;
        private System.Windows.Forms.Button UnloadPRX;
        private System.Windows.Forms.Button LoadPRX;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label ProcessTitle;
        public System.Windows.Forms.Label HandleIDTitle;
    }
}