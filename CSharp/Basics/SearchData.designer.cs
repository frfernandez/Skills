namespace Basics
{
    partial class SearchDataF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDataF));
            this.PnlPainel1 = new System.Windows.Forms.Panel();
            this.GBxCadastro = new System.Windows.Forms.GroupBox();
            this.RBtExcluir = new System.Windows.Forms.RadioButton();
            this.RBtAlterar = new System.Windows.Forms.RadioButton();
            this.BtnRelatorio = new System.Windows.Forms.Button();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.BtnEscreve = new System.Windows.Forms.Button();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.PnlPainel2 = new System.Windows.Forms.Panel();
            this.TxBDescricao = new System.Windows.Forms.TextBox();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.PnlPainel3 = new System.Windows.Forms.Panel();
            this.DGVSearch = new System.Windows.Forms.DataGridView();
            this.TTpDica = new System.Windows.Forms.ToolTip(this.components);
            this.Imagens = new System.Windows.Forms.ImageList(this.components);
            this.PnlPainel1.SuspendLayout();
            this.GBxCadastro.SuspendLayout();
            this.PnlPainel2.SuspendLayout();
            this.PnlPainel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPainel1
            // 
            this.PnlPainel1.Controls.Add(this.GBxCadastro);
            this.PnlPainel1.Controls.Add(this.BtnRelatorio);
            this.PnlPainel1.Controls.Add(this.BtnSaida);
            this.PnlPainel1.Controls.Add(this.BtnEscreve);
            this.PnlPainel1.Controls.Add(this.BtnFiltro);
            this.PnlPainel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPainel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPainel1.Name = "PnlPainel1";
            this.PnlPainel1.Size = new System.Drawing.Size(621, 54);
            this.PnlPainel1.TabIndex = 0;
            // 
            // GBxCadastro
            // 
            this.GBxCadastro.Controls.Add(this.RBtExcluir);
            this.GBxCadastro.Controls.Add(this.RBtAlterar);
            this.GBxCadastro.Dock = System.Windows.Forms.DockStyle.Right;
            this.GBxCadastro.Location = new System.Drawing.Point(534, 0);
            this.GBxCadastro.Name = "GBxCadastro";
            this.GBxCadastro.Size = new System.Drawing.Size(87, 54);
            this.GBxCadastro.TabIndex = 4;
            this.GBxCadastro.TabStop = false;
            this.GBxCadastro.Text = "Cadastro";
            this.TTpDica.SetToolTip(this.GBxCadastro, "Define o que será feito com o registro");
            this.GBxCadastro.Visible = false;
            // 
            // RBtExcluir
            // 
            this.RBtExcluir.AutoSize = true;
            this.RBtExcluir.Location = new System.Drawing.Point(6, 34);
            this.RBtExcluir.Name = "RBtExcluir";
            this.RBtExcluir.Size = new System.Drawing.Size(63, 17);
            this.RBtExcluir.TabIndex = 1;
            this.RBtExcluir.TabStop = true;
            this.RBtExcluir.Text = "E&xcluir";
            this.TTpDica.SetToolTip(this.RBtExcluir, "Apresenta o botão que permite excluir o registro");
            this.RBtExcluir.UseVisualStyleBackColor = true;
            // 
            // RBtAlterar
            // 
            this.RBtAlterar.AutoSize = true;
            this.RBtAlterar.Checked = true;
            this.RBtAlterar.Location = new System.Drawing.Point(6, 13);
            this.RBtAlterar.Name = "RBtAlterar";
            this.RBtAlterar.Size = new System.Drawing.Size(62, 17);
            this.RBtAlterar.TabIndex = 0;
            this.RBtAlterar.TabStop = true;
            this.RBtAlterar.Text = "&Alterar";
            this.TTpDica.SetToolTip(this.RBtAlterar, "Apresenta o botão que permite alterar o registro");
            this.RBtAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.Location = new System.Drawing.Point(282, 3);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(93, 50);
            this.BtnRelatorio.TabIndex = 3;
            this.BtnRelatorio.TabStop = false;
            this.BtnRelatorio.Text = "&Relatório";
            this.TTpDica.SetToolTip(this.BtnRelatorio, "Relatório dos registros cadastrados");
            this.BtnRelatorio.UseVisualStyleBackColor = true;
            // 
            // BtnSaida
            // 
            this.BtnSaida.Location = new System.Drawing.Point(189, 3);
            this.BtnSaida.Name = "BtnSaida";
            this.BtnSaida.Size = new System.Drawing.Size(93, 50);
            this.BtnSaida.TabIndex = 2;
            this.BtnSaida.TabStop = false;
            this.BtnSaida.Text = "&Saída";
            this.TTpDica.SetToolTip(this.BtnSaida, "Retorna à tela anterior");
            this.BtnSaida.UseVisualStyleBackColor = true;
            this.BtnSaida.Click += new System.EventHandler(this.BtnSaida_Click);
            // 
            // BtnEscreve
            // 
            this.BtnEscreve.Location = new System.Drawing.Point(96, 3);
            this.BtnEscreve.Name = "BtnEscreve";
            this.BtnEscreve.Size = new System.Drawing.Size(93, 50);
            this.BtnEscreve.TabIndex = 1;
            this.BtnEscreve.TabStop = false;
            this.BtnEscreve.Text = "&Escreve";
            this.TTpDica.SetToolTip(this.BtnEscreve, "Preenche o campo com o registro selecionado");
            this.BtnEscreve.UseVisualStyleBackColor = true;
            this.BtnEscreve.Click += new System.EventHandler(this.BtnEscreve_Click);
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Location = new System.Drawing.Point(3, 3);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(93, 50);
            this.BtnFiltro.TabIndex = 0;
            this.BtnFiltro.TabStop = false;
            this.BtnFiltro.Text = "&Filtro";
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // PnlPainel2
            // 
            this.PnlPainel2.Controls.Add(this.TxBDescricao);
            this.PnlPainel2.Controls.Add(this.LblDescricao);
            this.PnlPainel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPainel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPainel2.Name = "PnlPainel2";
            this.PnlPainel2.Size = new System.Drawing.Size(621, 44);
            this.PnlPainel2.TabIndex = 1;
            // 
            // TxBDescricao
            // 
            this.TxBDescricao.BackColor = System.Drawing.SystemColors.Window;
            this.TxBDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBDescricao.Location = new System.Drawing.Point(8, 19);
            this.TxBDescricao.Name = "TxBDescricao";
            this.TxBDescricao.Size = new System.Drawing.Size(606, 20);
            this.TxBDescricao.TabIndex = 0;
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(8, 4);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(43, 13);
            this.LblDescricao.TabIndex = 0;
            this.LblDescricao.Text = "Nome:";
            // 
            // PnlPainel3
            // 
            this.PnlPainel3.Controls.Add(this.DGVSearch);
            this.PnlPainel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPainel3.Location = new System.Drawing.Point(0, 98);
            this.PnlPainel3.Name = "PnlPainel3";
            this.PnlPainel3.Size = new System.Drawing.Size(621, 241);
            this.PnlPainel3.TabIndex = 2;
            // 
            // DGVSearch
            // 
            this.DGVSearch.AllowUserToAddRows = false;
            this.DGVSearch.AllowUserToDeleteRows = false;
            this.DGVSearch.AllowUserToResizeColumns = false;
            this.DGVSearch.AllowUserToResizeRows = false;
            this.DGVSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSearch.Location = new System.Drawing.Point(0, 0);
            this.DGVSearch.MultiSelect = false;
            this.DGVSearch.Name = "DGVSearch";
            this.DGVSearch.ReadOnly = true;
            this.DGVSearch.RowHeadersWidth = 25;
            this.DGVSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVSearch.Size = new System.Drawing.Size(621, 241);
            this.DGVSearch.TabIndex = 0;
            this.DGVSearch.Click += new System.EventHandler(this.DGVSearch_Click);
            this.DGVSearch.DoubleClick += new System.EventHandler(this.DGVSearch_DoubleClick);
            this.DGVSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGVSearch_KeyUp);
            // 
            // Imagens
            // 
            this.Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagens.ImageStream")));
            this.Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagens.Images.SetKeyName(0, "Filtro-");
            this.Imagens.Images.SetKeyName(1, "Filtro+");
            this.Imagens.Images.SetKeyName(2, "Escreve-");
            this.Imagens.Images.SetKeyName(3, "Escreve+");
            this.Imagens.Images.SetKeyName(4, "Relatorio-");
            this.Imagens.Images.SetKeyName(5, "Relatorio+");
            this.Imagens.Images.SetKeyName(6, "Saida-");
            this.Imagens.Images.SetKeyName(7, "Saida+");
            // 
            // SearchDataF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 339);
            this.Controls.Add(this.PnlPainel3);
            this.Controls.Add(this.PnlPainel2);
            this.Controls.Add(this.PnlPainel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchDataF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchDataF_FormClosing);
            this.Shown += new System.EventHandler(this.SearchF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchF_KeyDown);
            this.PnlPainel1.ResumeLayout(false);
            this.GBxCadastro.ResumeLayout(false);
            this.GBxCadastro.PerformLayout();
            this.PnlPainel2.ResumeLayout(false);
            this.PnlPainel2.PerformLayout();
            this.PnlPainel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPainel1;
        private System.Windows.Forms.Panel PnlPainel2;
        private System.Windows.Forms.Panel PnlPainel3;
        private System.Windows.Forms.Button BtnSaida;
        private System.Windows.Forms.Button BtnEscreve;
        private System.Windows.Forms.DataGridView DGVSearch;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.Button BtnRelatorio;
        public System.Windows.Forms.Label LblDescricao;
        public System.Windows.Forms.RadioButton RBtExcluir;
        public System.Windows.Forms.RadioButton RBtAlterar;
        public System.Windows.Forms.TextBox TxBDescricao;
        public System.Windows.Forms.GroupBox GBxCadastro;
        private System.Windows.Forms.ToolTip TTpDica;
        private System.Windows.Forms.ImageList Imagens;


    }
}