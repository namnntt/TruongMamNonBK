namespace GUI.UC
{
    partial class UC_LICHSUHOADON
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnLoadDataHD = new DevExpress.XtraEditors.SimpleButton();
            this.gdcDuLieuHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDuLieuHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnLoadDataHD
            // 
            this.btnLoadDataHD.Location = new System.Drawing.Point(546, 54);
            this.btnLoadDataHD.Name = "btnLoadDataHD";
            this.btnLoadDataHD.Size = new System.Drawing.Size(136, 40);
            this.btnLoadDataHD.TabIndex = 1;
            this.btnLoadDataHD.Text = "Load Dữ Liệu HĐ";
            // 
            // gdcDuLieuHoaDon
            // 
            this.gdcDuLieuHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcDuLieuHoaDon.Location = new System.Drawing.Point(34, 128);
            this.gdcDuLieuHoaDon.MainView = this.gridView1;
            this.gdcDuLieuHoaDon.Name = "gdcDuLieuHoaDon";
            this.gdcDuLieuHoaDon.Size = new System.Drawing.Size(961, 385);
            this.gdcDuLieuHoaDon.TabIndex = 2;
            this.gdcDuLieuHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gdcDuLieuHoaDon;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // UC_LICHSUHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdcDuLieuHoaDon);
            this.Controls.Add(this.btnLoadDataHD);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "UC_LICHSUHOADON";
            this.Size = new System.Drawing.Size(1021, 529);
            ((System.ComponentModel.ISupportInitialize)(this.gdcDuLieuHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton btnLoadDataHD;
        private DevExpress.XtraGrid.GridControl gdcDuLieuHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
