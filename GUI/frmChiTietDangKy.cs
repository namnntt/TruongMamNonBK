using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GUI.RePort;
using System.Globalization;
using BussinesLayer;
using GUI.UC;

namespace GUI
{
    public partial class frmChiTietDangKy : DevExpress.XtraEditors.XtraForm
    {
        DataRowView _hs;
        DataTable _dt;

        public frmChiTietDangKy(DataTable dt, DataRowView hs)
        {
            _hs = hs;
            _dt = dt;
            InitializeComponent();
        }

        private void frmChiTietDangKy_Load(object sender, EventArgs e)
        {
            onload();
        }
        public void onload()
        {
            bdLopdaDangKy.DataSource = _dt;
            DateTime dat = (DateTime)_hs["NgaySinh"];
            txtMaHs.Text = _hs["MaHS"].ToString();
            txtTenHS.Text = _hs["TenHS"].ToString();
            txtTenLopHC.Text = _hs["TenLopHC"].ToString();
            txtNamSinh.Text = dat.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            adgvDanhSachLopDangDangKy.DisableFilterAndSort(clCheck);
            adgvDanhSachLopDangDangKy.DisableFilterAndSort(clSTT);
            //txtTenHS.Text = _hs.TenHS;
            //txtTenLopHC.Text = _hs.TenLopHC;
            //txtNamSinh.Text = _hs.NgaySinh.ToString("dd/MM/yyyy");
        }
        private void btnHUyDangKy_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in adgvDanhSachLopDangDangKy.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells["clCheck"].Value) == true
                                                  select row).ToList();
            foreach (DataGridViewRow row in selectedRows)
            {
                DangKyHocServices.HuyDangKyhoc(txtMaHs.Text, row.Cells[2].Value.ToString());
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[adgvDanhSachLopDangDangKy.DataSource];
                currencyManager1.SuspendBinding();
                row.Visible = false;
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["clCheck"];
                chk.Value = chk.FalseValue;
                currencyManager1.ResumeBinding();
            }
            if (selectedRows.Count > 0)
            {
                MessageBox.Show($"Hủy Thành công {selectedRows.Count.ToString()} Lớp");
                UC_DKHOC.Instance.btnPickStd.PerformClick();
                UC_GiaHanDKHoc.Instance.onload();
                UC_HuyDKHoc.Instance.onload();
                UC_HuyDKHoc.Instance.btnPickStd.PerformClick();


            }
        }

        private void adgvDanhSachLopDangDangKy_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            adgvDanhSachLopDangDangKy.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}