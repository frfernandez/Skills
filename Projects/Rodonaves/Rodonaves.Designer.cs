namespace Rodonaves
{
    partial class MainF
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
            this.PcBImage = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.databaseMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseUnidadesMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseUsuariosMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionConnectMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionConnectWithMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionDisconnectMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectionConfigurationsMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.databaseColaboradoresMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PcBImage)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PcBImage
            // 
            this.PcBImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PcBImage.Location = new System.Drawing.Point(0, 24);
            this.PcBImage.Name = "PcBImage";
            this.PcBImage.Size = new System.Drawing.Size(514, 337);
            this.PcBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcBImage.TabIndex = 0;
            this.PcBImage.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseMenu1,
            this.searchMenu1,
            this.connectionMenu1,
            this.exitMenu1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(514, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // databaseMenu1
            // 
            this.databaseMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseUnidadesMenu1,
            this.databaseUsuariosMenu1,
            this.databaseColaboradoresMenu1});
            this.databaseMenu1.Name = "databaseMenu1";
            this.databaseMenu1.Size = new System.Drawing.Size(70, 20);
            this.databaseMenu1.Text = "Database";
            // 
            // databaseUnidadesMenu1
            // 
            this.databaseUnidadesMenu1.Name = "databaseUnidadesMenu1";
            this.databaseUnidadesMenu1.Size = new System.Drawing.Size(180, 22);
            this.databaseUnidadesMenu1.Text = "Unidades";
            this.databaseUnidadesMenu1.Click += new System.EventHandler(this.databaseUnidadesMenu1_Click);
            // 
            // databaseUsuariosMenu1
            // 
            this.databaseUsuariosMenu1.Name = "databaseUsuariosMenu1";
            this.databaseUsuariosMenu1.Size = new System.Drawing.Size(180, 22);
            this.databaseUsuariosMenu1.Text = "Usuários";
            this.databaseUsuariosMenu1.Click += new System.EventHandler(this.databaseUsuariosMenu1_Click);
            // 
            // searchMenu1
            // 
            this.searchMenu1.Name = "searchMenu1";
            this.searchMenu1.Size = new System.Drawing.Size(57, 20);
            this.searchMenu1.Text = "Search";
            // 
            // connectionMenu1
            // 
            this.connectionMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionConnectMenu1,
            this.connectionConnectWithMenu1,
            this.connectionDisconnectMenu1,
            this.toolStripMenuItem1,
            this.connectionConfigurationsMenu1});
            this.connectionMenu1.Name = "connectionMenu1";
            this.connectionMenu1.Size = new System.Drawing.Size(82, 20);
            this.connectionMenu1.Text = "Connection";
            // 
            // connectionConnectMenu1
            // 
            this.connectionConnectMenu1.Name = "connectionConnectMenu1";
            this.connectionConnectMenu1.Size = new System.Drawing.Size(157, 22);
            this.connectionConnectMenu1.Text = "Connect";
            this.connectionConnectMenu1.Click += new System.EventHandler(this.connectionConnectMenu1_Click);
            // 
            // connectionConnectWithMenu1
            // 
            this.connectionConnectWithMenu1.Name = "connectionConnectWithMenu1";
            this.connectionConnectWithMenu1.Size = new System.Drawing.Size(157, 22);
            this.connectionConnectWithMenu1.Text = "Connect with...";
            this.connectionConnectWithMenu1.Click += new System.EventHandler(this.connectionConnectWithMenu1_Click);
            // 
            // connectionDisconnectMenu1
            // 
            this.connectionDisconnectMenu1.Name = "connectionDisconnectMenu1";
            this.connectionDisconnectMenu1.Size = new System.Drawing.Size(157, 22);
            this.connectionDisconnectMenu1.Text = "Disconnect";
            this.connectionDisconnectMenu1.Click += new System.EventHandler(this.connectionDisconnectMenu1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // connectionConfigurationsMenu1
            // 
            this.connectionConfigurationsMenu1.Name = "connectionConfigurationsMenu1";
            this.connectionConfigurationsMenu1.Size = new System.Drawing.Size(157, 22);
            this.connectionConfigurationsMenu1.Text = "Configurations";
            this.connectionConfigurationsMenu1.Click += new System.EventHandler(this.connectionConfigurationsMenu1_Click);
            // 
            // exitMenu1
            // 
            this.exitMenu1.Name = "exitMenu1";
            this.exitMenu1.Size = new System.Drawing.Size(40, 20);
            this.exitMenu1.Text = "Exit";
            this.exitMenu1.Click += new System.EventHandler(this.exitMenu1_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // databaseColaboradoresMenu1
            // 
            this.databaseColaboradoresMenu1.Name = "databaseColaboradoresMenu1";
            this.databaseColaboradoresMenu1.Size = new System.Drawing.Size(180, 22);
            this.databaseColaboradoresMenu1.Text = "Colaboradores";
            this.databaseColaboradoresMenu1.Click += new System.EventHandler(this.databaseColaboradoresMenu1_Click);
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 361);
            this.Controls.Add(this.PcBImage);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rodonaves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainF_FormClosing);
            this.Shown += new System.EventHandler(this.MainF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainF_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PcBImage)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcBImage;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem databaseMenu1;
        private System.Windows.Forms.ToolStripMenuItem searchMenu1;
        private System.Windows.Forms.ToolStripMenuItem connectionMenu1;
        private System.Windows.Forms.ToolStripMenuItem connectionConnectMenu1;
        private System.Windows.Forms.ToolStripMenuItem connectionConnectWithMenu1;
        private System.Windows.Forms.ToolStripMenuItem connectionDisconnectMenu1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectionConfigurationsMenu1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu1;
        private System.Windows.Forms.ToolStripMenuItem databaseUnidadesMenu1;
        private System.Windows.Forms.ToolStripMenuItem databaseUsuariosMenu1;
        private System.Windows.Forms.ToolStripMenuItem databaseColaboradoresMenu1;
    }
}

