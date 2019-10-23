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
using System.IO;
using ExcelDataReader;
using Model;
using BussinesLayer;

namespace GUI
{
    public partial class frmExcelHS : DevExpress.XtraEditors.XtraForm
    {
        public frmExcelHS()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void btnfindFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (opfDexcel.ShowDialog() == DialogResult.OK)
                {
                    txtLink.Text = opfDexcel.FileName;
                    using (var stream = File.Open(opfDexcel.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            tableCollection = result.Tables;
                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cbSheet.Items.Add(table.TableName);//add sheet to combobox
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = tableCollection[cbSheet.SelectedItem.ToString()];
            string[] columnNames = dt.Columns.Cast<DataColumn>()
                                 .Select(x => x.ColumnName)
                                 .ToArray();
            if (columnNames.Length != 6 || string.Compare(columnNames[0], "Tên Học Sinh", true) != 0 || string.Compare(columnNames[1], "Ngày Sinh", true) != 0 || string.Compare(columnNames[2], "Tên cha mẹ", true) != 0 ||
                string.Compare(columnNames[3], "SĐT Cha Mẹ", true) != 0 || string.Compare(columnNames[4], "Địa chỉ", true) != 0 || string.Compare(columnNames[5], "Lớp hành chính", true) != 0)
            {
                MessageBox.Show("Định dạng bảng không phù hợp");
            }
            else
            {
                bdExcell.DataSource = dt;
                clTenHS.FieldName = columnNames[0];
                clNgaySinh.FieldName = columnNames[1];
                clTenChaMe.FieldName = columnNames[2];
                clSDTChaMe.FieldName = columnNames[3];
                clAddress.FieldName = columnNames[4];
                clLopHC.FieldName = columnNames[5];
            }
        }

        private void btnSaveDataBase_Click(object sender, EventArgs e)
        {
            List<LopHanhChinh> dsLop = LopHCServices.LayDanhSachLopHanhChinh();
            Firt: Int32[] Firstcheck = gridView1.GetSelectedRows();
            check:  Int32[] selectedrowHandles = gridView1.GetSelectedRows();
            if(selectedrowHandles.Length > 0)
            {
                for(int i =0; i<selectedrowHandles.Length; i++)
                {
                    int selectRownHandle = selectedrowHandles[i];
                    DataRow gv = gridView1.GetDataRow(selectRownHandle);
                    string MaLopHC = null;
                    foreach (LopHanhChinh temp in dsLop)
                    {
                        if (string.Compare(gv[5].ToString(), temp.TenLopHC, true) == 0)
                        {
                            MaLopHC = temp.MaLopHC;
                            break;
                            
                        }
                        else
                        {
                            gridView1.UnselectRow(i);
                            goto check;
                        }
                    }
                    if(!string.IsNullOrEmpty(MaLopHC))
                    {
                        HocSinhServices.ThemHocSinhVaoHeThong(gv[0].ToString(), Convert.ToDateTime(gv[1].ToString()), gv[2].ToString(), gv[3].ToString(), gv[4].ToString(), MaLopHC);
                        gridView1.DeleteRow(i);
                    }
                    
                }
                if (selectedrowHandles.Length < Firstcheck.Length)
                {
                    MessageBox.Show($"Đã thêm thành công dữ liệu ngoại trừ một số record còn lại không đúng tên lớp Hành chính bạn có thể sửa lại cho đúng rồi thực hiện lại");
                    goto Firt;
                }
                else
                {
                    MessageBox.Show("thêm thành công toàn bộ dữ liệu");
                }
                
            }
            else
            {
                MessageBox.Show("Mời bạn chọn các row cần thêm vào CSDL");
            }
        }
    }
}