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
    public partial class UC_DKHOC : DevExpress.XtraEditors.XtraUserControl
    {
        CheckBox headerCheckBox = new CheckBox();
        string MaLopDangKy = "null";
        
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
            adgvDanhSachLop.AutoGenerateColumns = false;
            adgvDanhSachLop.FilterAndSortEnabled = true;
            adgvHocSinhDuDK.DisableFilterAndSort(adgvHocSinhDuDK.Columns["clHSSTT"]);
            adgvHocSinhDuDK.DisableFilterAndSort(adgvHocSinhDuDK.Columns["clCheckBox"]);
            adgvDanhSachLop.DisableFilterAndSort(clLDKSTT);
            adgvDanhSachLop.DisableFilterAndSort(clMaLopDangKy);
            adgvDanhSachLop.DisableFilterAndSort(clTenLopDangKy);
            adgvDanhSachLop.DisableFilterAndSort(clHocPhi);

  
            DataTable dt = LopDangKyServices.LayDanhSachLopDangKy();
            bdLopDangKy.DataSource = dt;
            AddCheckbox();

        }
        #region Add All Check Box
        private void AddCheckbox()
        {
            Point headerCellLocation = this.adgvHocSinhDuDK.GetCellDisplayRectangle(1, -1, true).Location;
            //Place the Header CheckBox in the Location of the Header Cell.
            headerCheckBox.Location = new Point(headerCellLocation.X + 35, headerCellLocation.Y + 2);
            headerCheckBox.BackColor = clCheckBox.DefaultCellStyle.BackColor;
            headerCheckBox.Size = new Size(15,15);
            headerCheckBox.Click += HeaderCheckBox_Click;
            adgvHocSinhDuDK.Controls.Add(headerCheckBox);
        }

        private void HeaderCheckBox_Click(object sender, EventArgs e)
        {
            //Necessary to end the edit mode of the Cell.
            adgvHocSinhDuDK.EndEdit();

            //Loop and check and uncheck all row CheckBoxes based on Header Cell CheckBox.
            foreach (DataGridViewRow row in adgvHocSinhDuDK.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells["clCheckBox"] as DataGridViewCheckBoxCell);
                checkBox.Value = headerCheckBox.Checked;
            }
        }
        private void adgvHocSinhDuDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check to ensure that the row CheckBox is clicked.
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //Loop to verify whether all row CheckBoxes are checked or not.
                bool isChecked = true;
                foreach (DataGridViewRow row in adgvHocSinhDuDK.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["clCheckBox"].EditedFormattedValue) == false)
                    {
                        isChecked = false;
                        break;
                    }
                }
                headerCheckBox.Checked = isChecked;
            }
        }
        #endregion

        private void adgvDanhSachLop_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvDanhSachLop.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }

        private void adgvHocSinhDuDK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            adgvHocSinhDuDK.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString(); //Display columns STT
        }

        private void btnchonLop_Click(object sender, EventArgs e)
        {
            adgvHocSinhDuDK.CleanFilterAndSort();
            headerCheckBox.Checked = false;
            string TenLop = "Null"; string MaCLB = "Null"; int LichHoc = 3;
            adgvHocSinhDuDK.AutoGenerateColumns = true;
            if (adgvDanhSachLop.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in adgvDanhSachLop.SelectedRows)
                {
                    TenLop = row.Cells[2].Value.ToString();
                    MaCLB = row.Cells[7].Value.ToString();
                    LichHoc = (int)row.Cells[4].Value;
                }
                DataTable dt = HocSinhServices.LayHocSinhTheoLopDangKy(TenLop, MaCLB, LichHoc);
                bdHocSinhDuDieuKien.DataSource = dt;
                adgvHocSinhDuDK.Columns["NgaySinh"].DisplayIndex = 3;
                adgvHocSinhDuDK.SetFilterDateAndTimeEnabled(adgvHocSinhDuDK.Columns[3], true);
                adgvHocSinhDuDK.Columns[3].HeaderText = "Ngày sinh";
                adgvHocSinhDuDK.Columns["NgayNhapHoc"].DefaultCellStyle.Format = "d";
                adgvHocSinhDuDK.Columns["NgayNhapHoc"].HeaderText = "Nhập học";
                foreach (DataGridViewRow row in adgvDanhSachLop.SelectedRows)
                {
                    MaLopDangKy = row.Cells[1].Value.ToString();
                }
                
            }
            
        }

        private void adgvHocSinhDuDK_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            headerCheckBox.Checked = false;
        }

        private void adgvHocSinhDuDK_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            headerCheckBox.Checked = false;
        }

        private void btnDangKyHoc_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectedRows = (from row in adgvHocSinhDuDK.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells["clCheckBox"].Value) == true
                                                  select row).ToList();
            foreach (DataGridViewRow row in selectedRows)
            {
                DangKyHocServices.DangKyHoc(row.Cells[2].Value.ToString(), MaLopDangKy);
            }
            if (selectedRows.Count > 0)
            {
                MessageBox.Show($"Đăng ký thành công cho {selectedRows.Count.ToString()} học sinh");
                btnchonLop.PerformClick();
                UC_HuyDKHoc.Instance.onload();
                
            }
        }
    }
}