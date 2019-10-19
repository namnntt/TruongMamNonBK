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
    public partial class UC_CapNhatHocSinh : DevExpress.XtraEditors.XtraUserControl
    {
        DataGridViewRow lastSelected;
        private static UC_CapNhatHocSinh _instance;
        public static UC_CapNhatHocSinh Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_CapNhatHocSinh();
                return _instance;
            }
        }
        public UC_CapNhatHocSinh()
        {
            InitializeComponent();
        }

        private void btnAddHocSinh_Click(object sender, EventArgs e)
        {
            
            using (frmCapNhatHocSinh frm = new frmCapNhatHocSinh())
            {
                frm.ShowDialog();
            }
        }
        public void onload()
        {
            adgvdsHocSinh.DisableFilterAndSort(clSTT);
            adgvdsHocSinh.AutoGenerateColumns = true;
            bdHocSinh.DataSource = HocSinhServices.LayDanhSachHocSinh();
            adgvdsHocSinh.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            adgvdsHocSinh.Columns["NgaySinh"].DisplayIndex = 4;
            adgvdsHocSinh.Columns["NgayNhapHoc"].HeaderText = "Nhập học";
            adgvSearchHocSinh.SetColumns(adgvdsHocSinh.Columns);
            
        }
        private void UC_CapNhatHocSinh_Load(object sender, EventArgs e)
        {
            onload();
        }

        private void adgvdsHocSinh_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvdsHocSinh.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }

       
    }
}
