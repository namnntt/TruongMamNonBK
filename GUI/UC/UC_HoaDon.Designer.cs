namespace GUI.UC
{
    partial class UC_HoaDon
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
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.bdHoaDon = new System.Windows.Forms.BindingSource(this.components);
            this.btnDaNopHocPhi = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuaNopHocPhi = new DevExpress.XtraEditors.SimpleButton();
            this.dtPickerHoaDon = new System.Windows.Forms.DateTimePicker();
            this.btnLoadHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTietHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AllowUserToResizeRows = false;
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DataSource = this.bdHoaDon;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(73, 93);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advancedDataGridView1.Size = new System.Drawing.Size(903, 274);
            this.advancedDataGridView1.TabIndex = 0;
            // 
            // btnDaNopHocPhi
            // 
            this.btnDaNopHocPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaNopHocPhi.Location = new System.Drawing.Point(440, 395);
            this.btnDaNopHocPhi.Name = "btnDaNopHocPhi";
            this.btnDaNopHocPhi.Size = new System.Drawing.Size(104, 22);
            this.btnDaNopHocPhi.TabIndex = 1;
            this.btnDaNopHocPhi.Text = "Hoàn Thành học phí";
            // 
            // btnChuaNopHocPhi
            // 
            this.btnChuaNopHocPhi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChuaNopHocPhi.Location = new System.Drawing.Point(582, 395);
            this.btnChuaNopHocPhi.Name = "btnChuaNopHocPhi";
            this.btnChuaNopHocPhi.Size = new System.Drawing.Size(130, 22);
            this.btnChuaNopHocPhi.TabIndex = 2;
            this.btnChuaNopHocPhi.Text = "Chưa hoàn thành học phí";
            // 
            // dtPickerHoaDon
            // 
            this.dtPickerHoaDon.CustomFormat = "MM/yyyy";
            this.dtPickerHoaDon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerHoaDon.Location = new System.Drawing.Point(440, 38);
            this.dtPickerHoaDon.Name = "dtPickerHoaDon";
            this.dtPickerHoaDon.Size = new System.Drawing.Size(115, 22);
            this.dtPickerHoaDon.TabIndex = 3;
            // 
            // btnLoadHoaDon
            // 
            this.btnLoadHoaDon.AutoSize = true;
            this.btnLoadHoaDon.Location = new System.Drawing.Point(591, 37);
            this.btnLoadHoaDon.Name = "btnLoadHoaDon";
            this.btnLoadHoaDon.Size = new System.Drawing.Size(109, 22);
            this.btnLoadHoaDon.TabIndex = 4;
            this.btnLoadHoaDon.Text = "Load dữ liệu hóa đơn";
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.AutoSize = true;
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(269, 395);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(106, 22);
            this.btnChiTietHoaDon.TabIndex = 5;
            this.btnChiTietHoaDon.Text = "Xem chi tiết hóa đơn";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(777, 395);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btnInHoaDon.TabIndex = 6;
            this.btnInHoaDon.Text = "in Hóa đơn";
            // 
            // UC_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.btnLoadHoaDon);
            this.Controls.Add(this.dtPickerHoaDon);
            this.Controls.Add(this.btnChuaNopHocPhi);
            this.Controls.Add(this.btnDaNopHocPhi);
            this.Controls.Add(this.advancedDataGridView1);
            this.Name = "UC_HoaDon";
            this.Size = new System.Drawing.Size(1053, 485);
            this.Load += new System.EventHandler(this.UC_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnDaNopHocPhi;
        private DevExpress.XtraEditors.SimpleButton btnChuaNopHocPhi;
        private System.Windows.Forms.BindingSource bdHoaDon;
        private System.Windows.Forms.DateTimePicker dtPickerHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnLoadHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnChiTietHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
    }
}
