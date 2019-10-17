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

namespace GUI.UC
{
    public partial class UC_LICHSUHOADON : DevExpress.XtraEditors.XtraUserControl
    {
        private static UC_LICHSUHOADON _instance;
        public static UC_LICHSUHOADON Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_LICHSUHOADON();
                return _instance;
            }
        }
        public UC_LICHSUHOADON()
        {
            InitializeComponent();
        }
    }
}
