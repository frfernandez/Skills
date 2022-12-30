namespace Map
{
    partial class CountriesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountriesF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnReportCountriesMenu = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnIUD = new System.Windows.Forms.Button();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.TxBContinent = new System.Windows.Forms.TextBox();
            this.BtnIdContinent = new System.Windows.Forms.Button();
            this.TxBIdContinent = new System.Windows.Forms.TextBox();
            this.LblContinent = new System.Windows.Forms.Label();
            this.TxBInitial = new System.Windows.Forms.TextBox();
            this.LblInitial = new System.Windows.Forms.Label();
            this.TxBId = new System.Windows.Forms.TextBox();
            this.TxBCountry = new System.Windows.Forms.TextBox();
            this.LblCountry = new System.Windows.Forms.Label();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseContinentsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnReportCountriesMenu);
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
            // BtnReportCountriesMenu
            // 
            this.BtnReportCountriesMenu.Location = new System.Drawing.Point(373, 2);
            this.BtnReportCountriesMenu.Name = "BtnReportCountriesMenu";
            this.BtnReportCountriesMenu.Size = new System.Drawing.Size(93, 50);
            this.BtnReportCountriesMenu.TabIndex = 4;
            this.BtnReportCountriesMenu.TabStop = false;
            this.BtnReportCountriesMenu.Text = "&Report";
            this.TTpTip.SetToolTip(this.BtnReportCountriesMenu, "Report of all records");
            this.BtnReportCountriesMenu.UseVisualStyleBackColor = true;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(281, 2);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(93, 50);
            this.BtnFilter.TabIndex = 3;
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
            this.BtnExit.TabIndex = 2;
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
            this.BtnCancel.TabIndex = 1;
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
            this.PnlPanel2.Controls.Add(this.TxBContinent);
            this.PnlPanel2.Controls.Add(this.BtnIdContinent);
            this.PnlPanel2.Controls.Add(this.TxBIdContinent);
            this.PnlPanel2.Controls.Add(this.LblContinent);
            this.PnlPanel2.Controls.Add(this.TxBInitial);
            this.PnlPanel2.Controls.Add(this.LblInitial);
            this.PnlPanel2.Controls.Add(this.TxBId);
            this.PnlPanel2.Controls.Add(this.TxBCountry);
            this.PnlPanel2.Controls.Add(this.LblCountry);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(621, 127);
            this.PnlPanel2.TabIndex = 1;
            // 
            // TxBContinent
            // 
            this.TxBContinent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBContinent.Location = new System.Drawing.Point(112, 99);
            this.TxBContinent.Name = "TxBContinent";
            this.TxBContinent.ReadOnly = true;
            this.TxBContinent.Size = new System.Drawing.Size(502, 20);
            this.TxBContinent.TabIndex = 7;
            this.TxBContinent.TabStop = false;
            // 
            // BtnIdContinent
            // 
            this.BtnIdContinent.Location = new System.Drawing.Point(89, 99);
            this.BtnIdContinent.Name = "BtnIdContinent";
            this.BtnIdContinent.Size = new System.Drawing.Size(20, 20);
            this.BtnIdContinent.TabIndex = 6;
            this.BtnIdContinent.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdContinent, "Lista de todos Continents cadastrados");
            this.BtnIdContinent.UseVisualStyleBackColor = true;
            this.BtnIdContinent.Click += new System.EventHandler(this.BtnIdContinent_Click);
            // 
            // TxBIdContinent
            // 
            this.TxBIdContinent.Location = new System.Drawing.Point(8, 99);
            this.TxBIdContinent.Name = "TxBIdContinent";
            this.TxBIdContinent.Size = new System.Drawing.Size(80, 20);
            this.TxBIdContinent.TabIndex = 5;
            this.TxBIdContinent.Tag = "";
            this.TxBIdContinent.Leave += new System.EventHandler(this.TxBIdContinent_Leave);
            // 
            // LblContinent
            // 
            this.LblContinent.AutoSize = true;
            this.LblContinent.Location = new System.Drawing.Point(8, 83);
            this.LblContinent.Name = "LblContinent";
            this.LblContinent.Size = new System.Drawing.Size(65, 13);
            this.LblContinent.TabIndex = 4;
            this.LblContinent.Text = "Continent:";
            // 
            // TxBInitial
            // 
            this.TxBInitial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBInitial.Location = new System.Drawing.Point(8, 59);
            this.TxBInitial.Name = "TxBInitial";
            this.TxBInitial.Size = new System.Drawing.Size(66, 20);
            this.TxBInitial.TabIndex = 2;
            this.TxBInitial.Tag = "";
            // 
            // LblInitial
            // 
            this.LblInitial.AutoSize = true;
            this.LblInitial.Location = new System.Drawing.Point(8, 43);
            this.LblInitial.Name = "LblInitial";
            this.LblInitial.Size = new System.Drawing.Size(42, 13);
            this.LblInitial.TabIndex = 1;
            this.LblInitial.Text = "Initial:";
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
            // TxBCountry
            // 
            this.TxBCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBCountry.Location = new System.Drawing.Point(8, 20);
            this.TxBCountry.Name = "TxBCountry";
            this.TxBCountry.Size = new System.Drawing.Size(606, 20);
            this.TxBCountry.TabIndex = 0;
            this.TxBCountry.Tag = "";
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(8, 4);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(54, 13);
            this.LblCountry.TabIndex = 0;
            this.LblCountry.Text = "Country:";
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
            this.Images.Images.SetKeyName(10, "ReportCountriesMenu-");
            this.Images.Images.SetKeyName(11, "ReportCountriesMenu+");
            this.Images.Images.SetKeyName(12, "Exit-");
            this.Images.Images.SetKeyName(13, "Exit+");
            this.Images.Images.SetKeyName(14, "IdContinent-");
            this.Images.Images.SetKeyName(15, "IdContinent+");
            this.Images.Images.SetKeyName(16, "databaseContinentsMenu-");
            this.Images.Images.SetKeyName(17, "databaseContinentsMenu+");
            this.Images.Images.SetKeyName(18, "Navigator-");
            this.Images.Images.SetKeyName(19, "Navigator+");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseContinentsMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(133, 26);
            // 
            // databaseContinentsMenu2
            // 
            this.databaseContinentsMenu2.Name = "databaseContinentsMenu2";
            this.databaseContinentsMenu2.Size = new System.Drawing.Size(132, 22);
            this.databaseContinentsMenu2.Tag = "TxBIdContinent";
            this.databaseContinentsMenu2.Text = "Continents";
            this.databaseContinentsMenu2.Click += new System.EventHandler(this.databaseContinentsMenu2_Click);
            // 
            // CountriesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 181);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountriesF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Countries";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CountriesF_FormClosing);
            this.Shown += new System.EventHandler(this.CountriesF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CountriesF_KeyDown);
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
        private System.Windows.Forms.Button BtnReportCountriesMenu;
        public System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.Button BtnIUD;
        private System.Windows.Forms.Panel PnlPanel2;
        public System.Windows.Forms.TextBox TxBCountry;
        public System.Windows.Forms.TextBox TxBId;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        public System.Windows.Forms.TextBox TxBInitial;
        public System.Windows.Forms.Label LblInitial;
        private System.Windows.Forms.TextBox TxBContinent;
        private System.Windows.Forms.Button BtnIdContinent;
        private System.Windows.Forms.TextBox TxBIdContinent;
        private System.Windows.Forms.Label LblContinent;
        public System.Windows.Forms.ToolStripMenuItem databaseContinentsMenu2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;


    }
}

