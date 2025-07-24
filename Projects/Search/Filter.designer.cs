namespace Search
{
    partial class DynamicSearchF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicSearchF));
            this.PnlPanel1 = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.PnlPanel2 = new System.Windows.Forms.Panel();
            this.TxBDescription = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.PnlPanel3 = new System.Windows.Forms.Panel();
            this.DGVSearch = new System.Windows.Forms.DataGridView();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlPanel4 = new System.Windows.Forms.Panel();
            this.BtnIndeterminate = new System.Windows.Forms.Button();
            this.CkBCheckBox = new System.Windows.Forms.CheckBox();
            this.MkBMask = new System.Windows.Forms.MaskedTextBox();
            this.NUDValue = new System.Windows.Forms.NumericUpDown();
            this.BtnWanted = new System.Windows.Forms.Button();
            this.TxBWanted = new System.Windows.Forms.TextBox();
            this.TxBIdWanted = new System.Windows.Forms.TextBox();
            this.LblLabelEnd = new System.Windows.Forms.Label();
            this.LblLabelStart = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlPanel1.SuspendLayout();
            this.PnlPanel2.SuspendLayout();
            this.PnlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).BeginInit();
            this.PnlPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDValue)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPanel1
            // 
            this.PnlPanel1.Controls.Add(this.BtnExit);
            this.PnlPanel1.Controls.Add(this.BtnOrder);
            this.PnlPanel1.Controls.Add(this.BtnClean);
            this.PnlPanel1.Controls.Add(this.BtnFilter);
            this.PnlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPanel1.Location = new System.Drawing.Point(0, 0);
            this.PnlPanel1.Name = "PnlPanel1";
            this.PnlPanel1.Size = new System.Drawing.Size(621, 54);
            this.PnlPanel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(282, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 50);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "&Exit";
            this.TTpTip.SetToolTip(this.BtnExit, "Back to the prior form");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(189, 3);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(93, 50);
            this.BtnOrder.TabIndex = 3;
            this.BtnOrder.TabStop = false;
            this.BtnOrder.Text = "&Order";
            this.TTpTip.SetToolTip(this.BtnOrder, "Set the order of the records");
            this.BtnOrder.UseVisualStyleBackColor = true;
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(96, 3);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(93, 50);
            this.BtnClean.TabIndex = 2;
            this.BtnClean.TabStop = false;
            this.BtnClean.Tag = "";
            this.BtnClean.Text = "&Clean";
            this.TTpTip.SetToolTip(this.BtnClean, "Clean the values in the data grid");
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(3, 3);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(93, 50);
            this.BtnFilter.TabIndex = 1;
            this.BtnFilter.TabStop = false;
            this.BtnFilter.Text = "&Filter";
            this.TTpTip.SetToolTip(this.BtnFilter, "Filter based on information in the data grid");
            this.BtnFilter.UseVisualStyleBackColor = true;
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
            this.TxBDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxBDescription_KeyDown);
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
            this.PnlPanel3.Size = new System.Drawing.Size(621, 240);
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
            this.DGVSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVSearch.Size = new System.Drawing.Size(621, 240);
            this.DGVSearch.TabIndex = 0;
            this.DGVSearch.Click += new System.EventHandler(this.DGVSearch_Click);
            this.DGVSearch.DoubleClick += new System.EventHandler(this.DGVSearch_DoubleClick);
            this.DGVSearch.Enter += new System.EventHandler(this.DGVSearch_Enter);
            this.DGVSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGVSearch_KeyUp);
            this.DGVSearch.Leave += new System.EventHandler(this.DGVSearch_Leave);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Filter-");
            this.Images.Images.SetKeyName(1, "Filter+");
            this.Images.Images.SetKeyName(2, "Clean-");
            this.Images.Images.SetKeyName(3, "Clean+");
            this.Images.Images.SetKeyName(4, "Order-");
            this.Images.Images.SetKeyName(5, "Order+");
            this.Images.Images.SetKeyName(6, "Exit-");
            this.Images.Images.SetKeyName(7, "Exit+");
            this.Images.Images.SetKeyName(8, "Wanted-");
            this.Images.Images.SetKeyName(9, "Wanted+");
            this.Images.Images.SetKeyName(10, "Indeterminate-");
            this.Images.Images.SetKeyName(11, "Indeterminate+");
            // 
            // PnlPanel4
            // 
            this.PnlPanel4.Controls.Add(this.BtnIndeterminate);
            this.PnlPanel4.Controls.Add(this.CkBCheckBox);
            this.PnlPanel4.Controls.Add(this.MkBMask);
            this.PnlPanel4.Controls.Add(this.NUDValue);
            this.PnlPanel4.Controls.Add(this.BtnWanted);
            this.PnlPanel4.Controls.Add(this.TxBWanted);
            this.PnlPanel4.Controls.Add(this.TxBIdWanted);
            this.PnlPanel4.Controls.Add(this.LblLabelEnd);
            this.PnlPanel4.Controls.Add(this.LblLabelStart);
            this.PnlPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlPanel4.Location = new System.Drawing.Point(0, 338);
            this.PnlPanel4.Name = "PnlPanel4";
            this.PnlPanel4.Size = new System.Drawing.Size(621, 46);
            this.PnlPanel4.TabIndex = 4;
            // 
            // BtnIndeterminate
            // 
            this.BtnIndeterminate.Location = new System.Drawing.Point(598, 20);
            this.BtnIndeterminate.Name = "BtnIndeterminate";
            this.BtnIndeterminate.Size = new System.Drawing.Size(20, 20);
            this.BtnIndeterminate.TabIndex = 10;
            this.BtnIndeterminate.TabStop = false;
            this.BtnIndeterminate.UseVisualStyleBackColor = true;
            this.BtnIndeterminate.Visible = false;
            this.BtnIndeterminate.Click += new System.EventHandler(this.BtnIndeterminate_Click);
            // 
            // CkBCheckBox
            // 
            this.CkBCheckBox.AutoSize = true;
            this.CkBCheckBox.Checked = true;
            this.CkBCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.CkBCheckBox.Location = new System.Drawing.Point(4, 20);
            this.CkBCheckBox.Name = "CkBCheckBox";
            this.CkBCheckBox.Size = new System.Drawing.Size(106, 17);
            this.CkBCheckBox.TabIndex = 9;
            this.CkBCheckBox.Tag = "Y;N";
            this.CkBCheckBox.Text = "CkBCheckBox";
            this.CkBCheckBox.UseVisualStyleBackColor = true;
            this.CkBCheckBox.CheckedChanged += new System.EventHandler(this.CkBCheckBox_CheckedChanged);
            this.CkBCheckBox.Enter += new System.EventHandler(this.CkBCheckBox_Enter);
            // 
            // MkBMask
            // 
            this.MkBMask.Location = new System.Drawing.Point(4, 20);
            this.MkBMask.Name = "MkBMask";
            this.MkBMask.Size = new System.Drawing.Size(80, 20);
            this.MkBMask.TabIndex = 7;
            this.MkBMask.Leave += new System.EventHandler(this.MkBMaskStart_Leave);
            // 
            // NUDValue
            // 
            this.NUDValue.Location = new System.Drawing.Point(4, 20);
            this.NUDValue.Name = "NUDValue";
            this.NUDValue.Size = new System.Drawing.Size(95, 20);
            this.NUDValue.TabIndex = 5;
            this.NUDValue.Leave += new System.EventHandler(this.NUDValueStart_Leave);
            // 
            // BtnWanted
            // 
            this.BtnWanted.Location = new System.Drawing.Point(598, 20);
            this.BtnWanted.Name = "BtnWanted";
            this.BtnWanted.Size = new System.Drawing.Size(20, 20);
            this.BtnWanted.TabIndex = 4;
            this.BtnWanted.TabStop = false;
            this.BtnWanted.UseVisualStyleBackColor = true;
            this.BtnWanted.Click += new System.EventHandler(this.BtnWanted_Click);
            // 
            // TxBWanted
            // 
            this.TxBWanted.Location = new System.Drawing.Point(82, 20);
            this.TxBWanted.Name = "TxBWanted";
            this.TxBWanted.Size = new System.Drawing.Size(510, 20);
            this.TxBWanted.TabIndex = 3;
            this.TxBWanted.Leave += new System.EventHandler(this.TxBWanted_Leave);
            // 
            // TxBIdWanted
            // 
            this.TxBIdWanted.Location = new System.Drawing.Point(4, 20);
            this.TxBIdWanted.Name = "TxBIdWanted";
            this.TxBIdWanted.Size = new System.Drawing.Size(80, 20);
            this.TxBIdWanted.TabIndex = 2;
            this.TxBIdWanted.Leave += new System.EventHandler(this.TxBIdWanted_Leave);
            // 
            // LblLabelEnd
            // 
            this.LblLabelEnd.AutoSize = true;
            this.LblLabelEnd.Location = new System.Drawing.Point(84, 4);
            this.LblLabelEnd.Name = "LblLabelEnd";
            this.LblLabelEnd.Size = new System.Drawing.Size(77, 13);
            this.LblLabelEnd.TabIndex = 1;
            this.LblLabelEnd.Text = "LblLabelEnd";
            // 
            // LblLabelStart
            // 
            this.LblLabelStart.AutoSize = true;
            this.LblLabelStart.Location = new System.Drawing.Point(4, 4);
            this.LblLabelStart.Name = "LblLabelStart";
            this.LblLabelStart.Size = new System.Drawing.Size(82, 13);
            this.LblLabelStart.TabIndex = 0;
            this.LblLabelStart.Text = "LblLabelStart";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchMenu2});
            this.contextMenuStrip.Name = "MenuBotaoDireito";
            this.contextMenuStrip.Size = new System.Drawing.Size(110, 26);
            // 
            // searchMenu2
            // 
            this.searchMenu2.Name = "searchMenu2";
            this.searchMenu2.Size = new System.Drawing.Size(109, 22);
            this.searchMenu2.Text = "Search";
            this.searchMenu2.Visible = false;
            // 
            // DynamicSearchF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 384);
            this.Controls.Add(this.PnlPanel3);
            this.Controls.Add(this.PnlPanel2);
            this.Controls.Add(this.PnlPanel1);
            this.Controls.Add(this.PnlPanel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DynamicSearchF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterF_FormClosing);
            this.Shown += new System.EventHandler(this.FilterF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterF_KeyDown);
            this.PnlPanel1.ResumeLayout(false);
            this.PnlPanel2.ResumeLayout(false);
            this.PnlPanel2.PerformLayout();
            this.PnlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSearch)).EndInit();
            this.PnlPanel4.ResumeLayout(false);
            this.PnlPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDValue)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPanel1;
        private System.Windows.Forms.Panel PnlPanel2;
        private System.Windows.Forms.Panel PnlPanel3;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView DGVSearch;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnOrder;
        public System.Windows.Forms.Label LblDescription;
        public System.Windows.Forms.TextBox TxBDescription;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Panel PnlPanel4;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Label LblLabelEnd;
        private System.Windows.Forms.Label LblLabelStart;
        private System.Windows.Forms.Button BtnWanted;
        private System.Windows.Forms.TextBox TxBWanted;
        private System.Windows.Forms.TextBox TxBIdWanted;
        private System.Windows.Forms.NumericUpDown NUDValue;
        private System.Windows.Forms.MaskedTextBox MkBMask;
        private System.Windows.Forms.CheckBox CkBCheckBox;
        private System.Windows.Forms.Button BtnIndeterminate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem searchMenu2;


    }
}