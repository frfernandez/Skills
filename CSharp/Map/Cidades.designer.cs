namespace Map
{
    partial class CidadesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CidadesF));
            this.PnlPainel1 = new System.Windows.Forms.Panel();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnIAE = new System.Windows.Forms.Button();
            this.PnlPainel2 = new System.Windows.Forms.Panel();
            this.TxBPais = new System.Windows.Forms.TextBox();
            this.BtnCodigoPais = new System.Windows.Forms.Button();
            this.TxBCodigoPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.TxBEstado = new System.Windows.Forms.TextBox();
            this.BtnCodigoEstado = new System.Windows.Forms.Button();
            this.TxBCodigoEstado = new System.Windows.Forms.TextBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.TxBCodigo = new System.Windows.Forms.TextBox();
            this.TxBCidade = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TTpDica = new System.Windows.Forms.ToolTip(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paisesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosMenu2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.BtnFiltro.TabIndex = 5;
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
            this.BtnSaida.TabIndex = 4;
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
            this.BtnCancela.TabIndex = 3;
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
            this.PnlPainel2.Controls.Add(this.TxBPais);
            this.PnlPainel2.Controls.Add(this.BtnCodigoPais);
            this.PnlPainel2.Controls.Add(this.TxBCodigoPais);
            this.PnlPainel2.Controls.Add(this.LblPais);
            this.PnlPainel2.Controls.Add(this.TxBEstado);
            this.PnlPainel2.Controls.Add(this.BtnCodigoEstado);
            this.PnlPainel2.Controls.Add(this.TxBCodigoEstado);
            this.PnlPainel2.Controls.Add(this.LblEstado);
            this.PnlPainel2.Controls.Add(this.TxBCodigo);
            this.PnlPainel2.Controls.Add(this.TxBCidade);
            this.PnlPainel2.Controls.Add(this.LblCidade);
            this.PnlPainel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPainel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPainel2.Name = "PnlPainel2";
            this.PnlPainel2.Size = new System.Drawing.Size(621, 125);
            this.PnlPainel2.TabIndex = 1;
            // 
            // TxBPais
            // 
            this.TxBPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBPais.Location = new System.Drawing.Point(112, 60);
            this.TxBPais.Name = "TxBPais";
            this.TxBPais.ReadOnly = true;
            this.TxBPais.Size = new System.Drawing.Size(502, 20);
            this.TxBPais.TabIndex = 4;
            this.TxBPais.TabStop = false;
            // 
            // BtnCodigoPais
            // 
            this.BtnCodigoPais.Location = new System.Drawing.Point(89, 60);
            this.BtnCodigoPais.Name = "BtnCodigoPais";
            this.BtnCodigoPais.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoPais.TabIndex = 3;
            this.BtnCodigoPais.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoPais, "Lista de todos países cadastrados");
            this.BtnCodigoPais.UseVisualStyleBackColor = true;
            this.BtnCodigoPais.Click += new System.EventHandler(this.BtnCodigoPais_Click);
            // 
            // TxBCodigoPais
            // 
            this.TxBCodigoPais.Location = new System.Drawing.Point(8, 60);
            this.TxBCodigoPais.Name = "TxBCodigoPais";
            this.TxBCodigoPais.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoPais.TabIndex = 2;
            this.TxBCodigoPais.Tag = "";
            this.TxBCodigoPais.Leave += new System.EventHandler(this.TxBCodigoPais_Leave);
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Location = new System.Drawing.Point(8, 44);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(37, 13);
            this.LblPais.TabIndex = 1;
            this.LblPais.Text = "País:";
            // 
            // TxBEstado
            // 
            this.TxBEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBEstado.Location = new System.Drawing.Point(112, 100);
            this.TxBEstado.Name = "TxBEstado";
            this.TxBEstado.ReadOnly = true;
            this.TxBEstado.Size = new System.Drawing.Size(502, 20);
            this.TxBEstado.TabIndex = 8;
            this.TxBEstado.TabStop = false;
            // 
            // BtnCodigoEstado
            // 
            this.BtnCodigoEstado.Location = new System.Drawing.Point(89, 100);
            this.BtnCodigoEstado.Name = "BtnCodigoEstado";
            this.BtnCodigoEstado.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoEstado.TabIndex = 7;
            this.BtnCodigoEstado.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoEstado, "Lista de todos estados cadastrados");
            this.BtnCodigoEstado.UseVisualStyleBackColor = true;
            this.BtnCodigoEstado.Click += new System.EventHandler(this.BtnCodigoEstado_Click);
            // 
            // TxBCodigoEstado
            // 
            this.TxBCodigoEstado.Location = new System.Drawing.Point(8, 100);
            this.TxBCodigoEstado.Name = "TxBCodigoEstado";
            this.TxBCodigoEstado.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoEstado.TabIndex = 6;
            this.TxBCodigoEstado.Tag = "";
            this.TxBCodigoEstado.Leave += new System.EventHandler(this.TxBCodigoEstado_Leave);
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(8, 84);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(50, 13);
            this.LblEstado.TabIndex = 5;
            this.LblEstado.Text = "Estado:";
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
            // TxBCidade
            // 
            this.TxBCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBCidade.Location = new System.Drawing.Point(8, 20);
            this.TxBCidade.Name = "TxBCidade";
            this.TxBCidade.Size = new System.Drawing.Size(606, 20);
            this.TxBCidade.TabIndex = 0;
            this.TxBCidade.Tag = "";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(8, 4);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(50, 13);
            this.LblCidade.TabIndex = 0;
            this.LblCidade.Text = "Cidade:";
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
            this.imageList.Images.SetKeyName(14, "CodigoEstado-");
            this.imageList.Images.SetKeyName(15, "CodigoEstado+");
            this.imageList.Images.SetKeyName(16, "CodigoPais-");
            this.imageList.Images.SetKeyName(17, "CodigoPais+");
            this.imageList.Images.SetKeyName(18, "paisesMenu-");
            this.imageList.Images.SetKeyName(19, "paisesMenu+");
            this.imageList.Images.SetKeyName(20, "estadosMenu-");
            this.imageList.Images.SetKeyName(21, "estadosMenu+");
            this.imageList.Images.SetKeyName(22, "Navegador-");
            this.imageList.Images.SetKeyName(23, "Navegador+");
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paisesMenu2,
            this.estadosMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(115, 48);
            // 
            // paisesMenu2
            // 
            this.paisesMenu2.Name = "paisesMenu2";
            this.paisesMenu2.Size = new System.Drawing.Size(114, 22);
            this.paisesMenu2.Tag = "TxBCodigoPais";
            this.paisesMenu2.Text = "Países";
            this.paisesMenu2.Click += new System.EventHandler(this.paisesMenu_Click);
            // 
            // estadosMenu2
            // 
            this.estadosMenu2.Name = "estadosMenu2";
            this.estadosMenu2.Size = new System.Drawing.Size(114, 22);
            this.estadosMenu2.Tag = "TxBCodigoEstado";
            this.estadosMenu2.Text = "Estados";
            this.estadosMenu2.Click += new System.EventHandler(this.estadosMenu_Click);
            // 
            // CidadesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 179);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPainel2);
            this.Controls.Add(this.PnlPainel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CidadesF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CidadesF_FormClosing);
            this.Shown += new System.EventHandler(this.CidadesF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CidadesF_KeyDown);
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
        public System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Button BtnIAE;
        private System.Windows.Forms.Panel PnlPainel2;
        public System.Windows.Forms.TextBox TxBCidade;
        public System.Windows.Forms.TextBox TxBCodigo;
        private System.Windows.Forms.ToolTip TTpDica;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox TxBEstado;
        private System.Windows.Forms.Button BtnCodigoEstado;
        private System.Windows.Forms.TextBox TxBCodigoEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.TextBox TxBPais;
        private System.Windows.Forms.Button BtnCodigoPais;
        private System.Windows.Forms.TextBox TxBCodigoPais;
        private System.Windows.Forms.Label LblPais;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem estadosMenu2;
        public System.Windows.Forms.ToolStripMenuItem paisesMenu2;


    }
}

