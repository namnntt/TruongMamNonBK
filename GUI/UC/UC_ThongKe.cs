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
using DevExpress.XtraCharts;

namespace GUI.UC
{
    public partial class UC_ThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_ThongKe _instance;
        public static UC_ThongKe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ThongKe();
                return _instance;
            }
        }
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void btnDuLieu_Click(object sender, EventArgs e)
        {
            if (cbChart.SelectedIndex == 0)
            {
                chrBaoCaoSoLuongDangky.Series["Số Lượng đăng ký"].DataSource = LopDangKyServices.DanhsachLopDangKyVaSoHocSinh(datdrawrtChart.Value.Year, datdrawrtChart.Value.Month);
                chrBaoCaoSoLuongDangky.Series["Số Lượng đăng ký"].ArgumentScaleType = ScaleType.Auto;
                chrBaoCaoSoLuongDangky.Series["Số Lượng đăng ký"].ArgumentDataMember = "TenLopDangKy";
                chrBaoCaoSoLuongDangky.Series["Số Lượng đăng ký"].ValueDataMembers.AddRange(new string[] { "Count" });
                //ChartTitle chartTitle1 = new ChartTitle();
                //chartTitle1.Text = $"Báo cáo thống kế số lượng đăng ký theo lớp trong tháng {datdrawrtChart.Value.Month.ToString()}/{datdrawrtChart.Value.Year.ToString()}";
                //chrBaoCaoSoLuongDangky.Titles.Add(chartTitle1);
            }

            // Set some properties to get a nice-looking chart. 
            //((SideBySideBarSeriesView)chrBaoCaoSoLuongDangky.Series["Số Lượng đăng ký"].View).ColorEach = true;
            //((XYDiagram)chrBaoCaoSoLuongDangky.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            //chrBaoCaoSoLuongDangky.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;





        }
    }
}
