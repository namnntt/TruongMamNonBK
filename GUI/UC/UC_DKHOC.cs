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
using GUI.RePort;

namespace GUI.UC
{
    public partial class UC_DKHOC : DevExpress.XtraEditors.XtraUserControl
    {
        
        string MaHocSinh = "null";
        DataTable dthsldk = new DataTable();
        DataRowView hs;


        private static UC_DKHOC _instance;
        public static UC_DKHOC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_DKHOC();
                return _instance;
            }
        }
        public UC_DKHOC()
        {
            InitializeComponent();
        }

        private void UC_DKHOC_Load(object sender, EventArgs e)
        {

            onload();

        }
        public void onload()
        {
            adgvHocSinhDuDK.AutoGenerateColumns = true;
            adgvHocSinhDuDK.FilterAndSortEnabled = true;
            adgvHocSinhDuDK.DisableFilterAndSort(clHSSTT);
            DataTable dt = HocSinhServices.LayDanhSachHocSinh();
            bdHocSinhDuDieuKien.DataSource = dt;
            if (adgvHocSinhDuDK.Columns.Count == 10)
            {
                adgvHocSinhDuDK.Columns["NgaySinh"].DisplayIndex = 4;
                adgvHocSinhDuDK.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                adgvHocSinhDuDK.Columns["NgayNhapHoc"].HeaderText = "Ngày Nhập học";
                adgvSearchBar.SetColumns(adgvHocSinhDuDK.Columns);
            }
        }
        #region Display STT columns
        private void adgvDanhSachLop_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvDanhSachLop.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }

        private void adgvHocSinhDuDK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvHocSinhDuDK.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }
        #endregion

        private void btnPickStd_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in adgvHocSinhDuDK.SelectedRows)
            {
                MaHocSinh = row.Cells[1].Value.ToString();
            }
            bdLopDangKy.DataSource = LopDangKyServices.LayDanhSachLopDangKy(MaHocSinh);
            adgvDanhSachLop.DisableFilterAndSort(clLDKSTT);
            adgvDanhSachLop.DisableFilterAndSort(clCheckBoxers);
            dthsldk = LopDangKyServices.LayDanhCacLopDangKyCuaMotHocSinh(MaHocSinh);
            hs = bdHocSinhDuDieuKien.Current as DataRowView;
            if (dthsldk.Rows.Count > 0)
            {
                btnChiTietHoaDon.Enabled = true;
                btnChiTietDangKy.Enabled = true;

            }
            else {
                btnChiTietHoaDon.Enabled = false;
                btnChiTietDangKy.Enabled = false;
            }

            if (bdLopDangKy.Count == 0) { btnDangKyHoc.Enabled = false; }
            else btnDangKyHoc.Enabled = true;
           
        }
        #region Thanh Tìm kiếm 
        private void adgvSearchBar_Search(object sender, Zuby.ADGV.AdvancedDataGridViewSearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = adgvHocSinhDuDK.CurrentCell.ColumnIndex + 1 >= adgvHocSinhDuDK.ColumnCount;
                bool endrow = adgvHocSinhDuDK.CurrentCell.RowIndex + 1 >= adgvHocSinhDuDK.RowCount;

                if (endcol && endrow)
                {
                    startColumn = adgvHocSinhDuDK.CurrentCell.ColumnIndex;
                    startRow = adgvHocSinhDuDK.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : adgvHocSinhDuDK.CurrentCell.ColumnIndex + 1;
                    startRow = adgvHocSinhDuDK.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = adgvHocSinhDuDK.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = adgvHocSinhDuDK.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                adgvHocSinhDuDK.CurrentCell = c;
        }
        #endregion

        //Thực hiện đăng ký học cho học sinh
        private void btnDangKyHoc_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in adgvDanhSachLop.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells["clCheckBoxers"].Value) == true
                                                  select row).ToList();
            string result = "";
            foreach (DataGridViewRow row in selectedRows)
            {
                if (row.Visible == true)
                {
                    DangKyHocServices.DangKyHoc(MaHocSinh, row.Cells[2].Value.ToString());
                    result += ("Mã Lớp: " + row.Cells[2].Value.ToString() + "\n" + "Tên Lớp: " + row.Cells[3].Value.ToString() + "\n" + "-----------------------------------\n");
                }
            }
            if (selectedRows.Count > 0)
            {
                MessageBox.Show($"Đăng ký cho {MaHocSinh} thành công các lớp: \n {result}");
                btnPickStd.PerformClick();
                onload();
                UC_GiaHanDKHoc.Instance.onload();
                UC_HuyDKHoc.Instance.onload();
                btnChiTietHoaDon.Enabled = true;
            }
            //else btnChiTietHoaDon.Enabled = false;
        }
        //Lọc danh sách các lớp trong khi chọn
        private void adgvDanhSachLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (adgvDanhSachLop.Columns[e.ColumnIndex].Name == "clCheckBoxers")
            {
                if (Convert.ToBoolean(adgvDanhSachLop.Rows[e.RowIndex].Cells[1].EditedFormattedValue) == true)
                {
                    foreach(DataGridViewRow row in adgvDanhSachLop.Rows)
                    {
                        if(row.Cells[5].Value.ToString() == adgvDanhSachLop.Rows[e.RowIndex].Cells[5].Value.ToString() ||
                            (row.Cells[8].Value.ToString() == adgvDanhSachLop.Rows[e.RowIndex].Cells[8].Value.ToString() && row.Cells[3].Value.ToString() == adgvDanhSachLop.Rows[e.RowIndex].Cells[3].Value.ToString()))
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[adgvDanhSachLop.DataSource];
                            currencyManager1.SuspendBinding();
                            row.Visible = false;
                            adgvDanhSachLop.Rows[e.RowIndex].Visible = true;
                            currencyManager1.ResumeBinding();
                        }
                    }

                }
                else
                {
                    foreach (DataGridViewRow row in adgvDanhSachLop.Rows)
                    {
                        if (row.Cells[5].Value.ToString() == adgvDanhSachLop.Rows[e.RowIndex].Cells[5].Value.ToString() ||
                            (row.Cells[8].Value.ToString() == adgvDanhSachLop.Rows[e.RowIndex].Cells[8].Value.ToString() && row.Cells[3].Value.ToString() == adgvDanhSachLop.Rows[e.RowIndex].Cells[3].Value.ToString()))
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[adgvDanhSachLop.DataSource];
                            currencyManager1.SuspendBinding();
                            row.Visible = true;
                            adgvDanhSachLop.Rows[e.RowIndex].Visible = true;
                            currencyManager1.ResumeBinding();
                        }
                    }
                }

            }
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            
            DataTable hd = HoaDonServices.LayDanhSachHoaDonTheoMaHocSinh(hs["MaHS"].ToString());
            if (dthsldk.Rows.Count > 0)
            {
                using (frmHoaDon frm = new frmHoaDon(dthsldk, hs, hd))
                {
                    frm.ShowDialog();
                }
                
            }
        }

        private void btnChiTietDangKy_Click(object sender, EventArgs e)
        {
            

            if (dthsldk.Rows.Count > 0)
            {
                using (frmChiTietDangKy frm = new frmChiTietDangKy(dthsldk, hs))
                {
                    frm.ShowDialog();
                }

            }
        }
    }
}