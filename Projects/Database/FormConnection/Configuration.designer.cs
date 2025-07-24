namespace Database.FormConnection
{
    partial class ConnectionF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnCommand = new System.Windows.Forms.Button();
            this.TxBCommand = new System.Windows.Forms.TextBox();
            this.LblCommand = new System.Windows.Forms.Label();
            this.ChkSaveUserPassword = new System.Windows.Forms.CheckBox();
            this.TxBPassword = new System.Windows.Forms.MaskedTextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxBUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxBPort = new System.Windows.Forms.TextBox();
            this.LblPort = new System.Windows.Forms.Label();
            this.BtnFolder = new System.Windows.Forms.Button();
            this.TxBServer = new System.Windows.Forms.TextBox();
            this.TxBFolder = new System.Windows.Forms.TextBox();
            this.TxBDatabase = new System.Windows.Forms.TextBox();
            this.CbBProtocol = new System.Windows.Forms.ComboBox();
            this.CbBController = new System.Windows.Forms.ComboBox();
            this.LblController = new System.Windows.Forms.Label();
            this.LblServer = new System.Windows.Forms.Label();
            this.LblFolder = new System.Windows.Forms.Label();
            this.LblDatabase = new System.Windows.Forms.Label();
            this.LblProtocol = new System.Windows.Forms.Label();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlPanel1.Controls.Add(this.BtnCommand);
            this.PnlPanel1.Controls.Add(this.TxBCommand);
            this.PnlPanel1.Controls.Add(this.LblCommand);
            this.PnlPanel1.Controls.Add(this.ChkSaveUserPassword);
            this.PnlPanel1.Controls.Add(this.TxBPassword);
            this.PnlPanel1.Controls.Add(this.LblPassword);
            this.PnlPanel1.Controls.Add(this.TxBUser);
            this.PnlPanel1.Controls.Add(this.LblUser);
            this.PnlPanel1.Controls.Add(this.TxBPort);
            this.PnlPanel1.Controls.Add(this.LblPort);
            this.PnlPanel1.Controls.Add(this.BtnFolder);
            this.PnlPanel1.Controls.Add(this.TxBServer);
            this.PnlPanel1.Controls.Add(this.TxBFolder);
            this.PnlPanel1.Controls.Add(this.TxBDatabase);
            this.PnlPanel1.Controls.Add(this.CbBProtocol);
            this.PnlPanel1.Controls.Add(this.CbBController);
            this.PnlPanel1.Controls.Add(this.LblController);
            this.PnlPanel1.Controls.Add(this.LblServer);
            this.PnlPanel1.Controls.Add(this.LblFolder);
            this.PnlPanel1.Controls.Add(this.LblDatabase);
            this.PnlPanel1.Controls.Add(this.LblProtocol);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(505, 238);
            this.PnlPanel1.TabIndex = 0;
            // 
            // BtnCommand
            // 
            this.BtnCommand.Location = new System.Drawing.Point(477, 146);
            this.BtnCommand.Name = "BtnCommand";
            this.BtnCommand.Size = new System.Drawing.Size(21, 21);
            this.BtnCommand.TabIndex = 19;
            this.TTpTip.SetToolTip(this.BtnCommand, "Show the connection command");
            this.BtnCommand.UseVisualStyleBackColor = true;
            this.BtnCommand.Click += new System.EventHandler(this.BtnComando_Click);
            // 
            // TxBCommand
            // 
            this.TxBCommand.Location = new System.Drawing.Point(73, 146);
            this.TxBCommand.Name = "TxBCommand";
            this.TxBCommand.ReadOnly = true;
            this.TxBCommand.Size = new System.Drawing.Size(402, 20);
            this.TxBCommand.TabIndex = 18;
            // 
            // LblCommand
            // 
            this.LblCommand.AutoSize = true;
            this.LblCommand.Location = new System.Drawing.Point(6, 150);
            this.LblCommand.Name = "LblCommand";
            this.LblCommand.Size = new System.Drawing.Size(65, 13);
            this.LblCommand.TabIndex = 17;
            this.LblCommand.Text = "Command:";
            // 
            // ChkSaveUserPassword
            // 
            this.ChkSaveUserPassword.AutoSize = true;
            this.ChkSaveUserPassword.Location = new System.Drawing.Point(73, 168);
            this.ChkSaveUserPassword.Name = "ChkSaveUserPassword";
            this.ChkSaveUserPassword.Size = new System.Drawing.Size(209, 17);
            this.ChkSaveUserPassword.TabIndex = 20;
            this.ChkSaveUserPassword.Text = "Save the user and the password";
            this.ChkSaveUserPassword.UseVisualStyleBackColor = true;
            // 
            // TxBPassword
            // 
            this.TxBPassword.Location = new System.Drawing.Point(73, 123);
            this.TxBPassword.Name = "TxBPassword";
            this.TxBPassword.PasswordChar = '*';
            this.TxBPassword.Size = new System.Drawing.Size(425, 20);
            this.TxBPassword.TabIndex = 16;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(6, 127);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(65, 13);
            this.LblPassword.TabIndex = 15;
            this.LblPassword.Text = "Password:";
            // 
            // TxBUser
            // 
            this.TxBUser.Location = new System.Drawing.Point(73, 100);
            this.TxBUser.Name = "TxBUser";
            this.TxBUser.Size = new System.Drawing.Size(425, 20);
            this.TxBUser.TabIndex = 14;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(34, 104);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(37, 13);
            this.LblUser.TabIndex = 13;
            this.LblUser.Text = "User:";
            // 
            // TxBPort
            // 
            this.TxBPort.Location = new System.Drawing.Point(455, 77);
            this.TxBPort.Name = "TxBPort";
            this.TxBPort.Size = new System.Drawing.Size(43, 20);
            this.TxBPort.TabIndex = 12;
            this.TxBPort.TextChanged += new System.EventHandler(this.TxBPorta_TextChanged);
            // 
            // LblPort
            // 
            this.LblPort.AutoSize = true;
            this.LblPort.Location = new System.Drawing.Point(417, 81);
            this.LblPort.Name = "LblPort";
            this.LblPort.Size = new System.Drawing.Size(34, 13);
            this.LblPort.TabIndex = 11;
            this.LblPort.Text = "Port:";
            // 
            // BtnFolder
            // 
            this.BtnFolder.Location = new System.Drawing.Point(477, 55);
            this.BtnFolder.Name = "BtnFolder";
            this.BtnFolder.Size = new System.Drawing.Size(21, 21);
            this.BtnFolder.TabIndex = 8;
            this.BtnFolder.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnFolder, "Show the folder list dialogue box");
            this.BtnFolder.UseVisualStyleBackColor = true;
            this.BtnFolder.Click += new System.EventHandler(this.BtnDiretorio_Click);
            // 
            // TxBServer
            // 
            this.TxBServer.Location = new System.Drawing.Point(73, 77);
            this.TxBServer.Name = "TxBServer";
            this.TxBServer.Size = new System.Drawing.Size(331, 20);
            this.TxBServer.TabIndex = 10;
            // 
            // TxBFolder
            // 
            this.TxBFolder.Location = new System.Drawing.Point(73, 55);
            this.TxBFolder.Name = "TxBFolder";
            this.TxBFolder.Size = new System.Drawing.Size(402, 20);
            this.TxBFolder.TabIndex = 7;
            this.TxBFolder.TextChanged += new System.EventHandler(this.TxBDiretorio_TextChanged);
            // 
            // TxBDatabase
            // 
            this.TxBDatabase.Location = new System.Drawing.Point(73, 33);
            this.TxBDatabase.Name = "TxBDatabase";
            this.TxBDatabase.Size = new System.Drawing.Size(425, 20);
            this.TxBDatabase.TabIndex = 5;
            // 
            // CbBProtocol
            // 
            this.CbBProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBProtocol.FormattingEnabled = true;
            this.CbBProtocol.Items.AddRange(new object[] {
            "LocalHost",
            "TCP",
            "NamedPipe",
            "NetBuie",
            "SPX"});
            this.CbBProtocol.Location = new System.Drawing.Point(323, 9);
            this.CbBProtocol.Name = "CbBProtocol";
            this.CbBProtocol.Size = new System.Drawing.Size(175, 21);
            this.CbBProtocol.TabIndex = 3;
            this.CbBProtocol.Visible = false;
            this.CbBProtocol.SelectedIndexChanged += new System.EventHandler(this.CbBProtocolo_SelectedIndexChanged);
            // 
            // CbBController
            // 
            this.CbBController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBController.FormattingEnabled = true;
            this.CbBController.Items.AddRange(new object[] {
            "FireBird",
            "SQLServer",
            "Oracle",
            "PostgreSQL"});
            this.CbBController.Location = new System.Drawing.Point(73, 9);
            this.CbBController.MaxDropDownItems = 3;
            this.CbBController.Name = "CbBController";
            this.CbBController.Size = new System.Drawing.Size(175, 21);
            this.CbBController.TabIndex = 1;
            this.CbBController.SelectedIndexChanged += new System.EventHandler(this.CbBControlador_SelectedIndexChanged);
            // 
            // LblController
            // 
            this.LblController.AutoSize = true;
            this.LblController.Location = new System.Drawing.Point(6, 13);
            this.LblController.Name = "LblController";
            this.LblController.Size = new System.Drawing.Size(65, 13);
            this.LblController.TabIndex = 0;
            this.LblController.Text = "Controller:";
            // 
            // LblServer
            // 
            this.LblServer.AutoSize = true;
            this.LblServer.Location = new System.Drawing.Point(23, 81);
            this.LblServer.Name = "LblServer";
            this.LblServer.Size = new System.Drawing.Size(48, 13);
            this.LblServer.TabIndex = 9;
            this.LblServer.Text = "Server:";
            // 
            // LblFolder
            // 
            this.LblFolder.Location = new System.Drawing.Point(6, 59);
            this.LblFolder.Name = "LblFolder";
            this.LblFolder.Size = new System.Drawing.Size(65, 13);
            this.LblFolder.TabIndex = 6;
            this.LblFolder.Text = "Folder:";
            this.LblFolder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblDatabase
            // 
            this.LblDatabase.AutoSize = true;
            this.LblDatabase.Location = new System.Drawing.Point(6, 37);
            this.LblDatabase.Name = "LblDatabase";
            this.LblDatabase.Size = new System.Drawing.Size(65, 13);
            this.LblDatabase.TabIndex = 4;
            this.LblDatabase.Text = "Database:";
            // 
            // LblProtocol
            // 
            this.LblProtocol.AutoSize = true;
            this.LblProtocol.Location = new System.Drawing.Point(261, 13);
            this.LblProtocol.Name = "LblProtocol";
            this.LblProtocol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblProtocol.Size = new System.Drawing.Size(58, 13);
            this.LblProtocol.TabIndex = 2;
            this.LblProtocol.Text = "Protocol:";
            this.LblProtocol.Visible = false;
            // 
            // PnlPanel2
            // 
            this.PnlPanel2.Controls.Add(this.BtnExit);
            this.PnlPanel2.Controls.Add(this.BtnClean);
            this.PnlPanel2.Controls.Add(this.BtnSave);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 186);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(505, 52);
            this.PnlPanel2.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExit.Location = new System.Drawing.Point(182, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 50);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "&Exit";
            this.TTpTip.SetToolTip(this.BtnExit, "Exit from the system");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnClean.Location = new System.Drawing.Point(91, 0);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(93, 50);
            this.BtnClean.TabIndex = 1;
            this.BtnClean.TabStop = false;
            this.BtnClean.Text = "&Clean";
            this.TTpTip.SetToolTip(this.BtnClean, "Clean the fields");
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSave.Location = new System.Drawing.Point(0, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(93, 50);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.TabStop = false;
            this.BtnSave.Text = "&Save";
            this.TTpTip.SetToolTip(this.BtnSave, "Connect to the database");
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TTpTip
            // 
            this.TTpTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Folder-");
            this.Images.Images.SetKeyName(1, "Folder+");
            this.Images.Images.SetKeyName(2, "Command-");
            this.Images.Images.SetKeyName(3, "Command+");
            this.Images.Images.SetKeyName(4, "Save-");
            this.Images.Images.SetKeyName(5, "Save+");
            this.Images.Images.SetKeyName(6, "Clean-");
            this.Images.Images.SetKeyName(7, "Clean+");
            this.Images.Images.SetKeyName(8, "Exit-");
            this.Images.Images.SetKeyName(9, "Exit+");
            // 
            // ConnectionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 238);
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Configuration";
            this.Shown += new System.EventHandler(this.ConexaoF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConexaoF_KeyDown);
            this.PnlPanel1.ResumeLayout(false);
            this.PnlPanel1.PerformLayout();
            this.PnlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblServer;
        private System.Windows.Forms.Label LblFolder;
        private System.Windows.Forms.Label LblDatabase;
        private System.Windows.Forms.Label LblProtocol;
        private System.Windows.Forms.Label LblController;
        private System.Windows.Forms.Panel PnlPanel2;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CbBProtocol;
        private System.Windows.Forms.Button BtnFolder;
        private System.Windows.Forms.MaskedTextBox TxBPassword;
        private System.Windows.Forms.TextBox TxBServer;
        private System.Windows.Forms.TextBox TxBFolder;
        private System.Windows.Forms.TextBox TxBDatabase;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ComboBox CbBController;
        private System.Windows.Forms.TextBox TxBPort;
        private System.Windows.Forms.Label LblPort;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.CheckBox ChkSaveUserPassword;
        private System.Windows.Forms.TextBox TxBUser;
        private System.Windows.Forms.TextBox TxBCommand;
        private System.Windows.Forms.Label LblCommand;
        private System.Windows.Forms.Button BtnCommand;

    }
}