namespace People
{
    partial class PersonsF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonsF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databasePersonsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseNeighborhoodsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseAddressesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseDistrictsMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseCitiesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnReportPersonsMenu = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnIUD = new System.Windows.Forms.Button();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnIdPerson = new System.Windows.Forms.Button();
            this.BtnIdCity = new System.Windows.Forms.Button();
            this.BtnIdDistrict = new System.Windows.Forms.Button();
            this.BtnIdAddress = new System.Windows.Forms.Button();
            this.BtnIdNeighborhood = new System.Windows.Forms.Button();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.TxBContinent = new System.Windows.Forms.TextBox();
            this.TxBIdContinent = new System.Windows.Forms.TextBox();
            this.LblContinent = new System.Windows.Forms.Label();
            this.TxBCountryInitial = new System.Windows.Forms.TextBox();
            this.LblCountryInitial = new System.Windows.Forms.Label();
            this.TxBCountry = new System.Windows.Forms.TextBox();
            this.TxBIdCountry = new System.Windows.Forms.TextBox();
            this.LblCountry = new System.Windows.Forms.Label();
            this.TxBStateInitial = new System.Windows.Forms.TextBox();
            this.LblStateInitial = new System.Windows.Forms.Label();
            this.TxBState = new System.Windows.Forms.TextBox();
            this.TxBIdState = new System.Windows.Forms.TextBox();
            this.LblState = new System.Windows.Forms.Label();
            this.MkBPostalArea = new System.Windows.Forms.MaskedTextBox();
            this.TxBCity = new System.Windows.Forms.TextBox();
            this.TxBIdCity = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxBDistrict = new System.Windows.Forms.TextBox();
            this.TxBIdDistrict = new System.Windows.Forms.TextBox();
            this.LblDistrict = new System.Windows.Forms.Label();
            this.TxBComplement = new System.Windows.Forms.TextBox();
            this.LblComplement = new System.Windows.Forms.Label();
            this.TxBNumber = new System.Windows.Forms.TextBox();
            this.LblNumber = new System.Windows.Forms.Label();
            this.TxBAddress = new System.Windows.Forms.TextBox();
            this.TxBIdAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxBNeighborhood = new System.Windows.Forms.TextBox();
            this.TxBIdNeighborhood = new System.Windows.Forms.TextBox();
            this.LblNeighborhood = new System.Windows.Forms.Label();
            this.LblPostalArea = new System.Windows.Forms.Label();
            this.TxBIdPerson = new System.Windows.Forms.TextBox();
            this.TxBPerson = new System.Windows.Forms.TextBox();
            this.LblPerson = new System.Windows.Forms.Label();
            this.PnlPanel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.ContextMenuStrip = this.contextMenuStrip;
            this.PnlPanel1.Controls.Add(this.BtnReportPersonsMenu);
            this.PnlPanel1.Controls.Add(this.BtnExit);
            this.PnlPanel1.Controls.Add(this.BtnCancel);
            this.PnlPanel1.Controls.Add(this.BtnIUD);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(624, 54);
            this.PnlPanel1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databasePersonsMenu2,
            this.databaseNeighborhoodsMenu2,
            this.databaseAddressesMenu2,
            this.databaseDistrictsMenu2,
            this.databaseCitiesMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(158, 114);
            // 
            // databasePersonsMenu2
            // 
            this.databasePersonsMenu2.Name = "databasePersonsMenu2";
            this.databasePersonsMenu2.Size = new System.Drawing.Size(157, 22);
            this.databasePersonsMenu2.Tag = "TxBIdPerson";
            this.databasePersonsMenu2.Text = "Persons";
            this.databasePersonsMenu2.Click += new System.EventHandler(this.databasePersonsMenu2_Click);
            // 
            // databaseNeighborhoodsMenu2
            // 
            this.databaseNeighborhoodsMenu2.Name = "databaseNeighborhoodsMenu2";
            this.databaseNeighborhoodsMenu2.Size = new System.Drawing.Size(157, 22);
            this.databaseNeighborhoodsMenu2.Tag = "TxBIdNeighborhood";
            this.databaseNeighborhoodsMenu2.Text = "Neighborhoods";
            this.databaseNeighborhoodsMenu2.Click += new System.EventHandler(this.databaseNeighborhoodsMenu2_Click);
            // 
            // databaseAddressesMenu2
            // 
            this.databaseAddressesMenu2.Name = "databaseAddressesMenu2";
            this.databaseAddressesMenu2.Size = new System.Drawing.Size(157, 22);
            this.databaseAddressesMenu2.Tag = "TxBIdAddress";
            this.databaseAddressesMenu2.Text = "Addresses";
            this.databaseAddressesMenu2.Click += new System.EventHandler(this.databaseAddressesMenu2_Click);
            // 
            // databaseDistrictsMenu2
            // 
            this.databaseDistrictsMenu2.Name = "databaseDistrictsMenu2";
            this.databaseDistrictsMenu2.Size = new System.Drawing.Size(157, 22);
            this.databaseDistrictsMenu2.Tag = "TxBIdDistrict";
            this.databaseDistrictsMenu2.Text = "District:s";
            this.databaseDistrictsMenu2.Click += new System.EventHandler(this.databaseDistrictsMenu2_Click);
            // 
            // databaseCitiesMenu2
            // 
            this.databaseCitiesMenu2.Name = "databaseCitiesMenu2";
            this.databaseCitiesMenu2.Size = new System.Drawing.Size(157, 22);
            this.databaseCitiesMenu2.Tag = "TxBIdCity";
            this.databaseCitiesMenu2.Text = "Cities";
            this.databaseCitiesMenu2.Click += new System.EventHandler(this.databaseCitiesMenu2_Click);
            // 
            // BtnReportPersonsMenu
            // 
            this.BtnReportPersonsMenu.Location = new System.Drawing.Point(281, 2);
            this.BtnReportPersonsMenu.Name = "BtnReportPersonsMenu";
            this.BtnReportPersonsMenu.Size = new System.Drawing.Size(93, 50);
            this.BtnReportPersonsMenu.TabIndex = 4;
            this.BtnReportPersonsMenu.TabStop = false;
            this.BtnReportPersonsMenu.Text = "&Report";
            this.TTpTip.SetToolTip(this.BtnReportPersonsMenu, "Report of all records");
            this.BtnReportPersonsMenu.UseVisualStyleBackColor = true;
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
            // BtnIdPerson
            // 
            this.BtnIdPerson.Location = new System.Drawing.Point(174, 4);
            this.BtnIdPerson.Name = "BtnIdPerson";
            this.BtnIdPerson.Size = new System.Drawing.Size(20, 20);
            this.BtnIdPerson.TabIndex = 3;
            this.BtnIdPerson.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdPerson, "List of all persons");
            this.BtnIdPerson.UseVisualStyleBackColor = true;
            // 
            // BtnIdCity
            // 
            this.BtnIdCity.Location = new System.Drawing.Point(174, 48);
            this.BtnIdCity.Name = "BtnIdCity";
            this.BtnIdCity.Size = new System.Drawing.Size(20, 20);
            this.BtnIdCity.TabIndex = 11;
            this.BtnIdCity.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdCity, "List of all cities");
            this.BtnIdCity.UseVisualStyleBackColor = true;
            // 
            // BtnIdDistrict
            // 
            this.BtnIdDistrict.Location = new System.Drawing.Point(174, 26);
            this.BtnIdDistrict.Name = "BtnIdDistrict";
            this.BtnIdDistrict.Size = new System.Drawing.Size(20, 20);
            this.BtnIdDistrict.TabIndex = 7;
            this.BtnIdDistrict.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdDistrict, "List of all districts");
            this.BtnIdDistrict.UseVisualStyleBackColor = true;
            // 
            // BtnIdAddress
            // 
            this.BtnIdAddress.Location = new System.Drawing.Point(174, 166);
            this.BtnIdAddress.Name = "BtnIdAddress";
            this.BtnIdAddress.Size = new System.Drawing.Size(20, 20);
            this.BtnIdAddress.TabIndex = 34;
            this.BtnIdAddress.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdAddress, "List of all address");
            this.BtnIdAddress.UseVisualStyleBackColor = true;
            // 
            // BtnIdNeighborhood
            // 
            this.BtnIdNeighborhood.Location = new System.Drawing.Point(174, 143);
            this.BtnIdNeighborhood.Name = "BtnIdNeighborhood";
            this.BtnIdNeighborhood.Size = new System.Drawing.Size(20, 20);
            this.BtnIdNeighborhood.TabIndex = 30;
            this.BtnIdNeighborhood.TabStop = false;
            this.TTpTip.SetToolTip(this.BtnIdNeighborhood, "List of all neighborhoods");
            this.BtnIdNeighborhood.UseVisualStyleBackColor = true;
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
            this.Images.Images.SetKeyName(10, "ReportPersonsMenu-");
            this.Images.Images.SetKeyName(11, "ReportPersonsMenu+");
            this.Images.Images.SetKeyName(12, "Exit-");
            this.Images.Images.SetKeyName(13, "Exit+");
            this.Images.Images.SetKeyName(14, "IdPerson-");
            this.Images.Images.SetKeyName(15, "IdPerson+");
            this.Images.Images.SetKeyName(16, "IdNeighborhood-");
            this.Images.Images.SetKeyName(17, "IdNeighborhood+");
            this.Images.Images.SetKeyName(18, "IdAddress-");
            this.Images.Images.SetKeyName(19, "IdAddress+");
            this.Images.Images.SetKeyName(20, "IdDistrict-");
            this.Images.Images.SetKeyName(21, "IdDistrict+");
            this.Images.Images.SetKeyName(22, "IdCity-");
            this.Images.Images.SetKeyName(23, "IdCity+");
            this.Images.Images.SetKeyName(24, "Photograph-");
            this.Images.Images.SetKeyName(25, "Photograph+");
            this.Images.Images.SetKeyName(26, "IdTelephoneType-");
            this.Images.Images.SetKeyName(27, "IdTelephoneType+");
            this.Images.Images.SetKeyName(28, "IdCommunicationType-");
            this.Images.Images.SetKeyName(29, "IdCommunicationType+");
            this.Images.Images.SetKeyName(30, "IdDocumentType-");
            this.Images.Images.SetKeyName(31, "IdDocumentType+");
            this.Images.Images.SetKeyName(32, "Add-");
            this.Images.Images.SetKeyName(33, "Add+");
            this.Images.Images.SetKeyName(34, "Update-");
            this.Images.Images.SetKeyName(35, "Update+");
            this.Images.Images.SetKeyName(36, "Remove-");
            this.Images.Images.SetKeyName(37, "Remove+");
            this.Images.Images.SetKeyName(38, "Navigator-");
            this.Images.Images.SetKeyName(39, "Navigator+");
            // 
            // PnlPanel2
            // 
            this.PnlPanel2.Controls.Add(this.BtnIdPerson);
            this.PnlPanel2.Controls.Add(this.TxBContinent);
            this.PnlPanel2.Controls.Add(this.TxBIdContinent);
            this.PnlPanel2.Controls.Add(this.LblContinent);
            this.PnlPanel2.Controls.Add(this.TxBCountryInitial);
            this.PnlPanel2.Controls.Add(this.LblCountryInitial);
            this.PnlPanel2.Controls.Add(this.TxBCountry);
            this.PnlPanel2.Controls.Add(this.TxBIdCountry);
            this.PnlPanel2.Controls.Add(this.LblCountry);
            this.PnlPanel2.Controls.Add(this.TxBStateInitial);
            this.PnlPanel2.Controls.Add(this.LblStateInitial);
            this.PnlPanel2.Controls.Add(this.TxBState);
            this.PnlPanel2.Controls.Add(this.TxBIdState);
            this.PnlPanel2.Controls.Add(this.LblState);
            this.PnlPanel2.Controls.Add(this.MkBPostalArea);
            this.PnlPanel2.Controls.Add(this.TxBCity);
            this.PnlPanel2.Controls.Add(this.BtnIdCity);
            this.PnlPanel2.Controls.Add(this.TxBIdCity);
            this.PnlPanel2.Controls.Add(this.LblCity);
            this.PnlPanel2.Controls.Add(this.TxBDistrict);
            this.PnlPanel2.Controls.Add(this.BtnIdDistrict);
            this.PnlPanel2.Controls.Add(this.TxBIdDistrict);
            this.PnlPanel2.Controls.Add(this.LblDistrict);
            this.PnlPanel2.Controls.Add(this.TxBComplement);
            this.PnlPanel2.Controls.Add(this.LblComplement);
            this.PnlPanel2.Controls.Add(this.TxBNumber);
            this.PnlPanel2.Controls.Add(this.LblNumber);
            this.PnlPanel2.Controls.Add(this.TxBAddress);
            this.PnlPanel2.Controls.Add(this.BtnIdAddress);
            this.PnlPanel2.Controls.Add(this.TxBIdAddress);
            this.PnlPanel2.Controls.Add(this.LblAddress);
            this.PnlPanel2.Controls.Add(this.TxBNeighborhood);
            this.PnlPanel2.Controls.Add(this.BtnIdNeighborhood);
            this.PnlPanel2.Controls.Add(this.TxBIdNeighborhood);
            this.PnlPanel2.Controls.Add(this.LblNeighborhood);
            this.PnlPanel2.Controls.Add(this.LblPostalArea);
            this.PnlPanel2.Controls.Add(this.TxBIdPerson);
            this.PnlPanel2.Controls.Add(this.TxBPerson);
            this.PnlPanel2.Controls.Add(this.LblPerson);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(624, 217);
            this.PnlPanel2.TabIndex = 1;
            // 
            // TxBContinent
            // 
            this.TxBContinent.Location = new System.Drawing.Point(174, 119);
            this.TxBContinent.Name = "TxBContinent";
            this.TxBContinent.ReadOnly = true;
            this.TxBContinent.Size = new System.Drawing.Size(294, 20);
            this.TxBContinent.TabIndex = 25;
            this.TxBContinent.TabStop = false;
            // 
            // TxBIdContinent
            // 
            this.TxBIdContinent.Location = new System.Drawing.Point(92, 119);
            this.TxBIdContinent.Name = "TxBIdContinent";
            this.TxBIdContinent.ReadOnly = true;
            this.TxBIdContinent.Size = new System.Drawing.Size(80, 20);
            this.TxBIdContinent.TabIndex = 24;
            this.TxBIdContinent.TabStop = false;
            // 
            // LblContinent
            // 
            this.LblContinent.AutoSize = true;
            this.LblContinent.Location = new System.Drawing.Point(26, 123);
            this.LblContinent.Name = "LblContinent";
            this.LblContinent.Size = new System.Drawing.Size(65, 13);
            this.LblContinent.TabIndex = 23;
            this.LblContinent.Text = "Continent:";
            // 
            // TxBCountryInitial
            // 
            this.TxBCountryInitial.Location = new System.Drawing.Point(519, 95);
            this.TxBCountryInitial.Name = "TxBCountryInitial";
            this.TxBCountryInitial.ReadOnly = true;
            this.TxBCountryInitial.Size = new System.Drawing.Size(80, 20);
            this.TxBCountryInitial.TabIndex = 22;
            this.TxBCountryInitial.TabStop = false;
            // 
            // LblCountryInitial
            // 
            this.LblCountryInitial.AutoSize = true;
            this.LblCountryInitial.Location = new System.Drawing.Point(473, 99);
            this.LblCountryInitial.Name = "LblCountryInitial";
            this.LblCountryInitial.Size = new System.Drawing.Size(42, 13);
            this.LblCountryInitial.TabIndex = 21;
            this.LblCountryInitial.Text = "Initial:";
            // 
            // TxBCountry
            // 
            this.TxBCountry.Location = new System.Drawing.Point(174, 95);
            this.TxBCountry.Name = "TxBCountry";
            this.TxBCountry.ReadOnly = true;
            this.TxBCountry.Size = new System.Drawing.Size(294, 20);
            this.TxBCountry.TabIndex = 20;
            this.TxBCountry.TabStop = false;
            // 
            // TxBIdCountry
            // 
            this.TxBIdCountry.Location = new System.Drawing.Point(92, 95);
            this.TxBIdCountry.Name = "TxBIdCountry";
            this.TxBIdCountry.ReadOnly = true;
            this.TxBIdCountry.Size = new System.Drawing.Size(80, 20);
            this.TxBIdCountry.TabIndex = 19;
            this.TxBIdCountry.TabStop = false;
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Location = new System.Drawing.Point(37, 99);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(54, 13);
            this.LblCountry.TabIndex = 18;
            this.LblCountry.Text = "Country:";
            // 
            // TxBStateInitial
            // 
            this.TxBStateInitial.Location = new System.Drawing.Point(519, 71);
            this.TxBStateInitial.Name = "TxBStateInitial";
            this.TxBStateInitial.ReadOnly = true;
            this.TxBStateInitial.Size = new System.Drawing.Size(80, 20);
            this.TxBStateInitial.TabIndex = 17;
            this.TxBStateInitial.TabStop = false;
            // 
            // LblStateInitial
            // 
            this.LblStateInitial.AutoSize = true;
            this.LblStateInitial.Location = new System.Drawing.Point(473, 75);
            this.LblStateInitial.Name = "LblStateInitial";
            this.LblStateInitial.Size = new System.Drawing.Size(42, 13);
            this.LblStateInitial.TabIndex = 16;
            this.LblStateInitial.Text = "Initial:";
            // 
            // TxBState
            // 
            this.TxBState.Location = new System.Drawing.Point(174, 71);
            this.TxBState.Name = "TxBState";
            this.TxBState.ReadOnly = true;
            this.TxBState.Size = new System.Drawing.Size(294, 20);
            this.TxBState.TabIndex = 15;
            this.TxBState.TabStop = false;
            // 
            // TxBIdState
            // 
            this.TxBIdState.Location = new System.Drawing.Point(92, 71);
            this.TxBIdState.Name = "TxBIdState";
            this.TxBIdState.ReadOnly = true;
            this.TxBIdState.Size = new System.Drawing.Size(80, 20);
            this.TxBIdState.TabIndex = 14;
            this.TxBIdState.TabStop = false;
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(50, 75);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(41, 13);
            this.LblState.TabIndex = 13;
            this.LblState.Text = "State:";
            // 
            // MkBPostalArea
            // 
            this.MkBPostalArea.Location = new System.Drawing.Point(526, 119);
            this.MkBPostalArea.Name = "MkBPostalArea";
            this.MkBPostalArea.Size = new System.Drawing.Size(73, 20);
            this.MkBPostalArea.TabIndex = 27;
            // 
            // TxBCity
            // 
            this.TxBCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBCity.Location = new System.Drawing.Point(197, 48);
            this.TxBCity.Name = "TxBCity";
            this.TxBCity.ReadOnly = true;
            this.TxBCity.Size = new System.Drawing.Size(402, 20);
            this.TxBCity.TabIndex = 12;
            this.TxBCity.TabStop = false;
            // 
            // TxBIdCity
            // 
            this.TxBIdCity.Location = new System.Drawing.Point(92, 48);
            this.TxBIdCity.Name = "TxBIdCity";
            this.TxBIdCity.Size = new System.Drawing.Size(80, 20);
            this.TxBIdCity.TabIndex = 10;
            this.TxBIdCity.Tag = "";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(59, 52);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(32, 13);
            this.LblCity.TabIndex = 9;
            this.LblCity.Text = "City:";
            // 
            // TxBDistrict
            // 
            this.TxBDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBDistrict.Location = new System.Drawing.Point(197, 26);
            this.TxBDistrict.Name = "TxBDistrict";
            this.TxBDistrict.ReadOnly = true;
            this.TxBDistrict.Size = new System.Drawing.Size(402, 20);
            this.TxBDistrict.TabIndex = 8;
            this.TxBDistrict.TabStop = false;
            // 
            // TxBIdDistrict
            // 
            this.TxBIdDistrict.Location = new System.Drawing.Point(92, 26);
            this.TxBIdDistrict.Name = "TxBIdDistrict";
            this.TxBIdDistrict.Size = new System.Drawing.Size(80, 20);
            this.TxBIdDistrict.TabIndex = 6;
            this.TxBIdDistrict.Tag = "";
            // 
            // LblDistrict
            // 
            this.LblDistrict.AutoSize = true;
            this.LblDistrict.Location = new System.Drawing.Point(40, 30);
            this.LblDistrict.Name = "LblDistrict";
            this.LblDistrict.Size = new System.Drawing.Size(51, 13);
            this.LblDistrict.TabIndex = 5;
            this.LblDistrict.Text = "District:";
            // 
            // TxBComplement
            // 
            this.TxBComplement.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBComplement.Location = new System.Drawing.Point(92, 189);
            this.TxBComplement.Name = "TxBComplement";
            this.TxBComplement.Size = new System.Drawing.Size(507, 20);
            this.TxBComplement.TabIndex = 39;
            this.TxBComplement.Tag = "";
            // 
            // LblComplement
            // 
            this.LblComplement.AutoSize = true;
            this.LblComplement.Location = new System.Drawing.Point(12, 193);
            this.LblComplement.Name = "LblComplement";
            this.LblComplement.Size = new System.Drawing.Size(79, 13);
            this.LblComplement.TabIndex = 38;
            this.LblComplement.Text = "Complement:";
            // 
            // TxBNumber
            // 
            this.TxBNumber.Location = new System.Drawing.Point(519, 166);
            this.TxBNumber.Name = "TxBNumber";
            this.TxBNumber.Size = new System.Drawing.Size(80, 20);
            this.TxBNumber.TabIndex = 37;
            this.TxBNumber.Tag = "";
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Location = new System.Drawing.Point(467, 170);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(54, 13);
            this.LblNumber.TabIndex = 36;
            this.LblNumber.Text = "Number:";
            // 
            // TxBAddress
            // 
            this.TxBAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBAddress.Location = new System.Drawing.Point(197, 166);
            this.TxBAddress.Name = "TxBAddress";
            this.TxBAddress.ReadOnly = true;
            this.TxBAddress.Size = new System.Drawing.Size(262, 20);
            this.TxBAddress.TabIndex = 35;
            this.TxBAddress.TabStop = false;
            // 
            // TxBIdAddress
            // 
            this.TxBIdAddress.Location = new System.Drawing.Point(92, 166);
            this.TxBIdAddress.Name = "TxBIdAddress";
            this.TxBIdAddress.Size = new System.Drawing.Size(80, 20);
            this.TxBIdAddress.TabIndex = 33;
            this.TxBIdAddress.Tag = "";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(35, 170);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(56, 13);
            this.LblAddress.TabIndex = 32;
            this.LblAddress.Text = "Address:";
            // 
            // TxBNeighborhood
            // 
            this.TxBNeighborhood.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBNeighborhood.Location = new System.Drawing.Point(197, 143);
            this.TxBNeighborhood.Name = "TxBNeighborhood";
            this.TxBNeighborhood.ReadOnly = true;
            this.TxBNeighborhood.Size = new System.Drawing.Size(402, 20);
            this.TxBNeighborhood.TabIndex = 31;
            this.TxBNeighborhood.TabStop = false;
            // 
            // TxBIdNeighborhood
            // 
            this.TxBIdNeighborhood.Location = new System.Drawing.Point(92, 143);
            this.TxBIdNeighborhood.Name = "TxBIdNeighborhood";
            this.TxBIdNeighborhood.Size = new System.Drawing.Size(80, 20);
            this.TxBIdNeighborhood.TabIndex = 29;
            this.TxBIdNeighborhood.Tag = "";
            // 
            // LblNeighborhood
            // 
            this.LblNeighborhood.AutoSize = true;
            this.LblNeighborhood.Location = new System.Drawing.Point(1, 147);
            this.LblNeighborhood.Name = "LblNeighborhood";
            this.LblNeighborhood.Size = new System.Drawing.Size(90, 13);
            this.LblNeighborhood.TabIndex = 28;
            this.LblNeighborhood.Text = "Neighborhood:";
            // 
            // LblPostalArea
            // 
            this.LblPostalArea.AutoSize = true;
            this.LblPostalArea.Location = new System.Drawing.Point(476, 123);
            this.LblPostalArea.Name = "LblPostalArea";
            this.LblPostalArea.Size = new System.Drawing.Size(46, 13);
            this.LblPostalArea.TabIndex = 26;
            this.LblPostalArea.Text = "Postal:";
            // 
            // TxBIdPerson
            // 
            this.TxBIdPerson.Location = new System.Drawing.Point(92, 4);
            this.TxBIdPerson.Name = "TxBIdPerson";
            this.TxBIdPerson.Size = new System.Drawing.Size(80, 20);
            this.TxBIdPerson.TabIndex = 2;
            this.TxBIdPerson.Tag = "";
            // 
            // TxBPerson
            // 
            this.TxBPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBPerson.Location = new System.Drawing.Point(197, 4);
            this.TxBPerson.Name = "TxBPerson";
            this.TxBPerson.ReadOnly = true;
            this.TxBPerson.Size = new System.Drawing.Size(402, 20);
            this.TxBPerson.TabIndex = 4;
            this.TxBPerson.TabStop = false;
            this.TxBPerson.Tag = "";
            // 
            // LblPerson
            // 
            this.LblPerson.AutoSize = true;
            this.LblPerson.Location = new System.Drawing.Point(41, 8);
            this.LblPerson.Name = "LblPerson";
            this.LblPerson.Size = new System.Drawing.Size(50, 13);
            this.LblPerson.TabIndex = 1;
            this.LblPerson.Text = "Person:";
            // 
            // PersonsF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 271);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonsF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonF_FormClosing);
            this.Shown += new System.EventHandler(this.PersonF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PersonF_KeyDown);
            this.PnlPanel1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.PnlPanel2.ResumeLayout(false);
            this.PnlPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnReportPersonsMenu;
        private System.Windows.Forms.Button BtnIUD;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem databaseNeighborhoodsMenu2;
        public System.Windows.Forms.ToolStripMenuItem databaseAddressesMenu2;
        public System.Windows.Forms.ToolStripMenuItem databaseDistrictsMenu2;
        public System.Windows.Forms.ToolStripMenuItem databaseCitiesMenu2;
        private System.Windows.Forms.ToolStripMenuItem databasePersonsMenu2;
        private System.Windows.Forms.Panel PnlPanel2;
        private System.Windows.Forms.Button BtnIdPerson;
        private System.Windows.Forms.TextBox TxBContinent;
        private System.Windows.Forms.TextBox TxBIdContinent;
        private System.Windows.Forms.Label LblContinent;
        private System.Windows.Forms.TextBox TxBCountryInitial;
        private System.Windows.Forms.Label LblCountryInitial;
        private System.Windows.Forms.TextBox TxBCountry;
        private System.Windows.Forms.TextBox TxBIdCountry;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.TextBox TxBStateInitial;
        private System.Windows.Forms.Label LblStateInitial;
        private System.Windows.Forms.TextBox TxBState;
        private System.Windows.Forms.TextBox TxBIdState;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.MaskedTextBox MkBPostalArea;
        private System.Windows.Forms.TextBox TxBCity;
        private System.Windows.Forms.Button BtnIdCity;
        private System.Windows.Forms.TextBox TxBIdCity;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.TextBox TxBDistrict;
        private System.Windows.Forms.Button BtnIdDistrict;
        private System.Windows.Forms.TextBox TxBIdDistrict;
        private System.Windows.Forms.Label LblDistrict;
        public System.Windows.Forms.TextBox TxBComplement;
        public System.Windows.Forms.Label LblComplement;
        private System.Windows.Forms.TextBox TxBNumber;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.TextBox TxBAddress;
        private System.Windows.Forms.Button BtnIdAddress;
        private System.Windows.Forms.TextBox TxBIdAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxBNeighborhood;
        private System.Windows.Forms.Button BtnIdNeighborhood;
        private System.Windows.Forms.TextBox TxBIdNeighborhood;
        private System.Windows.Forms.Label LblNeighborhood;
        private System.Windows.Forms.Label LblPostalArea;
        public System.Windows.Forms.TextBox TxBIdPerson;
        public System.Windows.Forms.TextBox TxBPerson;
        public System.Windows.Forms.Label LblPerson;


    }
}

