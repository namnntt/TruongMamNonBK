using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BussinesLayer;

namespace GUI.UC
{
    public partial class UC_DKHOC : DevExpress.XtraEditors.XtraUserControl
    {
        CheckBox headerCheckBox = new CheckBox();

        private static UC_DKHOC _instance;
        public static UC_DKHOC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_DKHOC();
                return _instance;
            }
        }
        public UC_DKHOC()
        {
            InitializeComponent();

        }

        private void UC_DKHOC_Load(object sender, EventArgs e)
        {
            adgvDanhSachLop.AutoGenerateColumns = false;
            adgvDanhSachLop.FilterAndSortEnabled = true;
            adgvHocSinhDuDK.DisableFilterAndSort(adgvHocSinhDuDK.Columns["clHSSTT"]);
            adgvHocSinhDuDK.DisableFilterAndSort(adgvHocSinhDuDK.Columns["clCheckBox"]);
            adgvDanhSachLop.DisableFilterAndSort(clLDKSTT);
            adgvDanhSachLop.DisableFilterAndSort(clMaLopDangKy);
            adgvDanhSachLop.DisableFilterAndSort(clTenLopDangKy);
            adgvDanhSachLop.DisableFilterAndSort(clHocPhi);

  
            DataTable dt = LopDangKyServices.LayDanhSachLopDangKy();
            bdLopDangKy.DataSource = dt;

        }
        private void adgvDanhSachLop_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvDanhSachLop.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }

        private void adgvHocSinhDuDK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvHocSinhDuDK.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }

        private void btnchonLop_Click(object sender, EventArgs e)
        {
            string TenLop = "Null"; string MaCLB = "Null"; int LichHoc = 3;
            adgvHocSinhDuDK.AutoGenerateColumns = true;
            if (adgvDanhSachLop.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in adgvDanhSachLop.SelectedRows)
                {
                    TenLop = row.Cells[2].Value.ToString();
                    MaCLB = row.Cells[7].Value.ToString();
                    LichHoc = (int)row.Cells[4].Value;
                }
                DataTable dt = HocSinhServices.LayHocSinhTheoLopDangKy(TenLop, MaCLB, LichHoc);
                bdHocSinhDuDieuKien.DataSource = dt;

                adgvHocSinhDuDK.SetFilterDateAndTimeEnabled(adgvHocSinhDuDK.Columns[3], true);
                adgvHocSinhDuDK.Columns["NgaySinh"].DisplayIndex = 3;
                adgvHocSinhDuDK.Columns[3].HeaderText = "Ngày sinh";
                adgvHocSinhDuDK.Columns["NgayNhapHoc"].DefaultCellStyle.Format = "d";
                adgvHocSinhDuDK.Columns["NgayNhapHoc"].HeaderText = "Nhập học";
            }
        }
    }
}