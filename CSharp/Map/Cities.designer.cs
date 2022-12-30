namespace Map
{
    partial class CitiesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitiesF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnReportCitiesMenu = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnIUD = new System.Windows.Forms.Button();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.TxBCountry = new System.Windows.Forms.TextBox();
            this.BtnIdCountry = new System.Windows.Forms.Button();
            this.TxBIdCountry = new System.Windows.Forms.TextBox();
            this.LblCountry = new System.Windows.Forms.Label();
            this.TxBState = new System.Windows.Forms.TextBox();
            this.BtnIdState = new System.Windows.Forms.Button();
            this.TxBIdState = new System.Windows.Forms.TextBox();
            this.LblState = new System.Windows.Forms.Label();
            this.TxBId = new System.Windows.Forms.TextBox();
            this.TxBCity = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseCountriesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseStatesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnReportCitiesMenu);
            this.PnlPanel1.Controls.Add(this.BtnFilter);
            this.PnlPanel1.Controls.Add(this.BtnExit);
            this.PnlPanel1.Controls.Add(this.BtnCancel);
            this.PnlPanel1.Controls.Add(this.BtnIUD);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(621, 54);
            this.PnlPanel1.TabIndex = 0;
            // 
            // BtnReportCitiesMenu
            // 
            this.BtnReportCitiesMenu.Location = new System.Drawing.Point(373, 2);
            this.BtnReportCitiesMenu.Name = "BtnReportCitiesMenu";
            this.BtnReportCitiesMenu.Size = new System.Drawing.Size(93, 50);
            this.BtnReportCitiesMenu.TabIndex = 6;
            this.BtnReportCitiesMenu.TabStop = false;
            this.BtnReportCitiesMenu.Text = "&Report ";
            this.TTpTip.SetToolTip(this.BtnReportCitiesMenu, "Report of all records");
            this.BtnReportCitiesMenu.UseVisualStyleBackColor = true;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(281, 2);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(93, 50);
            this.BtnFilter.TabIndex = 5;
            this.BtnFilter.TabStop = false;
            this.BtnFilter.Text = "&Filter";
            this.TTpTip.SetToolTip(this.BtnFilter, "Filter the records");
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(188, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 50);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "&Exit";
            this.TTpTip.SetToolTip(this.BtnExit, "Back to the prior form");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(95, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(93, 50);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "&Cancel";
            this.TTpTip.SetToolTip(this.BtnCancel, "Cancel the action");
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnIUD
            // 
            this.BtnIUD.Location = new System.Drawing.Point(2, 2);
            this.BtnIUD.Name = "BtnIUD";
            this.BtnIUD.Size = new System.Drawing.Size(93, 50);
            this.BtnIUD.TabIndex = 0;
            this.BtnIUD.TabStop = false;
            this.BtnIUD.Text = "&Insert";
            this.TTpTip.SetToolTip(this.BtnIUD, "Execute the action");
            this.BtnIUD.UseVisualStyleBackColor = true;
            this.BtnIUD.Click += new System.EventHandler(this.BtnIUD_Click);
            // 
            // PnlPanel2
            // 
            this.PnlPanel2.Controls.Add(this.TxBCountry);
            this.PnlPanel2.Controls.Add(this.BtnIdCountry);
            this.PnlPanel2.Controls.Add(this.TxBIdCountry);
            this.PnlPanel2.Controls.Add(this.LblCountry);
            this.PnlPanel2.Controls.Add(this.TxBState);
            this.PnlPanel2.Controls.Add(this.BtnIdState);
            this.PnlPanel2.Controls.Add(this.TxBIdState);
            this.PnlPanel2.Controls.Add(this.LblState);
            this.PnlPanel2.Controls.Add(this.TxBId);
            this.PnlPanel2.Controls.Add(this.TxBCity);
            this.PnlPanel2.Controls.Add(this.LblCity);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(621, 125);
            this.PnlPanel2.TabIndex = 1;
            // 
            // TxBCountry
            // 
            this.TxBCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBCountry.Location = new System.Drawing.Point(112, 60);
            this.TxBCountry.Name = "TxBCountry";
            this.TxBCountry.ReadOnly = true;
            this.TxBCountry.Size = new System.Drawing.Size(502, 20);
            this.TxBCountry.TabIndex = 4;
            this.TxBCountry.TabStop = false;
            // 
            // BtnIdCountry
            // 
            this.BtnIdCountry.Location = new System.Drawing.Point(89, 60);
            this.BtnIdCountry.Name = "BtnIdCountry";
            this.BtnIdCountry.Size = new System.Drawing.Size(20, 20);
            this.BtnIdCountry.TabIndex = 3;
            this.BtnIdCountry.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdCountry, "Lista de todos países cadastrados");
            this.BtnIdCountry.UseVisualStyleBackColor = true;
            this.BtnIdCountry.Click += new System.EventHandler(this.BtnIdCountry_Click);
            // 
            // TxBIdCountry
            // 
            this.TxBIdCountry.Location = new System.Drawing.Point(8, 60);
            this.TxBIdCountry.Name = "TxBIdCountry";
            this.TxBIdCountry.Size = new System.Drawing.Size(80, 20);
            this.TxBIdCountry.TabIndex = 2;
            this.TxBIdCountry.Tag = "";
            this.TxBIdCountry.Leave += new System.EventHandler(this.TxBIdCountry_Leave);
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(8, 44);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(54, 13);
            this.LblCountry.TabIndex = 1;
            this.LblCountry.Text = "Country:";
            // 
            // TxBState
            // 
            this.TxBState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBState.Location = new System.Drawing.Point(112, 100);
            this.TxBState.Name = "TxBState";
            this.TxBState.ReadOnly = true;
            this.TxBState.Size = new System.Drawing.Size(502, 20);
            this.TxBState.TabIndex = 8;
            this.TxBState.TabStop = false;
            // 
            // BtnIdState
            // 
            this.BtnIdState.Location = new System.Drawing.Point(89, 100);
            this.BtnIdState.Name = "BtnIdState";
            this.BtnIdState.Size = new System.Drawing.Size(20, 20);
            this.BtnIdState.TabIndex = 7;
            this.BtnIdState.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdState, "Lista de todos estados cadastrados");
            this.BtnIdState.UseVisualStyleBackColor = true;
            this.BtnIdState.Click += new System.EventHandler(this.BtnIdState_Click);
            // 
            // TxBIdState
            // 
            this.TxBIdState.Location = new System.Drawing.Point(8, 100);
            this.TxBIdState.Name = "TxBIdState";
            this.TxBIdState.Size = new System.Drawing.Size(80, 20);
            this.TxBIdState.TabIndex = 6;
            this.TxBIdState.Tag = "";
            this.TxBIdState.Leave += new System.EventHandler(this.TxBIdState_Leave);
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(8, 84);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(41, 13);
            this.LblState.TabIndex = 5;
            this.LblState.Text = "State:";
            // 
            // TxBId
            // 
            this.TxBId.Location = new System.Drawing.Point(8, 20);
            this.TxBId.Name = "TxBId";
            this.TxBId.Size = new System.Drawing.Size(80, 20);
            this.TxBId.TabIndex = 0;
            this.TxBId.Tag = "";
            this.TxBId.Visible = false;
            // 
            // TxBCity
            // 
            this.TxBCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBCity.Location = new System.Drawing.Point(8, 20);
            this.TxBCity.Name = "TxBCity";
            this.TxBCity.Size = new System.Drawing.Size(606, 20);
            this.TxBCity.TabIndex = 0;
            this.TxBCity.Tag = "";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(8, 4);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(32, 13);
            this.LblCity.TabIndex = 0;
            this.LblCity.Text = "City:";
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Update-");
            this.Images.Images.SetKeyName(1, "Update+");
            this.Images.Images.SetKeyName(2, "Cancel-");
            this.Images.Images.SetKeyName(3, "Cancel+");
            this.Images.Images.SetKeyName(4, "Delete-");
            this.Images.Images.SetKeyName(5, "Delete+");
            this.Images.Images.SetKeyName(6, "Filter-");
            this.Images.Images.SetKeyName(7, "Filter+");
            this.Images.Images.SetKeyName(8, "Insert-");
            this.Images.Images.SetKeyName(9, "Insert+");
            this.Images.Images.SetKeyName(10, "ReportCitiesMenu-");
            this.Images.Images.SetKeyName(11, "ReportCitiesMenu+");
            this.Images.Images.SetKeyName(12, "Exit-");
            this.Images.Images.SetKeyName(13, "Exit+");
            this.Images.Images.SetKeyName(14, "IdCountry-");
            this.Images.Images.SetKeyName(15, "IdCountry+");
            this.Images.Images.SetKeyName(16, "IdState-");
            this.Images.Images.SetKeyName(17, "IdState+");
            this.Images.Images.SetKeyName(18, "databaseCountriesMenu-");
            this.Images.Images.SetKeyName(19, "databaseCountriesMenu+");
            this.Images.Images.SetKeyName(20, "databaseStatesMenu-");
            this.Images.Images.SetKeyName(21, "databaseStatesMenu+");
            this.Images.Images.SetKeyName(22, "Navigator-");
            this.Images.Images.SetKeyName(23, "Navigator+");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseCountriesMenu2,
            this.databaseStatesMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(126, 48);
            // 
            // databaseCountriesMenu2
            // 
            this.databaseCountriesMenu2.Name = "databaseCountriesMenu2";
            this.databaseCountriesMenu2.Size = new System.Drawing.Size(125, 22);
            this.databaseCountriesMenu2.Tag = "TxBIdCountry";
            this.databaseCountriesMenu2.Text = "Countries";
            this.databaseCountriesMenu2.Click += new System.EventHandler(this.databaseCountriesMenu2_Click);
            // 
            // databaseStatesMenu2
            // 
            this.databaseStatesMenu2.Name = "databaseStatesMenu2";
            this.databaseStatesMenu2.Size = new System.Drawing.Size(125, 22);
            this.databaseStatesMenu2.Tag = "TxBIdState";
            this.databaseStatesMenu2.Text = "States";
            this.databaseStatesMenu2.Click += new System.EventHandler(this.databaseStatesMenu2_Click);
            // 
            // CitiesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 179);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CitiesF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cities";
            this.Shown += new System.EventHandler(this.CitiesF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CitiesF_KeyDown);
            this.PnlPanel1.ResumeLayout(false);
            this.PnlPanel2.ResumeLayout(false);
            this.PnlPanel2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnReportCitiesMenu;
        public System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Button BtnIUD;
        private System.Windows.Forms.Panel PnlPanel2;
        public System.Windows.Forms.TextBox TxBCity;
        public System.Windows.Forms.TextBox TxBId;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.TextBox TxBState;
        private System.Windows.Forms.Button BtnIdState;
        private System.Windows.Forms.TextBox TxBIdState;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.TextBox TxBCountry;
        private System.Windows.Forms.Button BtnIdCountry;
        private System.Windows.Forms.TextBox TxBIdCountry;
        private System.Windows.Forms.Label LblCountry;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem databaseStatesMenu2;
        public System.Windows.Forms.ToolStripMenuItem databaseCountriesMenu2;


    }
}

