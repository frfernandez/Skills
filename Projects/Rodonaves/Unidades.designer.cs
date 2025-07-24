namespace Identification
{
    partial class UnidadesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadesF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnIUD = new System.Windows.Forms.Button();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.CkBAtiva = new System.Windows.Forms.CheckBox();
            this.TxBCodigo = new System.Windows.Forms.TextBox();
            this.TxBUnidade = new System.Windows.Forms.TextBox();
            this.LblUnidade = new System.Windows.Forms.Label();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseDocumentsTypesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnFilter);
            this.PnlPanel1.Controls.Add(this.BtnExit);
            this.PnlPanel1.Controls.Add(this.BtnCancel);
            this.PnlPanel1.Controls.Add(this.BtnIUD);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(527, 54);
            this.PnlPanel1.TabIndex = 0;
            // 
            // BtnFilter
            // 
            this.BtnFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BtnIUD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.PnlPanel2.Controls.Add(this.CkBAtiva);
            this.PnlPanel2.Controls.Add(this.TxBCodigo);
            this.PnlPanel2.Controls.Add(this.TxBUnidade);
            this.PnlPanel2.Controls.Add(this.LblUnidade);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(527, 44);
            this.PnlPanel2.TabIndex = 1;
            // 
            // CkBAtiva
            // 
            this.CkBAtiva.AutoSize = true;
            this.CkBAtiva.Location = new System.Drawing.Point(472, 22);
            this.CkBAtiva.Name = "CkBAtiva";
            this.CkBAtiva.Size = new System.Drawing.Size(55, 17);
            this.CkBAtiva.TabIndex = 4;
            this.CkBAtiva.Tag = "Y;N";
            this.CkBAtiva.Text = "Ativa";
            this.CkBAtiva.UseVisualStyleBackColor = true;
            // 
            // TxBCodigo
            // 
            this.TxBCodigo.Location = new System.Drawing.Point(8, 20);
            this.TxBCodigo.Name = "TxBCodigo";
            this.TxBCodigo.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigo.TabIndex = 1;
            this.TxBCodigo.Visible = false;
            // 
            // TxBUnidade
            // 
            this.TxBUnidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBUnidade.Location = new System.Drawing.Point(8, 20);
            this.TxBUnidade.Name = "TxBUnidade";
            this.TxBUnidade.Size = new System.Drawing.Size(458, 20);
            this.TxBUnidade.TabIndex = 0;
            // 
            // LblUnidade
            // 
            this.LblUnidade.AutoSize = true;
            this.LblUnidade.Location = new System.Drawing.Point(8, 4);
            this.LblUnidade.Name = "LblUnidade";
            this.LblUnidade.Size = new System.Drawing.Size(58, 13);
            this.LblUnidade.TabIndex = 0;
            this.LblUnidade.Text = "Unidade:";
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
            this.Images.Images.SetKeyName(10, "ReportDocumentsMenu-");
            this.Images.Images.SetKeyName(11, "ReportDocumentsMenu+");
            this.Images.Images.SetKeyName(12, "Exit-");
            this.Images.Images.SetKeyName(13, "Exit+");
            this.Images.Images.SetKeyName(14, "IdDocumentType-");
            this.Images.Images.SetKeyName(15, "IdDocumentType+");
            this.Images.Images.SetKeyName(16, "IdVerifier-");
            this.Images.Images.SetKeyName(17, "IdVerifier+");
            this.Images.Images.SetKeyName(18, "DocumentsTypesMenu-");
            this.Images.Images.SetKeyName(19, "DocumentsTypesMenu+");
            this.Images.Images.SetKeyName(20, "Navigator-");
            this.Images.Images.SetKeyName(21, "Navigator+");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseDocumentsTypesMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(169, 26);
            // 
            // databaseDocumentsTypesMenu2
            // 
            this.databaseDocumentsTypesMenu2.Name = "databaseDocumentsTypesMenu2";
            this.databaseDocumentsTypesMenu2.Size = new System.Drawing.Size(168, 22);
            this.databaseDocumentsTypesMenu2.Tag = "TxBIdDocumentType";
            this.databaseDocumentsTypesMenu2.Text = "Documents Types";
            // 
            // UnidadesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 98);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnidadesF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Unidades_FormClosing);
            this.Shown += new System.EventHandler(this.UnidadesF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnidadesF_KeyDown);
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
        public System.Windows.Forms.Label LblUnidade;
        private System.Windows.Forms.Button BtnIUD;
        private System.Windows.Forms.Panel PnlPanel2;
        public System.Windows.Forms.TextBox TxBUnidade;
        public System.Windows.Forms.TextBox TxBCodigo;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.CheckBox CkBAtiva;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem databaseDocumentsTypesMenu2;


    }
}

