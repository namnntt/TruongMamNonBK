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
            bdLopdaDangKy.DataSource = _dt;
            DateTime dat = (DateTime)_hs["NgaySinh"];
            txtMaHs.Text = _hs["MaHS"].ToString();
            txtTenHS.Text = _hs["TenHS"].ToString();
            txtTenLopHC.Text = _hs["TenLopHC"].ToString();
            txtNamSinh.Text = dat.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            //txtTenHS.Text = _hs.TenHS;
            //txtTenLopHC.Text = _hs.TenLopHC;
            //txtNamSinh.Text = _hs.NgaySinh.ToString("dd/MM/yyyy");
        }
    }
}