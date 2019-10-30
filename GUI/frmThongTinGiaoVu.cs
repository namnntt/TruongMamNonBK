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
using Model;
using BussinesLayer;

namespace GUI
{
    public partial class frmThongTinGiaoVu : DevExpress.XtraEditors.XtraForm
    {
        GiaoVu _gv = new GiaoVu();
        public frmThongTinGiaoVu(GiaoVu gv)
        {
            _gv = gv;
            InitializeComponent();
        }

        private void frmThongTinGiaoVu_Load(object sender, EventArgs e)
        {
            txtEmail.Text = _gv.Email;
            txtTaiKhoan.Text = _gv.TaiKhoan;
            txtTenGiaovu.Text = _gv.TenGiaoVu;
            txtSDT.Text = _gv.DienThoai;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int change = 0;
            change = AccountServices.ThayDoiThongTinTaiKhoan(_gv.MaGV, txtTenGiaovu.Text, txtSDT.Text, txtEmail.Text, txtTaiKhoan.Text);
            if(change > 0)
            {
                MessageBox.Show($"Đã cập nhật thành công cho Giáo vụ có Mã {_gv.MaGV}");
                
            }
        }
    }
}