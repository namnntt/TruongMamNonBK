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
            this.dtpDuLieuHoaDon = new System.Windows.Forms.DateTimePicker();
            this.btnLoadDataHD = new DevExpress.XtraEditors.SimpleButton();
            this.gdcDuLieuHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDuLieuHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDuLieuHoaDon
            // 
            this.dtpDuLieuHoaDon.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.dtpDuLieuHoaDon.CustomFormat = "MM/yyyy";
            this.dtpDuLieuHoaDon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDuLieuHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuLieuHoaDon.Location = new System.Drawing.Point(486, 34);
            this.dtpDuLieuHoaDon.Name = "dtpDuLieuHoaDon";
            this.dtpDuLieuHoaDon.Size = new System.Drawing.Size(93, 25);
            this.dtpDuLieuHoaDon.TabIndex = 0;
            // 
            // btnLoadDataHD
            // 
            this.btnLoadDataHD.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDataHD.Appearance.Options.UseFont = true;
            this.btnLoadDataHD.ImageOptions.Image = global::GUI.Properties.Resources.load_data_icon;
            this.btnLoadDataHD.Location = new System.Drawing.Point(612, 27);
            this.btnLoadDataHD.Name = "btnLoadDataHD";
            this.btnLoadDataHD.Size = new System.Drawing.Size(112, 40);
            this.btnLoadDataHD.TabIndex = 1;
            this.btnLoadDataHD.Text = "Load Data";
            // 
            // gdcDuLieuHoaDon
            // 
            this.gdcDuLieuHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdcDuLieuHoaDon.Location = new System.Drawing.Point(34, 128);
            this.gdcDuLieuHoaDon.MainView = this.gridView1;
            this.gdcDuLieuHoaDon.Name = "gdcDuLieuHoaDon";
            this.gdcDuLieuHoaDon.Size = new System.Drawing.Size(1048, 385);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hóa đơn của Tháng";
            // 
            // UC_LICHSUHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdcDuLieuHoaDon);
            this.Controls.Add(this.btnLoadDataHD);
            this.Controls.Add(this.dtpDuLieuHoaDon);
            this.Name = "UC_LICHSUHOADON";
            this.Size = new System.Drawing.Size(1108, 529);
            ((System.ComponentModel.ISupportInitialize)(this.gdcDuLieuHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDuLieuHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnLoadDataHD;
        private DevExpress.XtraGrid.GridControl gdcDuLieuHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
    }
}
