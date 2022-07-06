namespace SampleXP
{
    partial class PrincipalF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalF));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosMapeamentoMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosPaisesMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosEstadosMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosPessoasMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosMenu1,
            this.saidaMenu1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(234, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastrosMenu1
            // 
            this.cadastrosMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosMapeamentoMenu1,
            this.cadastrosPessoasMenu1});
            this.cadastrosMenu1.Name = "cadastrosMenu1";
            this.cadastrosMenu1.Size = new System.Drawing.Size(71, 20);
            this.cadastrosMenu1.Text = "Cadastros";
            // 
            // cadastrosMapeamentoMenu1
            // 
            this.cadastrosMapeamentoMenu1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosPaisesMenu1,
            this.cadastrosEstadosMenu1,
            this.cidadesToolStripMenuItem});
            this.cadastrosMapeamentoMenu1.Name = "cadastrosMapeamentoMenu1";
            this.cadastrosMapeamentoMenu1.Size = new System.Drawing.Size(145, 22);
            this.cadastrosMapeamentoMenu1.Text = "Mapeamento";
            // 
            // cadastrosPaisesMenu1
            // 
            this.cadastrosPaisesMenu1.Name = "cadastrosPaisesMenu1";
            this.cadastrosPaisesMenu1.Size = new System.Drawing.Size(116, 22);
            this.cadastrosPaisesMenu1.Text = "Paises";
            this.cadastrosPaisesMenu1.Click += new System.EventHandler(this.cadastrosPaisesMenu1_Click);
            // 
            // cadastrosEstadosMenu1
            // 
            this.cadastrosEstadosMenu1.Name = "cadastrosEstadosMenu1";
            this.cadastrosEstadosMenu1.Size = new System.Drawing.Size(116, 22);
            this.cadastrosEstadosMenu1.Text = "Estados";
            this.cadastrosEstadosMenu1.Click += new System.EventHandler(this.cadastrosEstadosMenu1_Click);
            // 
            // cidadesToolStripMenuItem
            // 
            this.cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            this.cidadesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cidadesToolStripMenuItem.Text = "Cidades";
            this.cidadesToolStripMenuItem.Click += new System.EventHandler(this.cidadesToolStripMenuItem_Click);
            // 
            // cadastrosPessoasMenu1
            // 
            this.cadastrosPessoasMenu1.Name = "cadastrosPessoasMenu1";
            this.cadastrosPessoasMenu1.Size = new System.Drawing.Size(145, 22);
            this.cadastrosPessoasMenu1.Text = "Pessoas";
            this.cadastrosPessoasMenu1.Click += new System.EventHandler(this.cadastrosPessoasMenu1_Click);
            // 
            // saidaMenu1
            // 
            this.saidaMenu1.Name = "saidaMenu1";
            this.saidaMenu1.Size = new System.Drawing.Size(47, 20);
            this.saidaMenu1.Text = "Saída";
            this.saidaMenu1.Click += new System.EventHandler(this.saidaMenu1_Click);
            // 
            // PrincipalF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 135);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleXP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalF_FormClosing);
            this.Shown += new System.EventHandler(this.PrincipalF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrincipalF_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosMenu1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosMapeamentoMenu1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosPaisesMenu1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosEstadosMenu1;
        private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosPessoasMenu1;
        private System.Windows.Forms.ToolStripMenuItem saidaMenu1;

    }
}

