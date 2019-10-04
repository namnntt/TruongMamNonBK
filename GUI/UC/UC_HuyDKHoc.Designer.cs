namespace GUI.UC
{
    partial class UC_HuyDKHoc
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
            this.adgvLopDangKyH = new Zuby.ADGV.AdvancedDataGridView();
            this.bddsLopTheoHS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adgvLopDangKyH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddsLopTheoHS)).BeginInit();
            this.SuspendLayout();
            // 
            // adgvLopDangKyH
            // 
            this.adgvLopDangKyH.AllowUserToAddRows = false;
            this.adgvLopDangKyH.AllowUserToDeleteRows = false;
            this.adgvLopDangKyH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adgvLopDangKyH.AutoGenerateColumns = false;
            this.adgvLopDangKyH.BackgroundColor = System.Drawing.Color.Silver;
            this.adgvLopDangKyH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvLopDangKyH.DataSource = this.bddsLopTheoHS;
            this.adgvLopDangKyH.FilterAndSortEnabled = true;
            this.adgvLopDangKyH.Location = new System.Drawing.Point(30, 52);
            this.adgvLopDangKyH.Name = "adgvLopDangKyH";
            this.adgvLopDangKyH.Size = new System.Drawing.Size(794, 177);
            this.adgvLopDangKyH.TabIndex = 0;
            // 
            // UC_HuyDKHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adgvLopDangKyH);
            this.Name = "UC_HuyDKHoc";
            this.Size = new System.Drawing.Size(855, 440);
            this.Load += new System.EventHandler(this.UC_HuyDKHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adgvLopDangKyH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddsLopTheoHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView adgvLopDangKyH;
        private System.Windows.Forms.BindingSource bddsLopTheoHS;
    }
}
