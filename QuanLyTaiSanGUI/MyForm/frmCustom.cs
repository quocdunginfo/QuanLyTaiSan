﻿using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using PTB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB_GUI.MyForm
{
    public partial class frmCustom : RibbonForm
    {
        public frmCustom()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SkinName = Global.local_setting.ApplicationSkinName;
        }
    }
}
