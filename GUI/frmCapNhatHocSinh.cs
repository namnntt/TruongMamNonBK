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
using BussinesLayer;
using GUI.UC;

namespace GUI
{
    public partial class frmCapNhatHocSinh : DevExpress.XtraEditors.XtraForm
    {
        string _TenLopHC = null;
        string _MaHocSinh = null;
        public frmCapNhatHocSinh(string TenLopHC, string MaHocSinh)
        {
            _TenLopHC = TenLopHC;
            _MaHocSinh = MaHocSinh;
            InitializeComponent();
        }

        private void frmCapNhatHocSinh_Load(object sender, EventArgs e)
        {
            onload();
            
        }
        public void onload()
        {
            cbLopHC.DataSource = LopHCServices.LayDanhSachLopHanhChinh();
            cbLopHC.DisplayMember = "TenLopHC";
            cbLopHC.ValueMember = "MaLopHC";
            if (!string.IsNullOrEmpty(_TenLopHC))
            {
                cbLopHC.SelectedIndex = cbLopHC.FindStringExact(_TenLopHC);
            }
        }

        private void btnThemHS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiaChi.Text) || !string.IsNullOrEmpty(txtSDTLienHe.Text) || !string.IsNullOrEmpty(txtTenChaMe.Text) || !string.IsNullOrEmpty(txtTenHS.Text))
            {
                HocSinhServices.ThemHocSinhVaoHeThong(txtTenHS.Text, datNgaySinh.Value, txtTenChaMe.Text, txtSDTLienHe.Text, txtDiaChi.Text, cbLopHC.SelectedValue.ToString());
                UC_CapNhatHocSinh.Instance.onload();
                UC_DKHOC.Instance.onload();
                MessageBox.Show("Thêm thành công");
                txtTenHS.Clear();
                txtDiaChi.Clear();
                txtSDTLienHe.Clear();
                txtTenChaMe.Clear();
            }
            else MessageBox.Show("Không được Có trường bị để trống");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int change = 0;
            if (!string.IsNullOrEmpty(txtDiaChi.Text) || !string.IsNullOrEmpty(txtSDTLienHe.Text) || !string.IsNullOrEmpty(txtTenChaMe.Text) || !string.IsNullOrEmpty(txtTenHS.Text))
            {
                change = HocSinhServices.UpdateTTHocSinh(_MaHocSinh, txtTenHS.Text, datNgaySinh.Value, txtTenChaMe.Text, txtSDTLienHe.Text, txtDiaChi.Text, cbLopHC.SelectedValue.ToString());
                
            }
            else
            {
                MessageBox.Show("các trường không được để trống");
            }
            if (change == 0)
            {
                MessageBox.Show("Không có thông tin nào mới để cập nhật");
            }
            else
            {
                UC_CapNhatHocSinh.Instance.onload();
                UC_DKHOC.Instance.onload();
                MessageBox.Show("Đã cập nhật thành công");
            }
        }
    }
}