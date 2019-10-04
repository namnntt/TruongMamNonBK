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
    public partial class UC_HuyDKHoc : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_HuyDKHoc _instance;
        public static UC_HuyDKHoc Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_HuyDKHoc();
                return _instance;
            }
        }
        public UC_HuyDKHoc()
        {
            InitializeComponent();
        }

        private void UC_HuyDKHoc_Load(object sender, EventArgs e)
        {
            onload();
        }
        public void onload()
        {
            adgvLopDangKyH.AutoGenerateColumns = true;
            bddsLopTheoHS.DataSource = LopDangKyServices.cacLopcoHocSinhdangKy();
            
        }
    }
}
