﻿using QuanLyTaiSan.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQLPH
{
    public partial class ThietBis : System.Web.UI.Page
    {
        Boolean isMobile = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            Default SetClassActive = this.Master as Default;
            SetClassActive.page = "THIETBI";

            isMobile = MobileDetect.fBrowserIsMobile();
            if (!isMobile)
            {
                Panel_Web.Visible = true;
                ucThietBi_Web.LoadData();
            }
            else
            {
                Panel_Mobile.Visible = true;
                ucThietBi_Mobile.LoadData();
            }
        }
    }
}