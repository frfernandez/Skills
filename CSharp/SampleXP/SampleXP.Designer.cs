namespace EmpireXP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.databaseMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseMapMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseCountriesMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseStatesMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseCitiesMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databasePersonsMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseMapMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseCountriesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseStatesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseCitiesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseDocumentsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databasePersonsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMapMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCountriesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStatesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCitiesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDocumentsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPersonsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionConnectMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionConnectWithMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionDisconnectMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.connectionConfigurationsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.connectionUpdatePrivilegesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseMenu1,
            this.exitMenu1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(234, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // databaseMenu1
            // 
            this.databaseMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseMapMenu1,
            this.databasePersonsMenu1});
            this.databaseMenu1.Name = "databaseMenu1";
            this.databaseMenu1.Size = new System.Drawing.Size(67, 20);
            this.databaseMenu1.Text = "Database";
            // 
            // databaseMapMenu1
            // 
            this.databaseMapMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseCountriesMenu1,
            this.databaseStatesMenu1,
            this.databaseCitiesMenu1});
            this.databaseMapMenu1.Name = "databaseMapMenu1";
            this.databaseMapMenu1.Size = new System.Drawing.Size(115, 22);
            this.databaseMapMenu1.Text = "Map";
            // 
            // databaseCountriesMenu1
            // 
            this.databaseCountriesMenu1.Name = "databaseCountriesMenu1";
            this.databaseCountriesMenu1.Size = new System.Drawing.Size(125, 22);
            this.databaseCountriesMenu1.Text = "Countries";
            this.databaseCountriesMenu1.Click += new System.EventHandler(this.databaseCountriesMenu1_Click);
            // 
            // databaseStatesMenu1
            // 
            this.databaseStatesMenu1.Name = "databaseStatesMenu1";
            this.databaseStatesMenu1.Size = new System.Drawing.Size(125, 22);
            this.databaseStatesMenu1.Text = "States";
            this.databaseStatesMenu1.Click += new System.EventHandler(this.databaseStatesMenu1_Click);
            // 
            // databaseCitiesMenu1
            // 
            this.databaseCitiesMenu1.Name = "databaseCitiesMenu1";
            this.databaseCitiesMenu1.Size = new System.Drawing.Size(125, 22);
            this.databaseCitiesMenu1.Text = "Cities";
            this.databaseCitiesMenu1.Click += new System.EventHandler(this.databaseCitiesMenu1_Click);
            // 
            // databasePersonsMenu1
            // 
            this.databasePersonsMenu1.Name = "databasePersonsMenu1";
            this.databasePersonsMenu1.Size = new System.Drawing.Size(115, 22);
            this.databasePersonsMenu1.Text = "Persons";
            this.databasePersonsMenu1.Click += new System.EventHandler(this.databasePersonsMenu1_Click);
            // 
            // exitMenu1
            // 
            this.exitMenu1.Name = "exitMenu1";
            this.exitMenu1.Size = new System.Drawing.Size(38, 20);
            this.exitMenu1.Text = "Exit";
            this.exitMenu1.Click += new System.EventHandler(this.exitMenu1_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseMenu2,
            this.searchMenu2,
            this.connectionMenu2,
            this.exitMenu2});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 92);
            // 
            // databaseMenu2
            // 
            this.databaseMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseMapMenu2,
            this.databaseDocumentsMenu2,
            this.databasePersonsMenu2});
            this.databaseMenu2.Name = "databaseMenu2";
            this.databaseMenu2.Size = new System.Drawing.Size(136, 22);
            this.databaseMenu2.Text = "Database";
            // 
            // databaseMapMenu2
            // 
            this.databaseMapMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseCountriesMenu2,
            this.databaseStatesMenu2,
            this.databaseCitiesMenu2});
            this.databaseMapMenu2.Name = "databaseMapMenu2";
            this.databaseMapMenu2.Size = new System.Drawing.Size(135, 22);
            this.databaseMapMenu2.Text = "Map";
            // 
            // databaseCountriesMenu2
            // 
            this.databaseCountriesMenu2.Name = "databaseCountriesMenu2";
            this.databaseCountriesMenu2.Size = new System.Drawing.Size(125, 22);
            this.databaseCountriesMenu2.Text = "Countries";
            this.databaseCountriesMenu2.Click += new System.EventHandler(this.databaseCountriesMenu1_Click);
            // 
            // databaseStatesMenu2
            // 
            this.databaseStatesMenu2.Name = "databaseStatesMenu2";
            this.databaseStatesMenu2.Size = new System.Drawing.Size(125, 22);
            this.databaseStatesMenu2.Text = "States";
            this.databaseStatesMenu2.Click += new System.EventHandler(this.databaseStatesMenu1_Click);
            // 
            // databaseCitiesMenu2
            // 
            this.databaseCitiesMenu2.Name = "databaseCitiesMenu2";
            this.databaseCitiesMenu2.Size = new System.Drawing.Size(125, 22);
            this.databaseCitiesMenu2.Text = "Cities";
            this.databaseCitiesMenu2.Click += new System.EventHandler(this.databaseCitiesMenu1_Click);
            // 
            // databaseDocumentsMenu2
            // 
            this.databaseDocumentsMenu2.Name = "databaseDocumentsMenu2";
            this.databaseDocumentsMenu2.Size = new System.Drawing.Size(135, 22);
            this.databaseDocumentsMenu2.Text = "Documents";
            // 
            // databasePersonsMenu2
            // 
            this.databasePersonsMenu2.Name = "databasePersonsMenu2";
            this.databasePersonsMenu2.Size = new System.Drawing.Size(135, 22);
            this.databasePersonsMenu2.Text = "Persons";
            this.databasePersonsMenu2.Click += new System.EventHandler(this.databasePersonsMenu1_Click);
            // 
            // searchMenu2
            // 
            this.searchMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchMapMenu2,
            this.searchDocumentsMenu2,
            this.searchPersonsMenu2});
            this.searchMenu2.Name = "searchMenu2";
            this.searchMenu2.Size = new System.Drawing.Size(136, 22);
            this.searchMenu2.Text = "Search";
            // 
            // searchMapMenu2
            // 
            this.searchMapMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchCountriesMenu2,
            this.searchStatesMenu2,
            this.searchCitiesMenu2});
            this.searchMapMenu2.Name = "searchMapMenu2";
            this.searchMapMenu2.Size = new System.Drawing.Size(135, 22);
            this.searchMapMenu2.Text = "Map";
            // 
            // searchCountriesMenu2
            // 
            this.searchCountriesMenu2.Name = "searchCountriesMenu2";
            this.searchCountriesMenu2.Size = new System.Drawing.Size(125, 22);
            this.searchCountriesMenu2.Text = "Countries";
            // 
            // searchStatesMenu2
            // 
            this.searchStatesMenu2.Name = "searchStatesMenu2";
            this.searchStatesMenu2.Size = new System.Drawing.Size(125, 22);
            this.searchStatesMenu2.Text = "States";
            // 
            // searchCitiesMenu2
            // 
            this.searchCitiesMenu2.Name = "searchCitiesMenu2";
            this.searchCitiesMenu2.Size = new System.Drawing.Size(125, 22);
            this.searchCitiesMenu2.Text = "Cities";
            // 
            // searchDocumentsMenu2
            // 
            this.searchDocumentsMenu2.Name = "searchDocumentsMenu2";
            this.searchDocumentsMenu2.Size = new System.Drawing.Size(135, 22);
            this.searchDocumentsMenu2.Text = "Documents";
            // 
            // searchPersonsMenu2
            // 
            this.searchPersonsMenu2.Name = "searchPersonsMenu2";
            this.searchPersonsMenu2.Size = new System.Drawing.Size(135, 22);
            this.searchPersonsMenu2.Text = "Persons";
            // 
            // connectionMenu2
            // 
            this.connectionMenu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionConnectMenu2,
            this.connectionConnectWithMenu2,
            this.connectionDisconnectMenu2,
            this.toolStripMenuItem2,
            this.connectionConfigurationsMenu2,
            this.toolStripMenuItem4,
            this.connectionUpdatePrivilegesMenu2});
            this.connectionMenu2.Name = "connectionMenu2";
            this.connectionMenu2.Size = new System.Drawing.Size(136, 22);
            this.connectionMenu2.Text = "Connection";
            // 
            // connectionConnectMenu2
            // 
            this.connectionConnectMenu2.Name = "connectionConnectMenu2";
            this.connectionConnectMenu2.Size = new System.Drawing.Size(165, 22);
            this.connectionConnectMenu2.Text = "Connect";
            // 
            // connectionConnectWithMenu2
            // 
            this.connectionConnectWithMenu2.Name = "connectionConnectWithMenu2";
            this.connectionConnectWithMenu2.Size = new System.Drawing.Size(165, 22);
            this.connectionConnectWithMenu2.Text = "Connect with...";
            // 
            // connectionDisconnectMenu2
            // 
            this.connectionDisconnectMenu2.Name = "connectionDisconnectMenu2";
            this.connectionDisconnectMenu2.Size = new System.Drawing.Size(165, 22);
            this.connectionDisconnectMenu2.Text = "Disconnect";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 6);
            // 
            // connectionConfigurationsMenu2
            // 
            this.connectionConfigurationsMenu2.Name = "connectionConfigurationsMenu2";
            this.connectionConfigurationsMenu2.Size = new System.Drawing.Size(165, 22);
            this.connectionConfigurationsMenu2.Text = "Configurations";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(162, 6);
            // 
            // connectionUpdatePrivilegesMenu2
            // 
            this.connectionUpdatePrivilegesMenu2.Name = "connectionUpdatePrivilegesMenu2";
            this.connectionUpdatePrivilegesMenu2.Size = new System.Drawing.Size(165, 22);
            this.connectionUpdatePrivilegesMenu2.Text = "Update Privileges";
            // 
            // exitMenu2
            // 
            this.exitMenu2.Name = "exitMenu2";
            this.exitMenu2.Size = new System.Drawing.Size(136, 22);
            this.exitMenu2.Text = "Exit";
            this.exitMenu2.Click += new System.EventHandler(this.exitMenu1_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "databaseMapMenu-");
            this.ImageList.Images.SetKeyName(1, "databaseMapMenu+");
            this.ImageList.Images.SetKeyName(2, "databaseCountriesMenu-");
            this.ImageList.Images.SetKeyName(3, "databaseCountriesMenu+");
            this.ImageList.Images.SetKeyName(4, "databaseStatesMenu-");
            this.ImageList.Images.SetKeyName(5, "databaseStatesMenu+");
            this.ImageList.Images.SetKeyName(6, "databaseCitiesMenu-");
            this.ImageList.Images.SetKeyName(7, "databaseCitiesMenu+");
            this.ImageList.Images.SetKeyName(8, "databaseDocumentsMenu-");
            this.ImageList.Images.SetKeyName(9, "databaseDocumentsMenu+");
            this.ImageList.Images.SetKeyName(10, "databasePersonsMenu-");
            this.ImageList.Images.SetKeyName(11, "databasePersonsMenu+");
            this.ImageList.Images.SetKeyName(12, "searchMapMenu-");
            this.ImageList.Images.SetKeyName(13, "searchMapMenu+");
            this.ImageList.Images.SetKeyName(14, "searchCountriesMenu+");
            this.ImageList.Images.SetKeyName(15, "searchCountriesMenu-");
            this.ImageList.Images.SetKeyName(16, "searchStatesMenu-");
            this.ImageList.Images.SetKeyName(17, "searchStatesMenu+");
            this.ImageList.Images.SetKeyName(18, "searchCitiesMenu-");
            this.ImageList.Images.SetKeyName(19, "searchCitiesMenu+");
            this.ImageList.Images.SetKeyName(20, "searchDocumentsMenu-");
            this.ImageList.Images.SetKeyName(21, "searchDocumentsMenu+");
            this.ImageList.Images.SetKeyName(22, "searchPersonsMenu-");
            this.ImageList.Images.SetKeyName(23, "searchPersonsMenu+");
            this.ImageList.Images.SetKeyName(24, "connectionConnectMenu-");
            this.ImageList.Images.SetKeyName(25, "connectionConnectMenu+");
            this.ImageList.Images.SetKeyName(26, "connectionConnectWithMenu-");
            this.ImageList.Images.SetKeyName(27, "connectionConnectWithMenu+");
            this.ImageList.Images.SetKeyName(28, "connectionDisconnectMenu-");
            this.ImageList.Images.SetKeyName(29, "connectionDisconnectMenu+");
            this.ImageList.Images.SetKeyName(30, "connectionConfigurationsMenu-");
            this.ImageList.Images.SetKeyName(31, "connectionConfigurationsMenu+");
            this.ImageList.Images.SetKeyName(32, "connectionUpdatePrivilegesMenu-");
            this.ImageList.Images.SetKeyName(33, "connectionUpdatePrivilegesMenu+");
            this.ImageList.Images.SetKeyName(34, "record-");
            this.ImageList.Images.SetKeyName(35, "record+");
            this.ImageList.Images.SetKeyName(36, "Exit-");
            this.ImageList.Images.SetKeyName(37, "Exit+");
            this.ImageList.Images.SetKeyName(38, "consulta-");
            this.ImageList.Images.SetKeyName(39, "consulta+");
            this.ImageList.Images.SetKeyName(40, "relatorio-");
            this.ImageList.Images.SetKeyName(41, "relatorio+");
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 135);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleXP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainF_FormClosing);
            this.Shown += new System.EventHandler(this.MainF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainF_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem databaseMenu1;
        private System.Windows.Forms.ToolStripMenuItem exitMenu1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem databaseMenu2;
        private System.Windows.Forms.ToolStripMenuItem searchMenu2;
        private System.Windows.Forms.ToolStripMenuItem connectionMenu2;
        private System.Windows.Forms.ToolStripMenuItem exitMenu2;
        private System.Windows.Forms.ToolStripMenuItem connectionConnectMenu2;
        private System.Windows.Forms.ToolStripMenuItem connectionConnectWithMenu2;
        private System.Windows.Forms.ToolStripMenuItem connectionDisconnectMenu2;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem connectionConfigurationsMenu2;
        private System.Windows.Forms.ToolStripMenuItem databaseMapMenu1;
        private System.Windows.Forms.ToolStripMenuItem databaseCountriesMenu1;
        private System.Windows.Forms.ToolStripMenuItem databaseStatesMenu1;
        private System.Windows.Forms.ToolStripMenuItem databaseCitiesMenu1;
        private System.Windows.Forms.ToolStripMenuItem databaseMapMenu2;
        private System.Windows.Forms.ToolStripMenuItem databaseCountriesMenu2;
        private System.Windows.Forms.ToolStripMenuItem databaseStatesMenu2;
        private System.Windows.Forms.ToolStripMenuItem databaseCitiesMenu2;
        private System.Windows.Forms.ToolStripMenuItem databaseDocumentsMenu2;
        private System.Windows.Forms.ToolStripMenuItem databasePersonsMenu1;
        private System.Windows.Forms.ToolStripMenuItem databasePersonsMenu2;
        private System.Windows.Forms.ToolStripMenuItem searchMapMenu2;
        private System.Windows.Forms.ToolStripMenuItem searchCountriesMenu2;
        private System.Windows.Forms.ToolStripMenuItem searchStatesMenu2;
        private System.Windows.Forms.ToolStripMenuItem searchCitiesMenu2;
        private System.Windows.Forms.ToolStripMenuItem searchDocumentsMenu2;
        private System.Windows.Forms.ToolStripMenuItem searchPersonsMenu2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem connectionUpdatePrivilegesMenu2;
    }
}