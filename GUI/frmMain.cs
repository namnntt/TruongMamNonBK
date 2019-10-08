﻿using GUI.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnMDangKyHoc_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_DKHOC.Instance))
            {
                this.Controls.Add(UC_DKHOC.Instance);
                UC_DKHOC.Instance.Dock = DockStyle.Fill;
                UC_DKHOC.Instance.BringToFront();
            }
            else
            {
                UC_DKHOC.Instance.BringToFront();
            }
        }

        private void btnHuyDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_HuyDKHoc.Instance))
            {
                this.Controls.Add(UC_HuyDKHoc.Instance);
                UC_HuyDKHoc.Instance.Dock = DockStyle.Fill;
                UC_HuyDKHoc.Instance.BringToFront();
                
            }
            else
            {
                UC_HuyDKHoc.Instance.BringToFront();
            }
        }

        private void btnGiaHanDangKyHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_GiaHanDKHoc.Instance))
            {
                this.Controls.Add(UC_GiaHanDKHoc.Instance);
                UC_GiaHanDKHoc.Instance.Dock = DockStyle.Fill;
                UC_GiaHanDKHoc.Instance.BringToFront();
            }
            else
            {
                UC_GiaHanDKHoc.Instance.BringToFront();
            }
        }

        private void btnShowHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this.Controls.Contains(UC_HoaDon.Instance))
            {
                this.Controls.Add(UC_HoaDon.Instance);
                UC_HoaDon.Instance.Dock = DockStyle.Fill;
                UC_HoaDon.Instance.BringToFront();
            }
            else
            {
                UC_HoaDon.Instance.BringToFront();
            }
        }
    }
}
