namespace People
{
    partial class PessoasF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PessoasF));
            this.PnlPainel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pessoasMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.titulosEnderecosMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.enderecosMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bairrosMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSaida = new System.Windows.Forms.Button();
            this.BtnCancela = new System.Windows.Forms.Button();
            this.BtnIAE = new System.Windows.Forms.Button();
            this.TTpDica = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCodigoPessoa = new System.Windows.Forms.Button();
            this.BtnCodigoCidade = new System.Windows.Forms.Button();
            this.BtnCodigoBairro = new System.Windows.Forms.Button();
            this.BtnCodigoEndereco = new System.Windows.Forms.Button();
            this.BtnCodigoTitulo = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.PnlPainel2 = new System.Windows.Forms.Panel();
            this.TxBContinente = new System.Windows.Forms.TextBox();
            this.TxBCodigoContinente = new System.Windows.Forms.TextBox();
            this.LblContinente = new System.Windows.Forms.Label();
            this.TxBPaisSigla = new System.Windows.Forms.TextBox();
            this.LblPaisSigla = new System.Windows.Forms.Label();
            this.TxBPais = new System.Windows.Forms.TextBox();
            this.TxBCodigoPais = new System.Windows.Forms.TextBox();
            this.LblPais = new System.Windows.Forms.Label();
            this.TxBEstadoSigla = new System.Windows.Forms.TextBox();
            this.LblEstadoSigla = new System.Windows.Forms.Label();
            this.TxBEstado = new System.Windows.Forms.TextBox();
            this.TxBCodigoEstado = new System.Windows.Forms.TextBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.MkBCEP = new System.Windows.Forms.MaskedTextBox();
            this.TxBCidade = new System.Windows.Forms.TextBox();
            this.TxBCodigoCidade = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxBBairro = new System.Windows.Forms.TextBox();
            this.TxBCodigoBairro = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxBComplemento = new System.Windows.Forms.TextBox();
            this.LblComplemento = new System.Windows.Forms.Label();
            this.TxBNumeroResidencia = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxBEndereco = new System.Windows.Forms.TextBox();
            this.TxBCodigoEndereco = new System.Windows.Forms.TextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.TxBTitulo = new System.Windows.Forms.TextBox();
            this.TxBCodigoTitulo = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblCEP = new System.Windows.Forms.Label();
            this.TxBCodigoPessoa = new System.Windows.Forms.TextBox();
            this.TxBPessoa = new System.Windows.Forms.TextBox();
            this.LblPessoa = new System.Windows.Forms.Label();
            this.PnlPainel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.PnlPainel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPainel1
            // 
            this.PnlPainel1.ContextMenuStrip = this.contextMenuStrip;
            this.PnlPainel1.Controls.Add(this.BtnSaida);
            this.PnlPainel1.Controls.Add(this.BtnCancela);
            this.PnlPainel1.Controls.Add(this.BtnIAE);
            this.PnlPainel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPainel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPainel1.Name = "PnlPainel1";
            this.PnlPainel1.Size = new System.Drawing.Size(624, 54);
            this.PnlPainel1.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasMenu2,
            this.titulosEnderecosMenu2,
            this.enderecosMenu2,
            this.bairrosMenu2,
            this.cidadesMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(183, 136);
            // 
            // pessoasMenu2
            // 
            this.pessoasMenu2.Name = "pessoasMenu2";
            this.pessoasMenu2.Size = new System.Drawing.Size(182, 22);
            this.pessoasMenu2.Tag = "TxBCodigoPessoa";
            this.pessoasMenu2.Text = "Pessoas";
            this.pessoasMenu2.Click += new System.EventHandler(this.pessoasMenu2_Click);
            // 
            // titulosEnderecosMenu2
            // 
            this.titulosEnderecosMenu2.Name = "titulosEnderecosMenu2";
            this.titulosEnderecosMenu2.Size = new System.Drawing.Size(182, 22);
            this.titulosEnderecosMenu2.Tag = "TxBCodigoTitulo";
            this.titulosEnderecosMenu2.Text = "Títulos de Endereços";
            this.titulosEnderecosMenu2.Click += new System.EventHandler(this.titulosEnderecosMenu2_Click);
            // 
            // enderecosMenu2
            // 
            this.enderecosMenu2.Name = "enderecosMenu2";
            this.enderecosMenu2.Size = new System.Drawing.Size(182, 22);
            this.enderecosMenu2.Tag = "TxBCodigoEndereco";
            this.enderecosMenu2.Text = "Endereços";
            this.enderecosMenu2.Click += new System.EventHandler(this.enderecosMenu2_Click);
            // 
            // bairrosMenu2
            // 
            this.bairrosMenu2.Name = "bairrosMenu2";
            this.bairrosMenu2.Size = new System.Drawing.Size(182, 22);
            this.bairrosMenu2.Tag = "TxBCodigoBairro";
            this.bairrosMenu2.Text = "Bairros";
            this.bairrosMenu2.Click += new System.EventHandler(this.bairrosMenu2_Click);
            // 
            // cidadesMenu2
            // 
            this.cidadesMenu2.Name = "cidadesMenu2";
            this.cidadesMenu2.Size = new System.Drawing.Size(182, 22);
            this.cidadesMenu2.Tag = "TxBCodigoCidade";
            this.cidadesMenu2.Text = "Cidades";
            this.cidadesMenu2.Click += new System.EventHandler(this.cidadesMenu2_Click);
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
            // BtnCodigoPessoa
            // 
            this.BtnCodigoPessoa.Location = new System.Drawing.Point(174, 4);
            this.BtnCodigoPessoa.Name = "BtnCodigoPessoa";
            this.BtnCodigoPessoa.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoPessoa.TabIndex = 3;
            this.BtnCodigoPessoa.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoPessoa, "Lista de todas pessoas cadastradas");
            this.BtnCodigoPessoa.UseVisualStyleBackColor = true;
            // 
            // BtnCodigoCidade
            // 
            this.BtnCodigoCidade.Location = new System.Drawing.Point(174, 118);
            this.BtnCodigoCidade.Name = "BtnCodigoCidade";
            this.BtnCodigoCidade.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoCidade.TabIndex = 25;
            this.BtnCodigoCidade.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoCidade, "Lista de todas cidades cadastradas");
            this.BtnCodigoCidade.UseVisualStyleBackColor = true;
            // 
            // BtnCodigoBairro
            // 
            this.BtnCodigoBairro.Location = new System.Drawing.Point(174, 96);
            this.BtnCodigoBairro.Name = "BtnCodigoBairro";
            this.BtnCodigoBairro.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoBairro.TabIndex = 21;
            this.BtnCodigoBairro.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoBairro, "Lista de todos baírros cadastrados");
            this.BtnCodigoBairro.UseVisualStyleBackColor = true;
            // 
            // BtnCodigoEndereco
            // 
            this.BtnCodigoEndereco.Location = new System.Drawing.Point(174, 50);
            this.BtnCodigoEndereco.Name = "BtnCodigoEndereco";
            this.BtnCodigoEndereco.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoEndereco.TabIndex = 13;
            this.BtnCodigoEndereco.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoEndereco, "Lista de todos endereços cadastrados");
            this.BtnCodigoEndereco.UseVisualStyleBackColor = true;
            // 
            // BtnCodigoTitulo
            // 
            this.BtnCodigoTitulo.Location = new System.Drawing.Point(174, 27);
            this.BtnCodigoTitulo.Name = "BtnCodigoTitulo";
            this.BtnCodigoTitulo.Size = new System.Drawing.Size(20, 20);
            this.BtnCodigoTitulo.TabIndex = 9;
            this.BtnCodigoTitulo.TabStop = false;
            this.TTpDica.SetToolTip(this.BtnCodigoTitulo, "Lista de todos títulos cadastrados");
            this.BtnCodigoTitulo.UseVisualStyleBackColor = true;
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
            this.imageList.Images.SetKeyName(14, "CodigoPessoa-");
            this.imageList.Images.SetKeyName(15, "CodigoPessoa+");
            this.imageList.Images.SetKeyName(16, "CodigoTitulo-");
            this.imageList.Images.SetKeyName(17, "CodigoTitulo+");
            this.imageList.Images.SetKeyName(18, "CodigoEndereco-");
            this.imageList.Images.SetKeyName(19, "CodigoEndereco+");
            this.imageList.Images.SetKeyName(20, "CodigoBairro-");
            this.imageList.Images.SetKeyName(21, "CodigoBairro+");
            this.imageList.Images.SetKeyName(22, "CodigoCidade-");
            this.imageList.Images.SetKeyName(23, "CodigoCidade+");
            this.imageList.Images.SetKeyName(24, "Fotografia-");
            this.imageList.Images.SetKeyName(25, "Fotografia+");
            this.imageList.Images.SetKeyName(26, "CodigoTipoTelefone-");
            this.imageList.Images.SetKeyName(27, "CodigoTipoTelefone+");
            this.imageList.Images.SetKeyName(28, "CodigoTipoComunicacao-");
            this.imageList.Images.SetKeyName(29, "CodigoTipoComunicacao+");
            this.imageList.Images.SetKeyName(30, "CodigoTipoDocumento-");
            this.imageList.Images.SetKeyName(31, "CodigoTipoDocumento+");
            this.imageList.Images.SetKeyName(32, "Adicionar-");
            this.imageList.Images.SetKeyName(33, "Adicionar+");
            this.imageList.Images.SetKeyName(34, "Atualizar-");
            this.imageList.Images.SetKeyName(35, "Atualizar+");
            this.imageList.Images.SetKeyName(36, "Remover-");
            this.imageList.Images.SetKeyName(37, "Remover+");
            this.imageList.Images.SetKeyName(38, "Navegador-");
            this.imageList.Images.SetKeyName(39, "Navegador+");
            // 
            // PnlPainel2
            // 
            this.PnlPainel2.Controls.Add(this.BtnCodigoPessoa);
            this.PnlPainel2.Controls.Add(this.TxBContinente);
            this.PnlPainel2.Controls.Add(this.TxBCodigoContinente);
            this.PnlPainel2.Controls.Add(this.LblContinente);
            this.PnlPainel2.Controls.Add(this.TxBPaisSigla);
            this.PnlPainel2.Controls.Add(this.LblPaisSigla);
            this.PnlPainel2.Controls.Add(this.TxBPais);
            this.PnlPainel2.Controls.Add(this.TxBCodigoPais);
            this.PnlPainel2.Controls.Add(this.LblPais);
            this.PnlPainel2.Controls.Add(this.TxBEstadoSigla);
            this.PnlPainel2.Controls.Add(this.LblEstadoSigla);
            this.PnlPainel2.Controls.Add(this.TxBEstado);
            this.PnlPainel2.Controls.Add(this.TxBCodigoEstado);
            this.PnlPainel2.Controls.Add(this.LblEstado);
            this.PnlPainel2.Controls.Add(this.MkBCEP);
            this.PnlPainel2.Controls.Add(this.TxBCidade);
            this.PnlPainel2.Controls.Add(this.BtnCodigoCidade);
            this.PnlPainel2.Controls.Add(this.TxBCodigoCidade);
            this.PnlPainel2.Controls.Add(this.LblCidade);
            this.PnlPainel2.Controls.Add(this.TxBBairro);
            this.PnlPainel2.Controls.Add(this.BtnCodigoBairro);
            this.PnlPainel2.Controls.Add(this.TxBCodigoBairro);
            this.PnlPainel2.Controls.Add(this.LblBairro);
            this.PnlPainel2.Controls.Add(this.TxBComplemento);
            this.PnlPainel2.Controls.Add(this.LblComplemento);
            this.PnlPainel2.Controls.Add(this.TxBNumeroResidencia);
            this.PnlPainel2.Controls.Add(this.LblNumero);
            this.PnlPainel2.Controls.Add(this.TxBEndereco);
            this.PnlPainel2.Controls.Add(this.BtnCodigoEndereco);
            this.PnlPainel2.Controls.Add(this.TxBCodigoEndereco);
            this.PnlPainel2.Controls.Add(this.LblEndereco);
            this.PnlPainel2.Controls.Add(this.TxBTitulo);
            this.PnlPainel2.Controls.Add(this.BtnCodigoTitulo);
            this.PnlPainel2.Controls.Add(this.TxBCodigoTitulo);
            this.PnlPainel2.Controls.Add(this.LblTitulo);
            this.PnlPainel2.Controls.Add(this.LblCEP);
            this.PnlPainel2.Controls.Add(this.TxBCodigoPessoa);
            this.PnlPainel2.Controls.Add(this.TxBPessoa);
            this.PnlPainel2.Controls.Add(this.LblPessoa);
            this.PnlPainel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPainel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPainel2.Name = "PnlPainel2";
            this.PnlPainel2.Size = new System.Drawing.Size(624, 217);
            this.PnlPainel2.TabIndex = 1;
            // 
            // TxBContinente
            // 
            this.TxBContinente.Location = new System.Drawing.Point(174, 189);
            this.TxBContinente.Name = "TxBContinente";
            this.TxBContinente.ReadOnly = true;
            this.TxBContinente.Size = new System.Drawing.Size(294, 20);
            this.TxBContinente.TabIndex = 37;
            this.TxBContinente.TabStop = false;
            // 
            // TxBCodigoContinente
            // 
            this.TxBCodigoContinente.Location = new System.Drawing.Point(92, 189);
            this.TxBCodigoContinente.Name = "TxBCodigoContinente";
            this.TxBCodigoContinente.ReadOnly = true;
            this.TxBCodigoContinente.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoContinente.TabIndex = 36;
            this.TxBCodigoContinente.TabStop = false;
            // 
            // LblContinente
            // 
            this.LblContinente.AutoSize = true;
            this.LblContinente.Location = new System.Drawing.Point(17, 193);
            this.LblContinente.Name = "LblContinente";
            this.LblContinente.Size = new System.Drawing.Size(72, 13);
            this.LblContinente.TabIndex = 35;
            this.LblContinente.Text = "Continente:";
            // 
            // TxBPaisSigla
            // 
            this.TxBPaisSigla.Location = new System.Drawing.Point(519, 165);
            this.TxBPaisSigla.Name = "TxBPaisSigla";
            this.TxBPaisSigla.ReadOnly = true;
            this.TxBPaisSigla.Size = new System.Drawing.Size(80, 20);
            this.TxBPaisSigla.TabIndex = 34;
            this.TxBPaisSigla.TabStop = false;
            // 
            // LblPaisSigla
            // 
            this.LblPaisSigla.AutoSize = true;
            this.LblPaisSigla.Location = new System.Drawing.Point(478, 169);
            this.LblPaisSigla.Name = "LblPaisSigla";
            this.LblPaisSigla.Size = new System.Drawing.Size(39, 13);
            this.LblPaisSigla.TabIndex = 33;
            this.LblPaisSigla.Text = "Sigla:";
            // 
            // TxBPais
            // 
            this.TxBPais.Location = new System.Drawing.Point(174, 165);
            this.TxBPais.Name = "TxBPais";
            this.TxBPais.ReadOnly = true;
            this.TxBPais.Size = new System.Drawing.Size(294, 20);
            this.TxBPais.TabIndex = 32;
            this.TxBPais.TabStop = false;
            // 
            // TxBCodigoPais
            // 
            this.TxBCodigoPais.Location = new System.Drawing.Point(92, 165);
            this.TxBCodigoPais.Name = "TxBCodigoPais";
            this.TxBCodigoPais.ReadOnly = true;
            this.TxBCodigoPais.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoPais.TabIndex = 31;
            this.TxBCodigoPais.TabStop = false;
            // 
            // LblPais
            // 
            this.LblPais.AutoSize = true;
            this.LblPais.Location = new System.Drawing.Point(52, 169);
            this.LblPais.Name = "LblPais";
            this.LblPais.Size = new System.Drawing.Size(37, 13);
            this.LblPais.TabIndex = 30;
            this.LblPais.Text = "País:";
            // 
            // TxBEstadoSigla
            // 
            this.TxBEstadoSigla.Location = new System.Drawing.Point(519, 141);
            this.TxBEstadoSigla.Name = "TxBEstadoSigla";
            this.TxBEstadoSigla.ReadOnly = true;
            this.TxBEstadoSigla.Size = new System.Drawing.Size(80, 20);
            this.TxBEstadoSigla.TabIndex = 37;
            this.TxBEstadoSigla.TabStop = false;
            // 
            // LblEstadoSigla
            // 
            this.LblEstadoSigla.AutoSize = true;
            this.LblEstadoSigla.Location = new System.Drawing.Point(478, 145);
            this.LblEstadoSigla.Name = "LblEstadoSigla";
            this.LblEstadoSigla.Size = new System.Drawing.Size(39, 13);
            this.LblEstadoSigla.TabIndex = 36;
            this.LblEstadoSigla.Text = "Sigla:";
            // 
            // TxBEstado
            // 
            this.TxBEstado.Location = new System.Drawing.Point(174, 141);
            this.TxBEstado.Name = "TxBEstado";
            this.TxBEstado.ReadOnly = true;
            this.TxBEstado.Size = new System.Drawing.Size(294, 20);
            this.TxBEstado.TabIndex = 29;
            this.TxBEstado.TabStop = false;
            // 
            // TxBCodigoEstado
            // 
            this.TxBCodigoEstado.Location = new System.Drawing.Point(92, 141);
            this.TxBCodigoEstado.Name = "TxBCodigoEstado";
            this.TxBCodigoEstado.ReadOnly = true;
            this.TxBCodigoEstado.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoEstado.TabIndex = 28;
            this.TxBCodigoEstado.TabStop = false;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(39, 145);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(50, 13);
            this.LblEstado.TabIndex = 27;
            this.LblEstado.Text = "Estado:";
            // 
            // MkBCEP
            // 
            this.MkBCEP.Location = new System.Drawing.Point(526, 4);
            this.MkBCEP.Mask = "00,000-999";
            this.MkBCEP.Name = "MkBCEP";
            this.MkBCEP.Size = new System.Drawing.Size(73, 20);
            this.MkBCEP.TabIndex = 6;
            // 
            // TxBCidade
            // 
            this.TxBCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBCidade.Location = new System.Drawing.Point(197, 118);
            this.TxBCidade.Name = "TxBCidade";
            this.TxBCidade.ReadOnly = true;
            this.TxBCidade.Size = new System.Drawing.Size(402, 20);
            this.TxBCidade.TabIndex = 26;
            this.TxBCidade.TabStop = false;
            // 
            // TxBCodigoCidade
            // 
            this.TxBCodigoCidade.Location = new System.Drawing.Point(92, 118);
            this.TxBCodigoCidade.Name = "TxBCodigoCidade";
            this.TxBCodigoCidade.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoCidade.TabIndex = 24;
            this.TxBCodigoCidade.Tag = "";
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(39, 122);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(50, 13);
            this.LblCidade.TabIndex = 23;
            this.LblCidade.Text = "Cidade:";
            // 
            // TxBBairro
            // 
            this.TxBBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBBairro.Location = new System.Drawing.Point(197, 96);
            this.TxBBairro.Name = "TxBBairro";
            this.TxBBairro.ReadOnly = true;
            this.TxBBairro.Size = new System.Drawing.Size(402, 20);
            this.TxBBairro.TabIndex = 22;
            this.TxBBairro.TabStop = false;
            // 
            // TxBCodigoBairro
            // 
            this.TxBCodigoBairro.Location = new System.Drawing.Point(92, 96);
            this.TxBCodigoBairro.Name = "TxBCodigoBairro";
            this.TxBCodigoBairro.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoBairro.TabIndex = 20;
            this.TxBCodigoBairro.Tag = "";
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(45, 100);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(44, 13);
            this.LblBairro.TabIndex = 19;
            this.LblBairro.Text = "Bairro:";
            // 
            // TxBComplemento
            // 
            this.TxBComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBComplemento.Location = new System.Drawing.Point(92, 73);
            this.TxBComplemento.Name = "TxBComplemento";
            this.TxBComplemento.Size = new System.Drawing.Size(509, 20);
            this.TxBComplemento.TabIndex = 18;
            this.TxBComplemento.Tag = "";
            // 
            // LblComplemento
            // 
            this.LblComplemento.AutoSize = true;
            this.LblComplemento.Location = new System.Drawing.Point(4, 77);
            this.LblComplemento.Name = "LblComplemento";
            this.LblComplemento.Size = new System.Drawing.Size(86, 13);
            this.LblComplemento.TabIndex = 17;
            this.LblComplemento.Text = "Complemento:";
            // 
            // TxBNumeroResidencia
            // 
            this.TxBNumeroResidencia.Location = new System.Drawing.Point(521, 50);
            this.TxBNumeroResidencia.Name = "TxBNumeroResidencia";
            this.TxBNumeroResidencia.Size = new System.Drawing.Size(80, 20);
            this.TxBNumeroResidencia.TabIndex = 16;
            this.TxBNumeroResidencia.Tag = "";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(463, 54);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(54, 13);
            this.LblNumero.TabIndex = 15;
            this.LblNumero.Text = "Número:";
            // 
            // TxBEndereco
            // 
            this.TxBEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBEndereco.Location = new System.Drawing.Point(197, 50);
            this.TxBEndereco.Name = "TxBEndereco";
            this.TxBEndereco.ReadOnly = true;
            this.TxBEndereco.Size = new System.Drawing.Size(262, 20);
            this.TxBEndereco.TabIndex = 14;
            this.TxBEndereco.TabStop = false;
            // 
            // TxBCodigoEndereco
            // 
            this.TxBCodigoEndereco.Location = new System.Drawing.Point(92, 50);
            this.TxBCodigoEndereco.Name = "TxBCodigoEndereco";
            this.TxBCodigoEndereco.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoEndereco.TabIndex = 12;
            this.TxBCodigoEndereco.Tag = "";
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Location = new System.Drawing.Point(25, 54);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(65, 13);
            this.LblEndereco.TabIndex = 11;
            this.LblEndereco.Text = "Endereço:";
            // 
            // TxBTitulo
            // 
            this.TxBTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBTitulo.Location = new System.Drawing.Point(197, 27);
            this.TxBTitulo.Name = "TxBTitulo";
            this.TxBTitulo.ReadOnly = true;
            this.TxBTitulo.Size = new System.Drawing.Size(402, 20);
            this.TxBTitulo.TabIndex = 10;
            this.TxBTitulo.TabStop = false;
            // 
            // TxBCodigoTitulo
            // 
            this.TxBCodigoTitulo.Location = new System.Drawing.Point(92, 27);
            this.TxBCodigoTitulo.Name = "TxBCodigoTitulo";
            this.TxBCodigoTitulo.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoTitulo.TabIndex = 8;
            this.TxBCodigoTitulo.Tag = "";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(45, 31);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(45, 13);
            this.LblTitulo.TabIndex = 7;
            this.LblTitulo.Text = "Título:";
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Location = new System.Drawing.Point(467, 8);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(55, 13);
            this.LblCEP.TabIndex = 5;
            this.LblCEP.Text = "C. E. P.:";
            // 
            // TxBCodigoPessoa
            // 
            this.TxBCodigoPessoa.Location = new System.Drawing.Point(92, 4);
            this.TxBCodigoPessoa.Name = "TxBCodigoPessoa";
            this.TxBCodigoPessoa.Size = new System.Drawing.Size(80, 20);
            this.TxBCodigoPessoa.TabIndex = 2;
            this.TxBCodigoPessoa.Tag = "";
            // 
            // TxBPessoa
            // 
            this.TxBPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBPessoa.Location = new System.Drawing.Point(197, 4);
            this.TxBPessoa.Name = "TxBPessoa";
            this.TxBPessoa.ReadOnly = true;
            this.TxBPessoa.Size = new System.Drawing.Size(262, 20);
            this.TxBPessoa.TabIndex = 4;
            this.TxBPessoa.TabStop = false;
            this.TxBPessoa.Tag = "";
            // 
            // LblPessoa
            // 
            this.LblPessoa.AutoSize = true;
            this.LblPessoa.Location = new System.Drawing.Point(35, 8);
            this.LblPessoa.Name = "LblPessoa";
            this.LblPessoa.Size = new System.Drawing.Size(52, 13);
            this.LblPessoa.TabIndex = 1;
            this.LblPessoa.Text = "Pessoa:";
            // 
            // PessoasF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 271);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.PnlPainel2);
            this.Controls.Add(this.PnlPainel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PessoasF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PessoaF_FormClosing);
            this.Shown += new System.EventHandler(this.PessoaF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PessoaF_KeyDown);
            this.PnlPainel1.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.PnlPainel2.ResumeLayout(false);
            this.PnlPainel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPainel1;
        private System.Windows.Forms.Button BtnSaida;
        private System.Windows.Forms.Button BtnCancela;
        private System.Windows.Forms.Button BtnIAE;
        private System.Windows.Forms.ToolTip TTpDica;
        private System.Windows.Forms.ImageList imageList;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem titulosEnderecosMenu2;
        public System.Windows.Forms.ToolStripMenuItem enderecosMenu2;
        public System.Windows.Forms.ToolStripMenuItem bairrosMenu2;
        public System.Windows.Forms.ToolStripMenuItem cidadesMenu2;
        private System.Windows.Forms.ToolStripMenuItem pessoasMenu2;
        private System.Windows.Forms.Panel PnlPainel2;
        private System.Windows.Forms.Button BtnCodigoPessoa;
        private System.Windows.Forms.TextBox TxBContinente;
        private System.Windows.Forms.TextBox TxBCodigoContinente;
        private System.Windows.Forms.Label LblContinente;
        private System.Windows.Forms.TextBox TxBPaisSigla;
        private System.Windows.Forms.Label LblPaisSigla;
        private System.Windows.Forms.TextBox TxBPais;
        private System.Windows.Forms.TextBox TxBCodigoPais;
        private System.Windows.Forms.Label LblPais;
        private System.Windows.Forms.TextBox TxBEstadoSigla;
        private System.Windows.Forms.Label LblEstadoSigla;
        private System.Windows.Forms.TextBox TxBEstado;
        private System.Windows.Forms.TextBox TxBCodigoEstado;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.MaskedTextBox MkBCEP;
        private System.Windows.Forms.TextBox TxBCidade;
        private System.Windows.Forms.Button BtnCodigoCidade;
        private System.Windows.Forms.TextBox TxBCodigoCidade;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox TxBBairro;
        private System.Windows.Forms.Button BtnCodigoBairro;
        private System.Windows.Forms.TextBox TxBCodigoBairro;
        private System.Windows.Forms.Label LblBairro;
        public System.Windows.Forms.TextBox TxBComplemento;
        public System.Windows.Forms.Label LblComplemento;
        private System.Windows.Forms.TextBox TxBNumeroResidencia;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxBEndereco;
        private System.Windows.Forms.Button BtnCodigoEndereco;
        private System.Windows.Forms.TextBox TxBCodigoEndereco;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.TextBox TxBTitulo;
        private System.Windows.Forms.Button BtnCodigoTitulo;
        private System.Windows.Forms.TextBox TxBCodigoTitulo;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblCEP;
        public System.Windows.Forms.TextBox TxBCodigoPessoa;
        public System.Windows.Forms.TextBox TxBPessoa;
        public System.Windows.Forms.Label LblPessoa;


    }
}

