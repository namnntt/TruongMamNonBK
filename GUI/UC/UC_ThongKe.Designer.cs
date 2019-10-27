namespace GUI.UC
{
    partial class UC_ThongKe
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(0D, new object[] {
            ((object)(0D))});
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chrBaoCaoSoLuongDangky = new DevExpress.XtraCharts.ChartControl();
            this.datdrawrtChart = new System.Windows.Forms.DateTimePicker();
            this.cbChart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.bdbaocao = new System.Windows.Forms.BindingSource(this.components);
            this.bdnavi = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chrBaoCaoSoLuongDangky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdbaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnavi)).BeginInit();
            this.SuspendLayout();
            // 
            // chrBaoCaoSoLuongDangky
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chrBaoCaoSoLuongDangky.Diagram = xyDiagram1;
            this.chrBaoCaoSoLuongDangky.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chrBaoCaoSoLuongDangky.Legend.Name = "Default Legend";
            this.chrBaoCaoSoLuongDangky.Location = new System.Drawing.Point(0, 108);
            this.chrBaoCaoSoLuongDangky.Name = "chrBaoCaoSoLuongDangky";
            series1.DataSource = this.bdnavi;
            series1.Name = "Tháng 9";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1});
            series2.DataSource = this.bdbaocao;
            series2.Name = "Tháng 10";
            this.chrBaoCaoSoLuongDangky.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chrBaoCaoSoLuongDangky.Size = new System.Drawing.Size(1117, 437);
            this.chrBaoCaoSoLuongDangky.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "Báo cáo Số lượng học sinh đăng ký";
            this.chrBaoCaoSoLuongDangky.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // datdrawrtChart
            // 
            this.datdrawrtChart.CustomFormat = "MMMM yyyy";
            this.datdrawrtChart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datdrawrtChart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datdrawrtChart.Location = new System.Drawing.Point(471, 22);
            this.datdrawrtChart.Name = "datdrawrtChart";
            this.datdrawrtChart.Size = new System.Drawing.Size(180, 25);
            this.datdrawrtChart.TabIndex = 1;
            // 
            // cbChart
            // 
            this.cbChart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChart.FormattingEnabled = true;
            this.cbChart.Items.AddRange(new object[] {
            "Thống kê Theo Lớp",
            "Thống kê Theo CLB"});
            this.cbChart.Location = new System.Drawing.Point(471, 66);
            this.cbChart.Name = "cbChart";
            this.cbChart.Size = new System.Drawing.Size(180, 25);
            this.cbChart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê theo";
            // 
            // btnDuLieu
            // 
            this.btnDuLieu.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuLieu.Appearance.Options.UseFont = true;
            this.btnDuLieu.ImageOptions.Image = global::GUI.Properties.Resources.load_data_Chart_icon;
            this.btnDuLieu.Location = new System.Drawing.Point(688, 38);
            this.btnDuLieu.Name = "btnDuLieu";
            this.btnDuLieu.Size = new System.Drawing.Size(121, 36);
            this.btnDuLieu.TabIndex = 5;
            this.btnDuLieu.Text = "Load Dữ liệu";
            this.btnDuLieu.Click += new System.EventHandler(this.btnDuLieu_Click);
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDuLieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbChart);
            this.Controls.Add(this.datdrawrtChart);
            this.Controls.Add(this.chrBaoCaoSoLuongDangky);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1117, 545);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrBaoCaoSoLuongDangky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdbaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdnavi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chrBaoCaoSoLuongDangky;
        private System.Windows.Forms.DateTimePicker datdrawrtChart;
        private System.Windows.Forms.ComboBox cbChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDuLieu;
        private System.Windows.Forms.BindingSource bdbaocao;
        private System.Windows.Forms.BindingSource bdnavi;
    }
}
