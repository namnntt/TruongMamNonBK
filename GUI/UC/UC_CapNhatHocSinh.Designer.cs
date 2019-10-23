﻿namespace GUI.UC
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
            this.btnAddHocSinh = new DevExpress.XtraEditors.SimpleButton();
            this.bdHocSinh = new System.Windows.Forms.BindingSource(this.components);
            this.gcdHocSinh = new DevExpress.XtraGrid.GridControl();
            this.gridViewHocSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaHs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenHocSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clLopHanhChinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenChaMe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSDTChaMe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNgayNhapHoc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddHocSinh
            // 
            this.btnAddHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddHocSinh.ImageOptions.Image = global::GUI.Properties.Resources.add_32x32;
            this.btnAddHocSinh.Location = new System.Drawing.Point(459, 474);
            this.btnAddHocSinh.Name = "btnAddHocSinh";
            this.btnAddHocSinh.Size = new System.Drawing.Size(119, 49);
            this.btnAddHocSinh.TabIndex = 1;
            this.btnAddHocSinh.Text = "Thêm Học Sinh";
            this.btnAddHocSinh.Click += new System.EventHandler(this.btnAddHocSinh_Click);
            // 
            // gcdHocSinh
            // 
            this.gcdHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcdHocSinh.DataSource = this.bdHocSinh;
            this.gcdHocSinh.Location = new System.Drawing.Point(21, 67);
            this.gcdHocSinh.MainView = this.gridViewHocSinh;
            this.gcdHocSinh.Name = "gcdHocSinh";
            this.gcdHocSinh.Size = new System.Drawing.Size(977, 383);
            this.gcdHocSinh.TabIndex = 2;
            this.gcdHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHocSinh});
            // 
            // gridViewHocSinh
            // 
            this.gridViewHocSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaHs,
            this.clTenHocSinh,
            this.clNgaySinh,
            this.clLopHanhChinh,
            this.clDiaChi,
            this.clTenChaMe,
            this.clSDTChaMe,
            this.clNgayNhapHoc});
            this.gridViewHocSinh.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewHocSinh.GridControl = this.gcdHocSinh;
            this.gridViewHocSinh.Name = "gridViewHocSinh";
            this.gridViewHocSinh.OptionsBehavior.Editable = false;
            this.gridViewHocSinh.OptionsFind.AlwaysVisible = true;
            this.gridViewHocSinh.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewHocSinh.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewHocSinh.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewHocSinh.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewHocSinh.OptionsView.ShowGroupPanel = false;
            this.gridViewHocSinh.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewHocSinh_CustomDrawRowIndicator);
            this.gridViewHocSinh.RowCountChanged += new System.EventHandler(this.gridViewHocSinh_RowCountChanged);
            // 
            // clMaHs
            // 
            this.clMaHs.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaHs.AppearanceCell.Options.UseFont = true;
            this.clMaHs.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clMaHs.AppearanceHeader.Options.UseFont = true;
            this.clMaHs.Caption = "Mã HS";
            this.clMaHs.FieldName = "MaHS";
            this.clMaHs.Name = "clMaHs";
            this.clMaHs.Visible = true;
            this.clMaHs.VisibleIndex = 0;
            this.clMaHs.Width = 83;
            // 
            // clTenHocSinh
            // 
            this.clTenHocSinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenHocSinh.AppearanceCell.Options.UseFont = true;
            this.clTenHocSinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenHocSinh.AppearanceHeader.Options.UseFont = true;
            this.clTenHocSinh.Caption = "Tên Học Sinh";
            this.clTenHocSinh.FieldName = "TenHS";
            this.clTenHocSinh.Name = "clTenHocSinh";
            this.clTenHocSinh.Visible = true;
            this.clTenHocSinh.VisibleIndex = 1;
            this.clTenHocSinh.Width = 146;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgaySinh.AppearanceCell.Options.UseFont = true;
            this.clNgaySinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgaySinh.AppearanceHeader.Options.UseFont = true;
            this.clNgaySinh.Caption = "Ngày Sinh";
            this.clNgaySinh.FieldName = "NgaySinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Visible = true;
            this.clNgaySinh.VisibleIndex = 2;
            this.clNgaySinh.Width = 124;
            // 
            // clLopHanhChinh
            // 
            this.clLopHanhChinh.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLopHanhChinh.AppearanceCell.Options.UseFont = true;
            this.clLopHanhChinh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLopHanhChinh.AppearanceHeader.Options.UseFont = true;
            this.clLopHanhChinh.Caption = "Lớp Hành chính";
            this.clLopHanhChinh.FieldName = "TenLopHC";
            this.clLopHanhChinh.Name = "clLopHanhChinh";
            this.clLopHanhChinh.Visible = true;
            this.clLopHanhChinh.VisibleIndex = 3;
            this.clLopHanhChinh.Width = 112;
            // 
            // clDiaChi
            // 
            this.clDiaChi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clDiaChi.AppearanceCell.Options.UseFont = true;
            this.clDiaChi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clDiaChi.AppearanceHeader.Options.UseFont = true;
            this.clDiaChi.Caption = "Địa chỉ";
            this.clDiaChi.FieldName = "DiaChi";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Visible = true;
            this.clDiaChi.VisibleIndex = 4;
            this.clDiaChi.Width = 144;
            // 
            // clTenChaMe
            // 
            this.clTenChaMe.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenChaMe.AppearanceCell.Options.UseFont = true;
            this.clTenChaMe.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTenChaMe.AppearanceHeader.Options.UseFont = true;
            this.clTenChaMe.Caption = "Tên Cha Mẹ";
            this.clTenChaMe.FieldName = "TenChaMe";
            this.clTenChaMe.Name = "clTenChaMe";
            this.clTenChaMe.Visible = true;
            this.clTenChaMe.VisibleIndex = 5;
            this.clTenChaMe.Width = 134;
            // 
            // clSDTChaMe
            // 
            this.clSDTChaMe.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSDTChaMe.AppearanceCell.Options.UseFont = true;
            this.clSDTChaMe.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clSDTChaMe.AppearanceHeader.Options.UseFont = true;
            this.clSDTChaMe.Caption = "SĐT Cha mẹ";
            this.clSDTChaMe.FieldName = "SDTChaMe";
            this.clSDTChaMe.Name = "clSDTChaMe";
            this.clSDTChaMe.Visible = true;
            this.clSDTChaMe.VisibleIndex = 6;
            this.clSDTChaMe.Width = 102;
            // 
            // clNgayNhapHoc
            // 
            this.clNgayNhapHoc.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgayNhapHoc.AppearanceCell.Options.UseFont = true;
            this.clNgayNhapHoc.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clNgayNhapHoc.AppearanceHeader.Options.UseFont = true;
            this.clNgayNhapHoc.Caption = "Nhập học";
            this.clNgayNhapHoc.FieldName = "NgayNhapHoc";
            this.clNgayNhapHoc.Name = "clNgayNhapHoc";
            this.clNgayNhapHoc.Visible = true;
            this.clNgayNhapHoc.VisibleIndex = 7;
            this.clNgayNhapHoc.Width = 99;
            // 
            // UC_CapNhatHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcdHocSinh);
            this.Controls.Add(this.btnAddHocSinh);
            this.Name = "UC_CapNhatHocSinh";
            this.Size = new System.Drawing.Size(1034, 548);
            this.Load += new System.EventHandler(this.UC_CapNhatHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAddHocSinh;
        private System.Windows.Forms.BindingSource bdHocSinh;
        private DevExpress.XtraGrid.GridControl gcdHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn clMaHs;
        private DevExpress.XtraGrid.Columns.GridColumn clTenHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn clNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn clLopHanhChinh;
        private DevExpress.XtraGrid.Columns.GridColumn clDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn clTenChaMe;
        private DevExpress.XtraGrid.Columns.GridColumn clSDTChaMe;
        private DevExpress.XtraGrid.Columns.GridColumn clNgayNhapHoc;
    }
}
