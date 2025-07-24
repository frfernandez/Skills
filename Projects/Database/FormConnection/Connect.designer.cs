namespace Database.FormConnection
{
    partial class ConnectF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.TxBPassword = new System.Windows.Forms.MaskedTextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxBUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlPanel1.Controls.Add(this.TxBPassword);
            this.PnlPanel1.Controls.Add(this.LblPassword);
            this.PnlPanel1.Controls.Add(this.TxBUser);
            this.PnlPanel1.Controls.Add(this.LblUser);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(491, 101);
            this.PnlPanel1.TabIndex = 0;
            // 
            // TxBPassword
            // 
            this.TxBPassword.Location = new System.Drawing.Point(72, 25);
            this.TxBPassword.Name = "TxBPassword";
            this.TxBPassword.PasswordChar = '*';
            this.TxBPassword.Size = new System.Drawing.Size(414, 20);
            this.TxBPassword.TabIndex = 1;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(4, 29);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(65, 13);
            this.LblPassword.TabIndex = 15;
            this.LblPassword.Text = "Password:";
            // 
            // TxBUser
            // 
            this.TxBUser.Location = new System.Drawing.Point(72, 4);
            this.TxBUser.Name = "TxBUser";
            this.TxBUser.Size = new System.Drawing.Size(414, 20);
            this.TxBUser.TabIndex = 0;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(32, 8);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(37, 13);
            this.LblUser.TabIndex = 13;
            this.LblUser.Text = "User:";
            // 
            // PnlPanel2
            // 
            this.PnlPanel2.Controls.Add(this.BtnExit);
            this.PnlPanel2.Controls.Add(this.BtnClean);
            this.PnlPanel2.Controls.Add(this.BtnConnect);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 49);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(491, 52);
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
            // BtnConnect
            // 
            this.BtnConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConnect.Location = new System.Drawing.Point(0, 0);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(93, 50);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.TabStop = false;
            this.BtnConnect.Text = "&Connect";
            this.TTpTip.SetToolTip(this.BtnConnect, "Connect to the database");
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Connect-");
            this.Images.Images.SetKeyName(1, "Connect+");
            this.Images.Images.SetKeyName(2, "Clean-");
            this.Images.Images.SetKeyName(3, "Clean+");
            this.Images.Images.SetKeyName(4, "Exit-");
            this.Images.Images.SetKeyName(5, "Exit+");
            this.Images.Images.SetKeyName(6, "Help-");
            this.Images.Images.SetKeyName(7, "Help+");
            // 
            // ConnectF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 101);
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Identification";
            this.Shown += new System.EventHandler(this.ConnectF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectF_KeyDown);
            this.PnlPanel1.ResumeLayout(false);
            this.PnlPanel1.PerformLayout();
            this.PnlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Panel PnlPanel2;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.MaskedTextBox TxBPassword;
        private System.Windows.Forms.TextBox TxBUser;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;

    }
}