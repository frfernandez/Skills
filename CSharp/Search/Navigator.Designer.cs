namespace Search
{
    partial class NavigatorF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigatorF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrior = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.TTpDica = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnView);
            this.PnlPanel1.Controls.Add(this.BtnDelete);
            this.PnlPanel1.Controls.Add(this.BtnUpdate);
            this.PnlPanel1.Controls.Add(this.BtnExit);
            this.PnlPanel1.Controls.Add(this.BtnLast);
            this.PnlPanel1.Controls.Add(this.BtnNext);
            this.PnlPanel1.Controls.Add(this.BtnPrior);
            this.PnlPanel1.Controls.Add(this.BtnFirst);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(742, 55);
            this.PnlPanel1.TabIndex = 0;
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(647, 3);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(93, 50);
            this.BtnView.TabIndex = 40;
            this.BtnView.TabStop = false;
            this.BtnView.Text = "&View";
            this.TTpDica.SetToolTip(this.BtnView, "Selects the current record");
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(555, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(93, 50);
            this.BtnDelete.TabIndex = 39;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Text = "&Delete";
            this.TTpDica.SetToolTip(this.BtnDelete, "Sets the record in delete mode");
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(463, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(93, 50);
            this.BtnUpdate.TabIndex = 38;
            this.BtnUpdate.TabStop = false;
            this.BtnUpdate.Text = "&Update";
            this.TTpDica.SetToolTip(this.BtnUpdate, "Sets the record in update mode");
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(371, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 50);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "&Exit";
            this.TTpDica.SetToolTip(this.BtnExit, "Back to the prior form");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(279, 3);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(93, 50);
            this.BtnLast.TabIndex = 6;
            this.BtnLast.TabStop = false;
            this.BtnLast.Text = "&Last";
            this.TTpDica.SetToolTip(this.BtnLast, "Selects the last record");
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(187, 3);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(93, 50);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.TabStop = false;
            this.BtnNext.Text = "&Next";
            this.TTpDica.SetToolTip(this.BtnNext, "Selects the next record");
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrior
            // 
            this.BtnPrior.Location = new System.Drawing.Point(95, 3);
            this.BtnPrior.Name = "BtnPrior";
            this.BtnPrior.Size = new System.Drawing.Size(93, 50);
            this.BtnPrior.TabIndex = 2;
            this.BtnPrior.TabStop = false;
            this.BtnPrior.Text = "&Prior";
            this.TTpDica.SetToolTip(this.BtnPrior, "Selects the prior record");
            this.BtnPrior.UseVisualStyleBackColor = true;
            this.BtnPrior.Click += new System.EventHandler(this.BtnPrior_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(3, 3);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(93, 50);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.TabStop = false;
            this.BtnFirst.Text = "&First";
            this.TTpDica.SetToolTip(this.BtnFirst, "Selects the first record");
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Exit-");
            this.Images.Images.SetKeyName(1, "Exit+");
            this.Images.Images.SetKeyName(2, "Next-");
            this.Images.Images.SetKeyName(3, "Next+");
            this.Images.Images.SetKeyName(4, "Last-");
            this.Images.Images.SetKeyName(5, "Last+");
            this.Images.Images.SetKeyName(6, "Prior-");
            this.Images.Images.SetKeyName(7, "Prior+");
            this.Images.Images.SetKeyName(8, "First-");
            this.Images.Images.SetKeyName(9, "First+");
            this.Images.Images.SetKeyName(10, "Update-");
            this.Images.Images.SetKeyName(11, "Update+");
            this.Images.Images.SetKeyName(12, "Delete-");
            this.Images.Images.SetKeyName(13, "Delete+");
            this.Images.Images.SetKeyName(14, "View-");
            this.Images.Images.SetKeyName(15, "View+");
            // 
            // NavigatorF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 56);
            this.ControlBox = false;
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NavigatorF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Navigator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NavigatorF_FormClosing);
            this.Shown += new System.EventHandler(this.NavigatorF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NavigatorF_KeyDown);
            this.PnlPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrior;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.ToolTip TTpDica;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnView;
    }
}