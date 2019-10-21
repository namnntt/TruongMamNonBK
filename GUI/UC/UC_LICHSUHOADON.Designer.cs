namespace GUI.UC
{
    partial class UC_LICHSUHOADON
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
            this.dtpDuLieuHoaDon = new System.Windows.Forms.DateTimePicker();
            this.btnLoadDataHD = new DevExpress.XtraEditors.SimpleButton();
            this.gdcDuLieuHoaDon = new DevExpress.XtraGrid.GridControl();
            this.bdHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clMaHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNhapHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clLopHC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TThocphi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuongLopDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTongHocPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDuLieuHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDuLieuHoaDon
            // 
            this.dtpDuLieuHoaDon.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.dtpDuLieuHoaDon.CustomFormat = "MM/yyyy";
            this.dtpDuLieuHoaDon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDuLieuHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuLieuHoaDon.Location = new System.Drawing.Point(565, 34);
            this.dtpDuLieuHoaDon.Name = "dtpDuLieuHoaDon";
            this.dtpDuLieuHoaDon.Size = new System.Drawing.Size(93, 25);
            this.dtpDuLieuHoaDon.TabIndex = 0;
            // 
            // btnLoadDataHD
            // 
            this.btnLoadDataHD.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDataHD.Appearance.Options.UseFont = true;
            this.btnLoadDataHD.ImageOptions.Image = global::GUI.Properties.Resources.load_data_icon;
            this.btnLoadDataHD.Location = new System.Drawing.Point(691, 27);
            this.btnLoadDataHD.Name = "btnLoadDataHD";
            this.btnLoadDataHD.Size = new System.Drawing.Size(112, 40);
            this.btnLoadDataHD.TabIndex = 1;
            this.btnLoadDataHD.Text = "Load Data";
            this.btnLoadDataHD.Click += new System.EventHandler(this.btnLoadDataHD_Click);
            // 
            // gdcDuLieuHoaDon
            // 
            this.gdcDuLieuHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcDuLieuHoaDon.DataSource = this.bdHoaDon;
            this.gdcDuLieuHoaDon.Location = new System.Drawing.Point(34, 128);
            this.gdcDuLieuHoaDon.MainView = this.gridView1;
            this.gdcDuLieuHoaDon.Name = "gdcDuLieuHoaDon";
            this.gdcDuLieuHoaDon.Size = new System.Drawing.Size(1048, 342);
            this.gdcDuLieuHoaDon.TabIndex = 2;
            this.gdcDuLieuHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.SelectedRow.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.SelectedRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaHD,
            this.clMaHS,
            this.clHocSinh,
            this.clNgaySinh,
            this.clNhapHoc,
            this.clLopHC,
            this.TThocphi,
            this.clSoLuongLopDK,
            this.clTongHocPhi});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gdcDuLieuHoaDon;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // clMaHD
            // 
            this.clMaHD.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaHD.AppearanceCell.Options.UseFont = true;
            this.clMaHD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaHD.AppearanceHeader.Options.UseFont = true;
            this.clMaHD.Caption = "Mã HĐ";
            this.clMaHD.FieldName = "MaHoaDon";
            this.clMaHD.Name = "clMaHD";
            this.clMaHD.Visible = true;
            this.clMaHD.VisibleIndex = 0;
            this.clMaHD.Width = 76;
            // 
            // clMaHS
            // 
            this.clMaHS.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaHS.AppearanceCell.Options.UseFont = true;
            this.clMaHS.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaHS.AppearanceHeader.Options.UseFont = true;
            this.clMaHS.Caption = "Mã HS";
            this.clMaHS.FieldName = "MaHocSinh";
            this.clMaHS.Name = "clMaHS";
            this.clMaHS.Visible = true;
            this.clMaHS.VisibleIndex = 1;
            this.clMaHS.Width = 69;
            // 
            // clHocSinh
            // 
            this.clHocSinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clHocSinh.AppearanceCell.Options.UseFont = true;
            this.clHocSinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clHocSinh.AppearanceHeader.Options.UseFont = true;
            this.clHocSinh.Caption = "Tên HS";
            this.clHocSinh.FieldName = "TenHocSinh";
            this.clHocSinh.Name = "clHocSinh";
            this.clHocSinh.Visible = true;
            this.clHocSinh.VisibleIndex = 2;
            this.clHocSinh.Width = 217;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgaySinh.AppearanceCell.Options.UseFont = true;
            this.clNgaySinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgaySinh.AppearanceHeader.Options.UseFont = true;
            this.clNgaySinh.Caption = "Ngày Sinh";
            this.clNgaySinh.DisplayFormat.FormatString = "d";
            this.clNgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.clNgaySinh.FieldName = "NgaySinhCuaHS";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Visible = true;
            this.clNgaySinh.VisibleIndex = 3;
            this.clNgaySinh.Width = 114;
            // 
            // clNhapHoc
            // 
            this.clNhapHoc.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNhapHoc.AppearanceCell.Options.UseFont = true;
            this.clNhapHoc.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNhapHoc.AppearanceHeader.Options.UseFont = true;
            this.clNhapHoc.Caption = "Ngày Nhập Học";
            this.clNhapHoc.FieldName = "NgayNhapHocCuaHS";
            this.clNhapHoc.Name = "clNhapHoc";
            this.clNhapHoc.Visible = true;
            this.clNhapHoc.VisibleIndex = 4;
            this.clNhapHoc.Width = 126;
            // 
            // clLopHC
            // 
            this.clLopHC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLopHC.AppearanceCell.Options.UseFont = true;
            this.clLopHC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLopHC.AppearanceHeader.Options.UseFont = true;
            this.clLopHC.Caption = "Tên Lớp HC";
            this.clLopHC.FieldName = "TenLopHanhChinh";
            this.clLopHC.Name = "clLopHC";
            this.clLopHC.Visible = true;
            this.clLopHC.VisibleIndex = 5;
            this.clLopHC.Width = 120;
            // 
            // TThocphi
            // 
            this.TThocphi.Caption = "TT Học Phí";
            this.TThocphi.FieldName = "TinhTrangHocPhi";
            this.TThocphi.Name = "TThocphi";
            // 
            // clSoLuongLopDK
            // 
            this.clSoLuongLopDK.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoLuongLopDK.AppearanceCell.Options.UseFont = true;
            this.clSoLuongLopDK.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSoLuongLopDK.AppearanceHeader.Options.UseFont = true;
            this.clSoLuongLopDK.Caption = "Số lượng lớp ĐK";
            this.clSoLuongLopDK.FieldName = "SoluongLopDangKy";
            this.clSoLuongLopDK.Name = "clSoLuongLopDK";
            this.clSoLuongLopDK.Visible = true;
            this.clSoLuongLopDK.VisibleIndex = 6;
            this.clSoLuongLopDK.Width = 138;
            // 
            // clTongHocPhi
            // 
            this.clTongHocPhi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTongHocPhi.AppearanceCell.Options.UseFont = true;
            this.clTongHocPhi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTongHocPhi.AppearanceHeader.Options.UseFont = true;
            this.clTongHocPhi.Caption = "Tổng học phí";
            this.clTongHocPhi.FieldName = "TongHocPhi";
            this.clTongHocPhi.Name = "clTongHocPhi";
            this.clTongHocPhi.Visible = true;
            this.clTongHocPhi.VisibleIndex = 7;
            this.clTongHocPhi.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hóa đơn của Tháng";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = global::GUI.Properties.Resources.printer_32x321;
            this.btnPrint.Location = new System.Drawing.Point(665, 476);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(138, 39);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "In Hóa Đơn";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExport.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.ImageOptions.Image = global::GUI.Properties.Resources.excell_icon;
            this.btnExport.Location = new System.Drawing.Point(444, 476);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(138, 39);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Xuất ra Excell";
            // 
            // UC_LICHSUHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdcDuLieuHoaDon);
            this.Controls.Add(this.btnLoadDataHD);
            this.Controls.Add(this.dtpDuLieuHoaDon);
            this.Name = "UC_LICHSUHOADON";
            this.Size = new System.Drawing.Size(1108, 547);
            this.Load += new System.EventHandler(this.UC_LICHSUHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcDuLieuHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDuLieuHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnLoadDataHD;
        private DevExpress.XtraGrid.GridControl gdcDuLieuHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn clMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn clMaHS;
        private DevExpress.XtraGrid.Columns.GridColumn clHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn clNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn clNhapHoc;
        private DevExpress.XtraGrid.Columns.GridColumn clLopHC;
        private DevExpress.XtraGrid.Columns.GridColumn TThocphi;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuongLopDK;
        private DevExpress.XtraGrid.Columns.GridColumn clTongHocPhi;
        private System.Windows.Forms.BindingSource bdHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}
