namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMDangKyHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyDK = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaHanDangKyHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLichSuHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhapTTHS = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnMDangKyHoc,
            this.btnHuyDK,
            this.btnGiaHanDangKyHoc,
            this.btnShowHoaDon,
            this.barButtonItem4,
            this.btnLichSuHoaDon,
            this.btnCapNhapTTHS});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1267, 162);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // btnMDangKyHoc
            // 
            this.btnMDangKyHoc.Caption = "Đăng Ký học";
            this.btnMDangKyHoc.Id = 1;
            this.btnMDangKyHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMDangKyHoc.ImageOptions.Image")));
            this.btnMDangKyHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMDangKyHoc.ImageOptions.LargeImage")));
            this.btnMDangKyHoc.Name = "btnMDangKyHoc";
            this.btnMDangKyHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMDangKyHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMDangKyHoc_ItemClick_1);
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.Caption = "Hủy Đăng ký Học";
            this.btnHuyDK.Id = 2;
            this.btnHuyDK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDK.ImageOptions.Image")));
            this.btnHuyDK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyDK.ImageOptions.LargeImage")));
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHuyDK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyDK_ItemClick);
            // 
            // btnGiaHanDangKyHoc
            // 
            this.btnGiaHanDangKyHoc.Caption = "Gia Hạn Đăng ký";
            this.btnGiaHanDangKyHoc.Id = 3;
            this.btnGiaHanDangKyHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaHanDangKyHoc.ImageOptions.Image")));
            this.btnGiaHanDangKyHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGiaHanDangKyHoc.ImageOptions.LargeImage")));
            this.btnGiaHanDangKyHoc.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate;
            this.btnGiaHanDangKyHoc.Name = "btnGiaHanDangKyHoc";
            this.btnGiaHanDangKyHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGiaHanDangKyHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiaHanDangKyHoc_ItemClick);
            // 
            // btnShowHoaDon
            // 
            this.btnShowHoaDon.Id = 6;
            this.btnShowHoaDon.Name = "btnShowHoaDon";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thống kê";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ImageOptions.Image = global::GUI.Properties.Resources.Chart_icon;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnLichSuHoaDon
            // 
            this.btnLichSuHoaDon.Caption = "Lịch Sử Hóa Đơn";
            this.btnLichSuHoaDon.Id = 7;
            this.btnLichSuHoaDon.ImageOptions.Image = global::GUI.Properties.Resources.bii_history_icon;
            this.btnLichSuHoaDon.Name = "btnLichSuHoaDon";
            this.btnLichSuHoaDon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLichSuHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLichSuHoaDon_ItemClick);
            // 
            // btnCapNhapTTHS
            // 
            this.btnCapNhapTTHS.Caption = "Cập nhật thông tin học sinh";
            this.btnCapNhapTTHS.Id = 8;
            this.btnCapNhapTTHS.ImageOptions.Image = global::GUI.Properties.Resources.student_icon;
            this.btnCapNhapTTHS.Name = "btnCapNhapTTHS";
            this.btnCapNhapTTHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.Image = global::GUI.Properties.Resources.register_manager_icon;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý Đăng ký Học";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMDangKyHoc);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHuyDK);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGiaHanDangKyHoc);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Cập nhập Đăng ký học";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLichSuHoaDon);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hóa Đơn Học Phí";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = global::GUI.Properties.Resources.student_mamager_icon;
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản Lý Học Sinh";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCapNhapTTHS);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Học Sinh";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản Lý Tài Khoản";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Quản Lý các CLB";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Quản Lý Các Lớp CLB";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 719);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Thu Học Phí Trường mầm non Bách Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnMDangKyHoc;
        private DevExpress.XtraBars.BarButtonItem btnHuyDK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnGiaHanDangKyHoc;
        private DevExpress.XtraBars.BarButtonItem btnShowHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnLichSuHoaDon;
        private DevExpress.XtraBars.BarButtonItem btnCapNhapTTHS;
    }
}

