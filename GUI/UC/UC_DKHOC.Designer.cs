namespace GUI.UC
{
    partial class UC_DKHOC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adgvDanhSachLop = new Zuby.ADGV.AdvancedDataGridView();
            this.clLDKSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaLopDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLopDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenCLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdLopDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.btnchonLop = new DevExpress.XtraEditors.SimpleButton();
            this.adgvHocSinhDuDK = new Zuby.ADGV.AdvancedDataGridView();
            this.clHSSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLopHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenChaMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdHocSinhDuDieuKien = new System.Windows.Forms.BindingSource(this.components);
            this.btnDangKyHoc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.adgvDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvHocSinhDuDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinhDuDieuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvDanhSachLop
            // 
            this.adgvDanhSachLop.AllowUserToAddRows = false;
            this.adgvDanhSachLop.AllowUserToDeleteRows = false;
            this.adgvDanhSachLop.AllowUserToResizeRows = false;
            this.adgvDanhSachLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvDanhSachLop.AutoGenerateColumns = false;
            this.adgvDanhSachLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvDanhSachLop.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvDanhSachLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clLDKSTT,
            this.clMaLopDangKy,
            this.clTenLopDangKy,
            this.clNamHoc,
            this.clLichHoc,
            this.clTenCLB,
            this.clHocPhi,
            this.CLB});
            this.adgvDanhSachLop.DataSource = this.bdLopDangKy;
            this.adgvDanhSachLop.FilterAndSortEnabled = true;
            this.adgvDanhSachLop.Location = new System.Drawing.Point(28, 29);
            this.adgvDanhSachLop.MultiSelect = false;
            this.adgvDanhSachLop.Name = "adgvDanhSachLop";
            this.adgvDanhSachLop.RowHeadersVisible = false;
            this.adgvDanhSachLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvDanhSachLop.Size = new System.Drawing.Size(833, 177);
            this.adgvDanhSachLop.TabIndex = 0;
            this.adgvDanhSachLop.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adgvDanhSachLop_RowPostPaint);
            // 
            // clLDKSTT
            // 
            this.clLDKSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clLDKSTT.HeaderText = "STT";
            this.clLDKSTT.MinimumWidth = 22;
            this.clLDKSTT.Name = "clLDKSTT";
            this.clLDKSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clLDKSTT.Width = 50;
            // 
            // clMaLopDangKy
            // 
            this.clMaLopDangKy.DataPropertyName = "MaLopDangKy";
            this.clMaLopDangKy.HeaderText = "Mã Lớp Đăng Ký";
            this.clMaLopDangKy.MinimumWidth = 22;
            this.clMaLopDangKy.Name = "clMaLopDangKy";
            this.clMaLopDangKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenLopDangKy
            // 
            this.clTenLopDangKy.DataPropertyName = "TenLopDangKy";
            this.clTenLopDangKy.HeaderText = "Tên Lớp Đăng Ký";
            this.clTenLopDangKy.MinimumWidth = 22;
            this.clTenLopDangKy.Name = "clTenLopDangKy";
            this.clTenLopDangKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clNamHoc
            // 
            this.clNamHoc.DataPropertyName = "NamHoc";
            this.clNamHoc.HeaderText = "Năm Học";
            this.clNamHoc.MinimumWidth = 22;
            this.clNamHoc.Name = "clNamHoc";
            this.clNamHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clLichHoc
            // 
            this.clLichHoc.DataPropertyName = "LichHoc";
            this.clLichHoc.HeaderText = "Lịch Học";
            this.clLichHoc.MinimumWidth = 22;
            this.clLichHoc.Name = "clLichHoc";
            this.clLichHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenCLB
            // 
            this.clTenCLB.DataPropertyName = "TenCLB";
            this.clTenCLB.HeaderText = "Tên CLB";
            this.clTenCLB.MinimumWidth = 22;
            this.clTenCLB.Name = "clTenCLB";
            this.clTenCLB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clHocPhi
            // 
            this.clHocPhi.DataPropertyName = "HocPhi";
            this.clHocPhi.HeaderText = "Học Phí";
            this.clHocPhi.MinimumWidth = 22;
            this.clHocPhi.Name = "clHocPhi";
            this.clHocPhi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CLB
            // 
            this.CLB.DataPropertyName = "CLB";
            this.CLB.HeaderText = "CLB";
            this.CLB.MinimumWidth = 22;
            this.CLB.Name = "CLB";
            this.CLB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CLB.Visible = false;
            // 
            // btnchonLop
            // 
            this.btnchonLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnchonLop.Location = new System.Drawing.Point(398, 212);
            this.btnchonLop.Name = "btnchonLop";
            this.btnchonLop.Size = new System.Drawing.Size(75, 23);
            this.btnchonLop.TabIndex = 1;
            this.btnchonLop.Text = "Chọn Lớp";
            this.btnchonLop.Click += new System.EventHandler(this.btnchonLop_Click);
            // 
            // adgvHocSinhDuDK
            // 
            this.adgvHocSinhDuDK.AllowUserToAddRows = false;
            this.adgvHocSinhDuDK.AllowUserToDeleteRows = false;
            this.adgvHocSinhDuDK.AllowUserToResizeRows = false;
            this.adgvHocSinhDuDK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvHocSinhDuDK.AutoGenerateColumns = false;
            this.adgvHocSinhDuDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adgvHocSinhDuDK.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvHocSinhDuDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvHocSinhDuDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHSSTT,
            this.clCheckBox,
            this.clMaHS,
            this.clTenHS,
            this.clTenLopHC,
            this.clDiaChi,
            this.clTenChaMe,
            this.clSDT});
            this.adgvHocSinhDuDK.DataSource = this.bdHocSinhDuDieuKien;
            this.adgvHocSinhDuDK.FilterAndSortEnabled = true;
            this.adgvHocSinhDuDK.Location = new System.Drawing.Point(37, 251);
            this.adgvHocSinhDuDK.MultiSelect = false;
            this.adgvHocSinhDuDK.Name = "adgvHocSinhDuDK";
            this.adgvHocSinhDuDK.RowHeadersVisible = false;
            this.adgvHocSinhDuDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adgvHocSinhDuDK.Size = new System.Drawing.Size(824, 172);
            this.adgvHocSinhDuDK.TabIndex = 2;
            this.adgvHocSinhDuDK.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.adgvHocSinhDuDK_SortStringChanged);
            this.adgvHocSinhDuDK.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.adgvHocSinhDuDK_FilterStringChanged);
            this.adgvHocSinhDuDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgvHocSinhDuDK_CellContentClick);
            this.adgvHocSinhDuDK.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.adgvHocSinhDuDK_RowPostPaint);
            // 
            // clHSSTT
            // 
            this.clHSSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clHSSTT.HeaderText = "STT";
            this.clHSSTT.MinimumWidth = 22;
            this.clHSSTT.Name = "clHSSTT";
            this.clHSSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clHSSTT.Width = 50;
            // 
            // clCheckBox
            // 
            this.clCheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clCheckBox.HeaderText = "Chọn";
            this.clCheckBox.MinimumWidth = 22;
            this.clCheckBox.Name = "clCheckBox";
            this.clCheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.clCheckBox.Width = 57;
            // 
            // clMaHS
            // 
            this.clMaHS.DataPropertyName = "MaHS";
            this.clMaHS.HeaderText = "Mã HS";
            this.clMaHS.MinimumWidth = 22;
            this.clMaHS.Name = "clMaHS";
            this.clMaHS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            dataGridViewCellStyle2.NullValue = "(Trống)";
            this.clDiaChi.DefaultCellStyle = dataGridViewCellStyle2;
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.MinimumWidth = 22;
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clTenChaMe
            // 
            this.clTenChaMe.DataPropertyName = "TenChaMe";
            this.clTenChaMe.HeaderText = "Tên cha mẹ";
            this.clTenChaMe.MinimumWidth = 22;
            this.clTenChaMe.Name = "clTenChaMe";
            this.clTenChaMe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "SDTChaMe";
            this.clSDT.HeaderText = "SDT Cha Mẹ";
            this.clSDT.MinimumWidth = 22;
            this.clSDT.Name = "clSDT";
            this.clSDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnDangKyHoc
            // 
            this.btnDangKyHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKyHoc.Location = new System.Drawing.Point(398, 438);
            this.btnDangKyHoc.Name = "btnDangKyHoc";
            this.btnDangKyHoc.Size = new System.Drawing.Size(75, 23);
            this.btnDangKyHoc.TabIndex = 3;
            this.btnDangKyHoc.Text = "Đăng Ký Học";
            this.btnDangKyHoc.Click += new System.EventHandler(this.btnDangKyHoc_Click);
            // 
            // UC_DKHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDangKyHoc);
            this.Controls.Add(this.adgvHocSinhDuDK);
            this.Controls.Add(this.btnchonLop);
            this.Controls.Add(this.adgvDanhSachLop);
            this.Name = "UC_DKHOC";
            this.Size = new System.Drawing.Size(917, 477);
            this.Load += new System.EventHandler(this.UC_DKHOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvDanhSachLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdLopDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvHocSinhDuDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinhDuDieuKien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView adgvDanhSachLop;
        private System.Windows.Forms.BindingSource bdLopDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLDKSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLopDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLopDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHocPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLB;
        private DevExpress.XtraEditors.SimpleButton btnchonLop;
        private Zuby.ADGV.AdvancedDataGridView adgvHocSinhDuDK;
        private System.Windows.Forms.BindingSource bdHocSinhDuDieuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHSSTT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLopHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenChaMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private DevExpress.XtraEditors.SimpleButton btnDangKyHoc;
    }
}
