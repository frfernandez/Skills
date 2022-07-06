namespace Map
{
    partial class PaisesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaisesF));
            this.PnlPainel1 = new System.Windows.Forms.Panel();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnIAE = new System.Windows.Forms.Button();
            this.PnlPainel2 = new System.Windows.Forms.Panel();
            this.TxBContinente = new System.Windows.Forms.TextBox();
            this.BtnCodigoContinente = new System.Windows.Forms.Button();
            this.TxBCodigoContinente = new System.Windows.Forms.TextBox();
            this.LblContinente = new System.Windows.Forms.Label();
            this.TxBSigla = new System.Windows.Forms.TextBox();
            this.LblSigla = new System.Windows.Forms.Label();
            this.TxBCodigo = new System.Windows.Forms.TextBox();
            this.TxBPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.TTpDica = new System.Windows.Forms.ToolTip(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.continentesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlPainel1.SuspendLayout();
            this.PnlPainel2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPainel1
            // 
            this.PnlPainel1.Controls.Add(this.BtnFiltro);
            this.PnlPainel1.Controls.Add(this.BtnSaida);
            this.PnlPainel1.Controls.Add(this.BtnCancela);
            this.PnlPainel1.Controls.Add(this.BtnIAE);
            this.PnlPainel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPainel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPainel1.Name = "PnlPainel1";
            this.PnlPainel1.Size = new System.Drawing.Size(621, 54);
            this.PnlPainel1.TabIndex = 0;
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Location = new System.Drawing.Point(281, 2);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(93, 50);
            this.BtnFiltro.TabIndex = 3;
            this.BtnFiltro.TabStop = false;
            this.BtnFiltro.Text = "&Filtro";
            this.TTpDica.SetToolTip(this.BtnFiltro, "Seleciona um registro");
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // BtnSaida
            // 
            this.BtnSaida.Location = new System.Drawing.Point(188, 2);
            this.BtnSaida.Name = "BtnSaida";
            this.BtnSaida.Size = new System.Drawing.Size(93, 50);
            this.BtnSaida.TabIndex = 2;
            this.BtnSaida.TabStop = false;
            this.BtnSaida.Text = "&Saída";
            this.TTpDica.SetToolTip(this.BtnSaida, "Retorna à tela anterior");
            this.BtnSaida.UseVisualStyleBackColor = true;
            this.BtnSaida.Click += new System.EventHandler(this.BtnSaida_Click);
            // 
            // BtnCancela
            // 
            this.BtnCancela.Location = new System.Drawing.Point(95, 2);
            this.BtnCancela.Name = "BtnCancela";
            this.BtnCancela.Size = new System.Drawing.Size(93, 50);
            this.BtnCancela.TabIndex = 1;
            this.BtnCancela.TabStop = false;
            this.BtnCancela.Text = "&Cancela";
            this.TTpDica.SetToolTip(this.BtnCancela, "Cancela a ação");
            this.BtnCancela.UseVisualStyleBackColor = true;
            this.BtnCancela.Click += new System.EventHandler(this.BtnCancela_Click);
            // 
            // BtnIAE
            // 
            this.BtnIAE.Location = new System.Drawing.Point(2, 2);
            this.BtnIAE.Name = "BtnIAE";
            this.BtnIAE.Size = new System.Drawing.Size(93, 50);
            this.BtnIAE.TabIndex = 0;
            this.BtnIAE.TabStop = false;
            this.BtnIAE.Text = "&Inclui";
            this.TTpDica.SetToolTip(this.BtnIAE, "Executa a ação");
            this.BtnIAE.UseVisualStyleBackColor = true;
            this.BtnIAE.Click += new System.EventHandler(this.BtnIAE_Click);
            // 
            // PnlPainel2
            // 
            this.PnlPainel2.Controls.Add(this.TxBContinente);
            this.PnlPainel2.Controls.Add(this.BtnCodigoContinente);
            this.PnlPainel2.Controls.Add(this.TxBCodigoContinente);
            this.PnlPainel2.Controls.Add(this.LblContinente);
            this.PnlPainel2.Controls.Add(this.TxBSigla);
            this.PnlPainel2.Controls.Add(this.LblSigla);
            this.PnlPainel2.Controls.Add(this.TxBCodigo);
            this.PnlPainel2.Controls.Add(this.TxBPais);
            this.PnlPainel2.Controls.Add(this.LblPais);
            this.PnlPainel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPainel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPainel2.Name = "PnlPainel2";
            this.PnlPainel2.Size = new System.Drawing.Size(621, 124);
            this.PnlPainel2.TabIndex = 1;
            // 
            // TxBContinente
            // 
            this.TxBContinente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBContinente.Location = new System.Drawing.Point(112, 99);
            this.TxBContinente.Name = "TxBContinente";
            this.TxBContinente.ReadOnly = true;
            this.TxBContinente.Size = new System.Drawing.Size(502, 20);
            this.TxBContinente.TabIndex = 7;
            this.TxBContinente.TabStop = false;
            // 
            // BtnCodigoContinente
            // 
            this.BtnCodigoContinente.Location = new System.Drawing.Point(89, 99);
            this.BtnCodigoContinente.Name = "BtnCodigoContinente";
            this.BtnCodigoContinente.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoContinente.TabIndex = 6;
            this.BtnCodigoContinente.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoContinente, "Lista de todos continentes cadastrados");
            this.BtnCodigoContinente.UseVisualStyleBackColor = true;
            this.BtnCodigoContinente.Click += new System.EventHandler(this.BtnCodigoContinente_Click);
            // 
            // TxBCodigoContinente
            // 
            this.TxBCodigoContinente.Location = new System.Drawing.Point(8, 99);
            this.TxBCodigoContinente.Name = "TxBCodigoContinente";
            this.TxBCodigoContinente.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoContinente.TabIndex = 5;
            this.TxBCodigoContinente.Tag = "";
            this.TxBCodigoContinente.Leave += new System.EventHandler(this.TxBCodigoContinente_Leave);
            // 
            // LblContinente
            // 
            this.LblContinente.AutoSize = true;
            this.LblContinente.Location = new System.Drawing.Point(8, 83);
            this.LblContinente.Name = "LblContinente";
            this.LblContinente.Size = new System.Drawing.Size(72, 13);
            this.LblContinente.TabIndex = 4;
            this.LblContinente.Text = "Continente:";
            // 
            // TxBSigla
            // 
            this.TxBSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBSigla.Location = new System.Drawing.Point(8, 59);
            this.TxBSigla.Name = "TxBSigla";
            this.TxBSigla.Size = new System.Drawing.Size(66, 20);
            this.TxBSigla.TabIndex = 2;
            this.TxBSigla.Tag = "";
            // 
            // LblSigla
            // 
            this.LblSigla.AutoSize = true;
            this.LblSigla.Location = new System.Drawing.Point(8, 43);
            this.LblSigla.Name = "LblSigla";
            this.LblSigla.Size = new System.Drawing.Size(39, 13);
            this.LblSigla.TabIndex = 1;
            this.LblSigla.Text = "Sigla:";
            // 
            // TxBCodigo
            // 
            this.TxBCodigo.Location = new System.Drawing.Point(8, 20);
            this.TxBCodigo.Name = "TxBCodigo";
            this.TxBCodigo.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigo.TabIndex = 0;
            this.TxBCodigo.Tag = "";
            this.TxBCodigo.Visible = false;
            // 
            // TxBPais
            // 
            this.TxBPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBPais.Location = new System.Drawing.Point(8, 20);
            this.TxBPais.Name = "TxBPais";
            this.TxBPais.Size = new System.Drawing.Size(606, 20);
            this.TxBPais.TabIndex = 0;
            this.TxBPais.Tag = "";
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Location = new System.Drawing.Point(8, 4);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(37, 13);
            this.LblPais.TabIndex = 0;
            this.LblPais.Text = "País:";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Altera-");
            this.imageList.Images.SetKeyName(1, "Altera+");
            this.imageList.Images.SetKeyName(2, "Cancela-");
            this.imageList.Images.SetKeyName(3, "Cancela+");
            this.imageList.Images.SetKeyName(4, "Exclui-");
            this.imageList.Images.SetKeyName(5, "Exclui+");
            this.imageList.Images.SetKeyName(6, "Filtro-");
            this.imageList.Images.SetKeyName(7, "Filtro+");
            this.imageList.Images.SetKeyName(8, "Inclui-");
            this.imageList.Images.SetKeyName(9, "Inclui+");
            this.imageList.Images.SetKeyName(10, "Relatorio-");
            this.imageList.Images.SetKeyName(11, "Relatorio+");
            this.imageList.Images.SetKeyName(12, "Saida-");
            this.imageList.Images.SetKeyName(13, "Saida+");
            this.imageList.Images.SetKeyName(14, "CodigoContinente-");
            this.imageList.Images.SetKeyName(15, "CodigoContinente+");
            this.imageList.Images.SetKeyName(16, "continentesMenu-");
            this.imageList.Images.SetKeyName(17, "continentesMenu+");
            this.imageList.Images.SetKeyName(18, "Navegador-");
            this.imageList.Images.SetKeyName(19, "Navegador+");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continentesMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(139, 26);
            // 
            // continentesMenu2
            // 
            this.continentesMenu2.Name = "continentesMenu2";
            this.continentesMenu2.Size = new System.Drawing.Size(138, 22);
            this.continentesMenu2.Tag = "TxBCodigoContinente";
            this.continentesMenu2.Text = "Continentes";
            this.continentesMenu2.Click += new System.EventHandler(this.continentesMenu_Click);
            // 
            // PaisesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 178);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPainel2);
            this.Controls.Add(this.PnlPainel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaisesF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Países";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaisesF_FormClosing);
            this.Shown += new System.EventHandler(this.PaisesF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaisesF_KeyDown);
            this.PnlPainel1.ResumeLayout(false);
            this.PnlPainel2.ResumeLayout(false);
            this.PnlPainel2.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPainel1;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.Button BtnSaida;
        private System.Windows.Forms.Button BtnCancela;
        public System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.Button BtnIAE;
        private System.Windows.Forms.Panel PnlPainel2;
        public System.Windows.Forms.TextBox TxBPais;
        public System.Windows.Forms.TextBox TxBCodigo;
        private System.Windows.Forms.ToolTip TTpDica;
        private System.Windows.Forms.ImageList imageList;
        public System.Windows.Forms.TextBox TxBSigla;
        public System.Windows.Forms.Label LblSigla;
        private System.Windows.Forms.TextBox TxBContinente;
        private System.Windows.Forms.Button BtnCodigoContinente;
        private System.Windows.Forms.TextBox TxBCodigoContinente;
        private System.Windows.Forms.Label LblContinente;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem continentesMenu2;


    }
}

