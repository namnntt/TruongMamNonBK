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
    public partial class UC_HoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_HoaDon _instance;
        public static UC_HoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_HoaDon();
                return _instance;
            }
        }
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            advancedDataGridView1.AutoGenerateColumns = true;
            bdHoaDon.DataSource = HoaDonServices.LayDanhSachHoaDonTheoNamvaThang(2019, 10);
        }
    }
}
