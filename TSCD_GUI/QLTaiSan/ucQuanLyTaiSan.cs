﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TSCD_GUI.QLTaiSan
{
    public partial class ucQuanLyTaiSan : DevExpress.XtraEditors.XtraUserControl
    {
        public ucQuanLyTaiSan()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            rbnControlTaiSan.Parent = null;
        }

        public DevExpress.XtraBars.Ribbon.RibbonControl getRibbonControl()
        {
            return rbnControlTaiSan;
        }
    }
}