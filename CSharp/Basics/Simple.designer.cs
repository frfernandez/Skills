namespace Basics
{
    partial class SimpleF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleF));
            this.PnlPainel1 = new System.Windows.Forms.Panel();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnIAE = new System.Windows.Forms.Button();
            this.PnlPainel2 = new System.Windows.Forms.Panel();
            this.TxBCodigo = new System.Windows.Forms.TextBox();
            this.TxBDescricao = new System.Windows.Forms.TextBox();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.TTpDica = new System.Windows.Forms.ToolTip(this.components);
            this.Imagens = new System.Windows.Forms.ImageList(this.components);
            this.PnlPainel1.SuspendLayout();
            this.PnlPainel2.SuspendLayout();
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
            this.PnlPainel1.Size = new System.Drawing.Size(621, 55);
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
            this.PnlPainel2.Controls.Add(this.TxBCodigo);
            this.PnlPainel2.Controls.Add(this.TxBDescricao);
            this.PnlPainel2.Controls.Add(this.LblDescricao);
            this.PnlPainel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPainel2.Location = new System.Drawing.Point(0, 55);
            this.PnlPainel2.Name = "PnlPainel2";
            this.PnlPainel2.Size = new System.Drawing.Size(621, 47);
            this.PnlPainel2.TabIndex = 1;
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
            // TxBDescricao
            // 
            this.TxBDescricao.Location = new System.Drawing.Point(8, 20);
            this.TxBDescricao.Name = "TxBDescricao";
            this.TxBDescricao.Size = new System.Drawing.Size(606, 20);
            this.TxBDescricao.TabIndex = 0;
            this.TxBDescricao.Tag = "";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(8, 4);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(68, 13);
            this.LblDescricao.TabIndex = 0;
            this.LblDescricao.Text = "Descrição:";
            // 
            // Imagens
            // 
            this.Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Imagens.ImageStream")));
            this.Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.Imagens.Images.SetKeyName(0, "Altera-");
            this.Imagens.Images.SetKeyName(1, "Altera+");
            this.Imagens.Images.SetKeyName(2, "Cancela-");
            this.Imagens.Images.SetKeyName(3, "Cancela+");
            this.Imagens.Images.SetKeyName(4, "Exclui-");
            this.Imagens.Images.SetKeyName(5, "Exclui+");
            this.Imagens.Images.SetKeyName(6, "Filtro-");
            this.Imagens.Images.SetKeyName(7, "Filtro+");
            this.Imagens.Images.SetKeyName(8, "Inclui-");
            this.Imagens.Images.SetKeyName(9, "Inclui+");
            this.Imagens.Images.SetKeyName(10, "Relatorio-");
            this.Imagens.Images.SetKeyName(11, "Relatorio+");
            this.Imagens.Images.SetKeyName(12, "Saida-");
            this.Imagens.Images.SetKeyName(13, "Saida+");
            // 
            // SimpleF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 102);
            this.Controls.Add(this.PnlPainel2);
            this.Controls.Add(this.PnlPainel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple";
            this.Shown += new System.EventHandler(this.SimpleF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SimpleF_KeyDown);
            this.PnlPainel1.ResumeLayout(false);
            this.PnlPainel2.ResumeLayout(false);
            this.PnlPainel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPainel1;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.Button BtnSaida;
        private System.Windows.Forms.Button BtnCancela;
        public System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Button BtnIAE;
        private System.Windows.Forms.Panel PnlPainel2;
        public System.Windows.Forms.TextBox TxBDescricao;
        public System.Windows.Forms.TextBox TxBCodigo;
        private System.Windows.Forms.ToolTip TTpDica;
        private System.Windows.Forms.ImageList Imagens;


    }
}

