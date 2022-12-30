namespace Map
{
    partial class StatesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatesF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnReportStatesMenu = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnIUD = new System.Windows.Forms.Button();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.TxBCountry = new System.Windows.Forms.TextBox();
            this.BtnIdCountry = new System.Windows.Forms.Button();
            this.TxBIdCountry = new System.Windows.Forms.TextBox();
            this.LblCountry = new System.Windows.Forms.Label();
            this.TxBInitial = new System.Windows.Forms.TextBox();
            this.LblInitial = new System.Windows.Forms.Label();
            this.TxBId = new System.Windows.Forms.TextBox();
            this.TxBState = new System.Windows.Forms.TextBox();
            this.LblState = new System.Windows.Forms.Label();
            this.TTpDica = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseCountriesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnReportStatesMenu);
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
            // BtnReportStatesMenu
            // 
            this.BtnReportStatesMenu.Location = new System.Drawing.Point(374, 2);
            this.BtnReportStatesMenu.Name = "BtnReportStatesMenu";
            this.BtnReportStatesMenu.Size = new System.Drawing.Size(93, 50);
            this.BtnReportStatesMenu.TabIndex = 6;
            this.BtnReportStatesMenu.TabStop = false;
            this.BtnReportStatesMenu.Text = "&Report";
            this.TTpDica.SetToolTip(this.BtnReportStatesMenu, "Report of all records");
            this.BtnReportStatesMenu.UseVisualStyleBackColor = true;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(281, 2);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(93, 50);
            this.BtnFilter.TabIndex = 5;
            this.BtnFilter.TabStop = false;
            this.BtnFilter.Text = "&Filter";
            this.TTpDica.SetToolTip(this.BtnFilter, "Filter the records");
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
            this.TTpDica.SetToolTip(this.BtnExit, "Back to the prior form");
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
            this.TTpDica.SetToolTip(this.BtnCancel, "Cancel the action");
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnIUD
            // 
            this.BtnIUD.Location = new System.Drawing.Point(2, 2);
            this.BtnIUD.Name = "BtnIUD";
            this.BtnIUD.Size = new System.Drawing.Size(93, 50);
            this.BtnIUD.TabIndex = 0;
            this.BtnIUD.TabStop = false;
            this.BtnIUD.Text = "&Insert";
            this.TTpDica.SetToolTip(this.BtnIUD, "Execute the action");
            this.BtnIUD.UseVisualStyleBackColor = true;
            this.BtnIUD.Click += new System.EventHandler(this.BtnIUD_Click);
            // 
            // PnlPanel2
            // 
            this.PnlPanel2.Controls.Add(this.TxBCountry);
            this.PnlPanel2.Controls.Add(this.BtnIdCountry);
            this.PnlPanel2.Controls.Add(this.TxBIdCountry);
            this.PnlPanel2.Controls.Add(this.LblCountry);
            this.PnlPanel2.Controls.Add(this.TxBInitial);
            this.PnlPanel2.Controls.Add(this.LblInitial);
            this.PnlPanel2.Controls.Add(this.TxBId);
            this.PnlPanel2.Controls.Add(this.TxBState);
            this.PnlPanel2.Controls.Add(this.LblState);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(621, 124);
            this.PnlPanel2.TabIndex = 1;
            // 
            // TxBCountry
            // 
            this.TxBCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBCountry.Location = new System.Drawing.Point(112, 98);
            this.TxBCountry.Name = "TxBCountry";
            this.TxBCountry.ReadOnly = true;
            this.TxBCountry.Size = new System.Drawing.Size(502, 20);
            this.TxBCountry.TabIndex = 11;
            this.TxBCountry.TabStop = false;
            // 
            // BtnIdCountry
            // 
            this.BtnIdCountry.Location = new System.Drawing.Point(89, 98);
            this.BtnIdCountry.Name = "BtnIdCountry";
            this.BtnIdCountry.Size = new System.Drawing.Size(20, 20);
            this.BtnIdCountry.TabIndex = 10;
            this.BtnIdCountry.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnIdCountry, "Lista de todos Countries cadastrados");
            this.BtnIdCountry.UseVisualStyleBackColor = true;
            this.BtnIdCountry.Click += new System.EventHandler(this.BtnIdCountry_Click);
            // 
            // TxBIdCountry
            // 
            this.TxBIdCountry.Location = new System.Drawing.Point(8, 98);
            this.TxBIdCountry.Name = "TxBIdCountry";
            this.TxBIdCountry.Size = new System.Drawing.Size(80, 20);
            this.TxBIdCountry.TabIndex = 9;
            this.TxBIdCountry.Tag = "";
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(8, 82);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(54, 13);
            this.LblCountry.TabIndex = 8;
            this.LblCountry.Text = "Country:";
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
            // TxBState
            // 
            this.TxBState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBState.Location = new System.Drawing.Point(8, 20);
            this.TxBState.Name = "TxBState";
            this.TxBState.Size = new System.Drawing.Size(606, 20);
            this.TxBState.TabIndex = 0;
            this.TxBState.Tag = "";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(8, 4);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(41, 13);
            this.LblState.TabIndex = 0;
            this.LblState.Text = "State:";
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
            this.Images.Images.SetKeyName(10, "ReportStatesMenu-");
            this.Images.Images.SetKeyName(11, "ReportStatesMenu+");
            this.Images.Images.SetKeyName(12, "Exit-");
            this.Images.Images.SetKeyName(13, "Exit+");
            this.Images.Images.SetKeyName(14, "IdCountry-");
            this.Images.Images.SetKeyName(15, "IdCountry+");
            this.Images.Images.SetKeyName(16, "databaseCountriesMenu-");
            this.Images.Images.SetKeyName(17, "databaseCountriesMenu+");
            this.Images.Images.SetKeyName(18, "Navigator-");
            this.Images.Images.SetKeyName(19, "Navigator+");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseCountriesMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(126, 26);
            // 
            // databaseCountriesMenu2
            // 
            this.databaseCountriesMenu2.Name = "databaseCountriesMenu2";
            this.databaseCountriesMenu2.Size = new System.Drawing.Size(125, 22);
            this.databaseCountriesMenu2.Tag = "TxBIdCountry";
            this.databaseCountriesMenu2.Text = "Countries";
            this.databaseCountriesMenu2.Click += new System.EventHandler(this.databaseCountriesMenu2_Click);
            // 
            // StatesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 178);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatesF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "States";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatesF_FormClosing);
            this.Shown += new System.EventHandler(this.StatesF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatesF_KeyDown);
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
        private System.Windows.Forms.Button BtnReportStatesMenu;
        public System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Button BtnIUD;
        private System.Windows.Forms.Panel PnlPanel2;
        public System.Windows.Forms.TextBox TxBState;
        public System.Windows.Forms.TextBox TxBId;
        private System.Windows.Forms.ToolTip TTpDica;
        private System.Windows.Forms.ImageList Images;
        public System.Windows.Forms.TextBox TxBInitial;
        public System.Windows.Forms.Label LblInitial;
        private System.Windows.Forms.TextBox TxBCountry;
        private System.Windows.Forms.Button BtnIdCountry;
        private System.Windows.Forms.TextBox TxBIdCountry;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem databaseCountriesMenu2;


    }
}

