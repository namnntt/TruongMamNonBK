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
    public partial class UC_LICHSUHOADON : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_LICHSUHOADON _instance;
        public static UC_LICHSUHOADON Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_LICHSUHOADON();
                return _instance;
            }
        }
        public UC_LICHSUHOADON()
        {
            InitializeComponent();
        }
        public void onload()
        {
            
        }

        private void UC_LICHSUHOADON_Load(object sender, EventArgs e)
        {

        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            e.DisplayText = e.RowHandle.ToString();
        }

        private void btnLoadDataHD_Click(object sender, EventArgs e)
        {
            bdHoaDon.DataSource = HoaDonServices.LayDanhSachHoaDonTheoNamvaThang(dtpDuLieuHoaDon.Value.Year, dtpDuLieuHoaDon.Value.Month);
        }
    }
}
