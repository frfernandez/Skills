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
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.GBxRecord = new System.Windows.Forms.GroupBox();
            this.RBtDelete = new System.Windows.Forms.RadioButton();
            this.RBtUpdate = new System.Windows.Forms.RadioButton();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.TxBDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.PnlPanel3 = new System.Windows.Forms.Panel();
            this.DGVSearch = new System.Windows.Forms.DataGridView();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlPanel1.SuspendLayout();
            this.GBxRecord.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.PnlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnSelect);
            this.PnlPanel1.Controls.Add(this.GBxRecord);
            this.PnlPanel1.Controls.Add(this.BtnReport);
            this.PnlPanel1.Controls.Add(this.BtnExit);
            this.PnlPanel1.Controls.Add(this.BtnFilter);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(621, 54);
            this.PnlPanel1.TabIndex = 0;
            // 
            // BtnSelect
            // 
            this.BtnSelect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSelect.Location = new System.Drawing.Point(3, 3);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(93, 50);
            this.BtnSelect.TabIndex = 0;
            this.BtnSelect.TabStop = false;
            this.BtnSelect.Text = "&Select";
            this.TTpTip.SetToolTip(this.BtnSelect, "Select the record in the data grid");
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // GBxRecord
            // 
            this.GBxRecord.Controls.Add(this.RBtDelete);
            this.GBxRecord.Controls.Add(this.RBtUpdate);
            this.GBxRecord.Dock = System.Windows.Forms.DockStyle.Right;
            this.GBxRecord.Location = new System.Drawing.Point(534, 0);
            this.GBxRecord.Name = "GBxRecord";
            this.GBxRecord.Size = new System.Drawing.Size(87, 54);
            this.GBxRecord.TabIndex = 4;
            this.GBxRecord.TabStop = false;
            this.GBxRecord.Text = "Record";
            this.TTpTip.SetToolTip(this.GBxRecord, "Defines the record state");
            this.GBxRecord.Visible = false;
            // 
            // RBtDelete
            // 
            this.RBtDelete.AutoSize = true;
            this.RBtDelete.Location = new System.Drawing.Point(6, 34);
            this.RBtDelete.Name = "RBtDelete";
            this.RBtDelete.Size = new System.Drawing.Size(62, 17);
            this.RBtDelete.TabIndex = 1;
            this.RBtDelete.TabStop = true;
            this.RBtDelete.Text = "&Delete";
            this.TTpTip.SetToolTip(this.RBtDelete, "Sets the record in delete mode");
            this.RBtDelete.UseVisualStyleBackColor = true;
            // 
            // RBtUpdate
            // 
            this.RBtUpdate.AutoSize = true;
            this.RBtUpdate.Checked = true;
            this.RBtUpdate.Location = new System.Drawing.Point(6, 13);
            this.RBtUpdate.Name = "RBtUpdate";
            this.RBtUpdate.Size = new System.Drawing.Size(66, 17);
            this.RBtUpdate.TabIndex = 0;
            this.RBtUpdate.TabStop = true;
            this.RBtUpdate.Text = "&Update";
            this.TTpTip.SetToolTip(this.RBtUpdate, "Sets the record in update mode");
            this.RBtUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnReport
            // 
            this.BtnReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReport.Location = new System.Drawing.Point(189, 3);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(93, 50);
            this.BtnReport.TabIndex = 3;
            this.BtnReport.TabStop = false;
            this.BtnReport.Text = "&Report";
            this.TTpTip.SetToolTip(this.BtnReport, "Report of all records");
            this.BtnReport.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExit.Location = new System.Drawing.Point(96, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 50);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "&Exit";
            this.TTpTip.SetToolTip(this.BtnExit, "Back to the prior form");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFilter.Location = new System.Drawing.Point(3, 3);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(93, 50);
            this.BtnFilter.TabIndex = 1;
            this.BtnFilter.TabStop = false;
            this.BtnFilter.Text = "&Filter";
            this.TTpTip.SetToolTip(this.BtnFilter, "Filter the records");
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Visible = false;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // PnlPanel2
            // 
            this.PnlPanel2.Controls.Add(this.TxBDescription);
            this.PnlPanel2.Controls.Add(this.LblDescription);
            this.PnlPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel2.Location = new System.Drawing.Point(0, 54);
            this.PnlPanel2.Name = "PnlPanel2";
            this.PnlPanel2.Size = new System.Drawing.Size(621, 44);
            this.PnlPanel2.TabIndex = 1;
            // 
            // TxBDescription
            // 
            this.TxBDescription.BackColor = System.Drawing.SystemColors.Window;
            this.TxBDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxBDescription.Location = new System.Drawing.Point(8, 19);
            this.TxBDescription.Name = "TxBDescription";
            this.TxBDescription.Size = new System.Drawing.Size(606, 20);
            this.TxBDescription.TabIndex = 0;
            this.TxBDescription.TextChanged += new System.EventHandler(this.TxBDescription_TextChanged);
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
            // PnlPanel3
            // 
            this.PnlPanel3.Controls.Add(this.DGVSearch);
            this.PnlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPanel3.Location = new System.Drawing.Point(0, 98);
            this.PnlPanel3.Name = "PnlPanel3";
            this.PnlPanel3.Size = new System.Drawing.Size(621, 241);
            this.PnlPanel3.TabIndex = 2;
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
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Filter-");
            this.Images.Images.SetKeyName(1, "Filter+");
            this.Images.Images.SetKeyName(2, "Select-");
            this.Images.Images.SetKeyName(3, "Select+");
            this.Images.Images.SetKeyName(4, "Report-");
            this.Images.Images.SetKeyName(5, "Report+");
            this.Images.Images.SetKeyName(6, "Exit-");
            this.Images.Images.SetKeyName(7, "Exit+");
            // 
            // SearchDataF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 339);
            this.Controls.Add(this.PnlPanel3);
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchDataF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchF_FormClosing);
            this.Shown += new System.EventHandler(this.SearchF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchF_KeyDown);
            this.PnlPanel1.ResumeLayout(false);
            this.GBxRecord.ResumeLayout(false);
            this.GBxRecord.PerformLayout();
            this.PnlPanel2.ResumeLayout(false);
            this.PnlPanel2.PerformLayout();
            this.PnlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Panel PnlPanel2;
        private System.Windows.Forms.Panel PnlPanel3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnFilter;
        public System.Windows.Forms.Label LblDescription;
        public System.Windows.Forms.RadioButton RBtDelete;
        public System.Windows.Forms.RadioButton RBtUpdate;
        public System.Windows.Forms.TextBox TxBDescription;
        public System.Windows.Forms.GroupBox GBxRecord;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        public System.Windows.Forms.Button BtnReport;
        public System.Windows.Forms.DataGridView DGVSearch;


    }
}