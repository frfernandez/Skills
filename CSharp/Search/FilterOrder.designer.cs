namespace Search
{
    partial class DynamicSearchOrderF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicSearchOrderF));
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.GBxOrderType = new System.Windows.Forms.GroupBox();
            this.RBtDescendent = new System.Windows.Forms.RadioButton();
            this.RBtAscendent = new System.Windows.Forms.RadioButton();
            this.PnlColumns = new System.Windows.Forms.Panel();
            this.TxBDescription = new System.Windows.Forms.TextBox();
            this.DGVColumns = new System.Windows.Forms.DataGridView();
            this.TTpTip = new System.Windows.Forms.ToolTip(this.components);
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PnlOrders = new System.Windows.Forms.Panel();
            this.DGVOrders = new System.Windows.Forms.DataGridView();
            this.PnlButtons.SuspendLayout();
            this.GBxOrderType.SuspendLayout();
            this.PnlColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColumns)).BeginInit();
            this.PnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnExit);
            this.PnlButtons.Controls.Add(this.BtnDown);
            this.PnlButtons.Controls.Add(this.BtnUp);
            this.PnlButtons.Controls.Add(this.BtnRemove);
            this.PnlButtons.Controls.Add(this.BtnAdd);
            this.PnlButtons.Controls.Add(this.BtnCancel);
            this.PnlButtons.Controls.Add(this.BtnConfirm);
            this.PnlButtons.Controls.Add(this.GBxOrderType);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlButtons.Location = new System.Drawing.Point(0, 0);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(763, 54);
            this.PnlButtons.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(560, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(93, 50);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "&Exit";
            this.TTpTip.SetToolTip(this.BtnExit, "Back to the prior form");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Location = new System.Drawing.Point(467, 3);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(93, 50);
            this.BtnDown.TabIndex = 5;
            this.BtnDown.TabStop = false;
            this.BtnDown.Tag = "";
            this.BtnDown.Text = "D&own";
            this.TTpTip.SetToolTip(this.BtnDown, "Sets the column name one line below");
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Location = new System.Drawing.Point(375, 3);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(93, 50);
            this.BtnUp.TabIndex = 4;
            this.BtnUp.TabStop = false;
            this.BtnUp.Tag = "";
            this.BtnUp.Text = "&Up";
            this.TTpTip.SetToolTip(this.BtnUp, "Sets the column name one line above");
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(282, 3);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(93, 50);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.TabStop = false;
            this.BtnRemove.Text = "&Remove";
            this.TTpTip.SetToolTip(this.BtnRemove, "Remove the column name in the order");
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(189, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 50);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.Text = "&Add";
            this.TTpTip.SetToolTip(this.BtnAdd, "Add the column name in the order");
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(96, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(93, 50);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.TabStop = false;
            this.BtnCancel.Text = "Ca&ncel";
            this.TTpTip.SetToolTip(this.BtnCancel, "Cancel the order configuration");
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(3, 3);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(93, 50);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.TabStop = false;
            this.BtnConfirm.Text = "&Confirm";
            this.TTpTip.SetToolTip(this.BtnConfirm, "Confirm the order configuration");
            this.BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // GBxOrderType
            // 
            this.GBxOrderType.Controls.Add(this.RBtDescendent);
            this.GBxOrderType.Controls.Add(this.RBtAscendent);
            this.GBxOrderType.Dock = System.Windows.Forms.DockStyle.Right;
            this.GBxOrderType.Location = new System.Drawing.Point(656, 0);
            this.GBxOrderType.Name = "GBxOrderType";
            this.GBxOrderType.Size = new System.Drawing.Size(107, 54);
            this.GBxOrderType.TabIndex = 7;
            this.GBxOrderType.TabStop = false;
            this.GBxOrderType.Text = "Order Type";
            this.TTpTip.SetToolTip(this.GBxOrderType, "Sets the column order");
            // 
            // RBtDescendent
            // 
            this.RBtDescendent.AutoSize = true;
            this.RBtDescendent.Location = new System.Drawing.Point(6, 34);
            this.RBtDescendent.Name = "RBtDescendent";
            this.RBtDescendent.Size = new System.Drawing.Size(93, 17);
            this.RBtDescendent.TabIndex = 1;
            this.RBtDescendent.Text = "&Descendent";
            this.TTpTip.SetToolTip(this.RBtDescendent, "Z..A, 9..0");
            this.RBtDescendent.UseVisualStyleBackColor = true;
            // 
            // RBtAscendent
            // 
            this.RBtAscendent.AutoSize = true;
            this.RBtAscendent.Checked = true;
            this.RBtAscendent.Location = new System.Drawing.Point(6, 13);
            this.RBtAscendent.Name = "RBtAscendent";
            this.RBtAscendent.Size = new System.Drawing.Size(85, 17);
            this.RBtAscendent.TabIndex = 0;
            this.RBtAscendent.TabStop = true;
            this.RBtAscendent.Text = "A&scendent";
            this.TTpTip.SetToolTip(this.RBtAscendent, "A..Z, 0..9");
            this.RBtAscendent.UseVisualStyleBackColor = true;
            // 
            // PnlColumns
            // 
            this.PnlColumns.Controls.Add(this.TxBDescription);
            this.PnlColumns.Controls.Add(this.DGVColumns);
            this.PnlColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlColumns.Location = new System.Drawing.Point(0, 54);
            this.PnlColumns.Name = "PnlColumns";
            this.PnlColumns.Size = new System.Drawing.Size(763, 150);
            this.PnlColumns.TabIndex = 2;
            // 
            // TxBDescription
            // 
            this.TxBDescription.Location = new System.Drawing.Point(3, 6);
            this.TxBDescription.Name = "TxBDescription";
            this.TxBDescription.Size = new System.Drawing.Size(100, 20);
            this.TxBDescription.TabIndex = 1;
            this.TxBDescription.Visible = false;
            // 
            // DGVColumns
            // 
            this.DGVColumns.AllowUserToAddRows = false;
            this.DGVColumns.AllowUserToDeleteRows = false;
            this.DGVColumns.AllowUserToResizeColumns = false;
            this.DGVColumns.AllowUserToResizeRows = false;
            this.DGVColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVColumns.Location = new System.Drawing.Point(0, 0);
            this.DGVColumns.MultiSelect = false;
            this.DGVColumns.Name = "DGVColumns";
            this.DGVColumns.ReadOnly = true;
            this.DGVColumns.RowHeadersWidth = 25;
            this.DGVColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVColumns.Size = new System.Drawing.Size(763, 150);
            this.DGVColumns.TabIndex = 0;
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Confirm-");
            this.Images.Images.SetKeyName(1, "Confirm+");
            this.Images.Images.SetKeyName(2, "Cancel-");
            this.Images.Images.SetKeyName(3, "Cancel+");
            this.Images.Images.SetKeyName(4, "Add-");
            this.Images.Images.SetKeyName(5, "Add+");
            this.Images.Images.SetKeyName(6, "Remove-");
            this.Images.Images.SetKeyName(7, "Remove+");
            this.Images.Images.SetKeyName(8, "Down-");
            this.Images.Images.SetKeyName(9, "Down+");
            this.Images.Images.SetKeyName(10, "Up-");
            this.Images.Images.SetKeyName(11, "Up+");
            this.Images.Images.SetKeyName(12, "Exit-");
            this.Images.Images.SetKeyName(13, "Exit+");
            // 
            // PnlOrders
            // 
            this.PnlOrders.Controls.Add(this.DGVOrders);
            this.PnlOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlOrders.Location = new System.Drawing.Point(0, 204);
            this.PnlOrders.Name = "PnlOrders";
            this.PnlOrders.Size = new System.Drawing.Size(763, 150);
            this.PnlOrders.TabIndex = 3;
            // 
            // DGVOrders
            // 
            this.DGVOrders.AllowUserToAddRows = false;
            this.DGVOrders.AllowUserToDeleteRows = false;
            this.DGVOrders.AllowUserToResizeColumns = false;
            this.DGVOrders.AllowUserToResizeRows = false;
            this.DGVOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOrders.Location = new System.Drawing.Point(0, 0);
            this.DGVOrders.MultiSelect = false;
            this.DGVOrders.Name = "DGVOrders";
            this.DGVOrders.ReadOnly = true;
            this.DGVOrders.RowHeadersWidth = 25;
            this.DGVOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVOrders.Size = new System.Drawing.Size(763, 150);
            this.DGVOrders.TabIndex = 0;
            this.DGVOrders.Click += new System.EventHandler(this.DGVOrders_Click);
            this.DGVOrders.DoubleClick += new System.EventHandler(this.BtnRemove_Click);
            // 
            // DynamicSearchOrderF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 354);
            this.Controls.Add(this.PnlOrders);
            this.Controls.Add(this.PnlColumns);
            this.Controls.Add(this.PnlButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DynamicSearchOrderF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Search - Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilterOrderF_FormClosing);
            this.Shown += new System.EventHandler(this.FilterOrderF_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterOrderF_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FilterOrderF_KeyUp);
            this.PnlButtons.ResumeLayout(false);
            this.GBxOrderType.ResumeLayout(false);
            this.GBxOrderType.PerformLayout();
            this.PnlColumns.ResumeLayout(false);
            this.PnlColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColumns)).EndInit();
            this.PnlOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Panel PnlColumns;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DGVColumns;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnRemove;
        public System.Windows.Forms.RadioButton RBtDescendent;
        public System.Windows.Forms.RadioButton RBtAscendent;
        public System.Windows.Forms.GroupBox GBxOrderType;
        private System.Windows.Forms.ToolTip TTpTip;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Panel PnlOrders;
        private System.Windows.Forms.DataGridView DGVOrders;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.TextBox TxBDescription;
        private System.Windows.Forms.Button BtnCancel;


    }
}