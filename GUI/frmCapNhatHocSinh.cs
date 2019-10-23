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
        public frmCapNhatHocSinh()
        {
            InitializeComponent();
        }

        private void frmCapNhatHocSinh_Load(object sender, EventArgs e)
        {
            cbLopHC.DataSource = LopHCServices.LayDanhSachLopHanhChinh();
            cbLopHC.DisplayMember = "TenLopHC";
            cbLopHC.ValueMember = "MaLopHC";
            
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
    }
}