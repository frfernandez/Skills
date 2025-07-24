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
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnIUD = new System.Windows.Forms.Button();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.TxBId = new System.Windows.Forms.TextBox();
            this.TxBDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnReport);
            this.PnlPanel1.Controls.Add(this.BtnFilter);
            this.PnlPanel1.Controls.Add(this.BtnExit);
            this.PnlPanel1.Controls.Add(this.BtnCancel);
            this.PnlPanel1.Controls.Add(this.BtnIUD);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(621, 55);
            this.PnlPanel1.TabIndex = 0;
            // 
            // BtnReport
            // 
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReport.Location = new System.Drawing.Point(373, 2);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(93, 50);
            this.BtnReport.TabIndex = 6;
            this.BtnReport.TabStop = false;
            this.BtnReport.Text = "&Report";
            this.TTpTip.SetToolTip(this.BtnReport, "Report of all records");
            this.BtnReport.UseVisualStyleBackColor = true;
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
            this.PnlPanel2.Controls.Add(this.TxBId);
            this.PnlPanel2.Controls.Add(this.TxBDescription);
            this.PnlPanel2.Controls.Add(this.LblDescription);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 55);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(621, 47);
            this.PnlPanel2.TabIndex = 1;
            // 
            // TxBId
            // 
            this.TxBId.Location = new System.Drawing.Point(8, 20);
            this.TxBId.Name = "TxBId";
            this.TxBId.Size = new System.Drawing.Size(80, 20);
            this.TxBId.TabIndex = 0;
            this.TxBId.Visible = false;
            // 
            // TxBDescription
            // 
            this.TxBDescription.Location = new System.Drawing.Point(8, 20);
            this.TxBDescription.Name = "TxBDescription";
            this.TxBDescription.Size = new System.Drawing.Size(606, 20);
            this.TxBDescription.TabIndex = 0;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(8, 4);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(75, 13);
            this.LblDescription.TabIndex = 0;
            this.LblDescription.Text = "Description:";
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
            this.Images.Images.SetKeyName(10, "Report-");
            this.Images.Images.SetKeyName(11, "Report+");
            this.Images.Images.SetKeyName(12, "Exit-");
            this.Images.Images.SetKeyName(13, "Exit+");
            // 
            // SimpleF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 102);
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
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
            this.PnlPanel1.ResumeLayout(false);
            this.PnlPanel2.ResumeLayout(false);
            this.PnlPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnReport;
        public System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Panel PnlPanel2;
        public System.Windows.Forms.TextBox TxBDescription;
        public System.Windows.Forms.TextBox TxBId;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Button BtnIUD;


    }
}

