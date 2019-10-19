namespace GUI.UC
{
    partial class UC_CapNhatHocSinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.adgvdsHocSinh = new Zuby.ADGV.AdvancedDataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLopHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltenChaMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddHocSinh = new DevExpress.XtraEditors.SimpleButton();
            this.adgvSearchHocSinh = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            ((System.ComponentModel.ISupportInitialize)(this.adgvdsHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvdsHocSinh
            // 
            this.adgvdsHocSinh.AllowUserToAddRows = false;
            this.adgvdsHocSinh.AllowUserToDeleteRows = false;
            this.adgvdsHocSinh.AllowUserToResizeRows = false;
            this.adgvdsHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvdsHocSinh.AutoGenerateColumns = false;
            this.adgvdsHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvdsHocSinh.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvdsHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvdsHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clMaHS,
            this.clTenHS,
            this.clTenLopHC,
            this.clDiaChi,
            this.cltenChaMe,
            this.clSDT});
            this.adgvdsHocSinh.DataSource = this.bdHocSinh;
            this.adgvdsHocSinh.FilterAndSortEnabled = true;
            this.adgvdsHocSinh.Location = new System.Drawing.Point(45, 94);
            this.adgvdsHocSinh.Name = "adgvdsHocSinh";
            this.adgvdsHocSinh.RowHeadersVisible = false;
            this.adgvdsHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvdsHocSinh.Size = new System.Drawing.Size(930, 363);
            this.adgvdsHocSinh.TabIndex = 0;
            this.adgvdsHocSinh.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adgvdsHocSinh_RowPostPaint);
            // 
            // clSTT
            // 
            this.clSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clSTT.HeaderText = "STT";
            this.clSTT.MinimumWidth = 22;
            this.clSTT.Name = "clSTT";
            this.clSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clSTT.Width = 50;
            // 
            // clMaHS
            // 
            this.clMaHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clMaHS.DataPropertyName = "MaHS";
            this.clMaHS.HeaderText = "Mã HS";
            this.clMaHS.MinimumWidth = 22;
            this.clMaHS.Name = "clMaHS";
            this.clMaHS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clMaHS.Width = 62;
            // 
            // clTenHS
            // 
            this.clTenHS.DataPropertyName = "TenHS";
            this.clTenHS.HeaderText = "Tên HS";
            this.clTenHS.MinimumWidth = 22;
            this.clTenHS.Name = "clTenHS";
            this.clTenHS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenLopHC
            // 
            this.clTenLopHC.DataPropertyName = "TenLopHC";
            this.clTenLopHC.HeaderText = "Tên Lớp HC";
            this.clTenLopHC.MinimumWidth = 22;
            this.clTenLopHC.Name = "clTenLopHC";
            this.clTenLopHC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clDiaChi
            // 
            this.clDiaChi.DataPropertyName = "DiaChi";
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.MinimumWidth = 22;
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cltenChaMe
            // 
            this.cltenChaMe.DataPropertyName = "TenChaMe";
            this.cltenChaMe.HeaderText = "Tên Cha Mẹ";
            this.cltenChaMe.MinimumWidth = 22;
            this.cltenChaMe.Name = "cltenChaMe";
            this.cltenChaMe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "SDTChaMe";
            this.clSDT.HeaderText = "SĐT Liên hệ";
            this.clSDT.MinimumWidth = 22;
            this.clSDT.Name = "clSDT";
            this.clSDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnAddHocSinh
            // 
            this.btnAddHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddHocSinh.ImageOptions.Image = global::GUI.Properties.Resources.add_32x32;
            this.btnAddHocSinh.Location = new System.Drawing.Point(425, 473);
            this.btnAddHocSinh.Name = "btnAddHocSinh";
            this.btnAddHocSinh.Size = new System.Drawing.Size(119, 49);
            this.btnAddHocSinh.TabIndex = 1;
            this.btnAddHocSinh.Text = "Thêm Học Sinh";
            this.btnAddHocSinh.Click += new System.EventHandler(this.btnAddHocSinh_Click);
            // 
            // adgvSearchHocSinh
            // 
            this.adgvSearchHocSinh.AllowMerge = false;
            this.adgvSearchHocSinh.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.adgvSearchHocSinh.Location = new System.Drawing.Point(0, 0);
            this.adgvSearchHocSinh.MaximumSize = new System.Drawing.Size(0, 27);
            this.adgvSearchHocSinh.MinimumSize = new System.Drawing.Size(0, 27);
            this.adgvSearchHocSinh.Name = "adgvSearchHocSinh";
            this.adgvSearchHocSinh.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.adgvSearchHocSinh.Size = new System.Drawing.Size(1034, 27);
            this.adgvSearchHocSinh.TabIndex = 2;
            this.adgvSearchHocSinh.Text = "advancedDataGridViewSearchToolBar1";
            // 
            // UC_CapNhatHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adgvSearchHocSinh);
            this.Controls.Add(this.btnAddHocSinh);
            this.Controls.Add(this.adgvdsHocSinh);
            this.Name = "UC_CapNhatHocSinh";
            this.Size = new System.Drawing.Size(1034, 548);
            this.Load += new System.EventHandler(this.UC_CapNhatHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvdsHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView adgvdsHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLopHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenChaMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private DevExpress.XtraEditors.SimpleButton btnAddHocSinh;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar adgvSearchHocSinh;
        private System.Windows.Forms.BindingSource bdHocSinh;
    }
}
