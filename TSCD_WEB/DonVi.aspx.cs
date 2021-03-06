﻿using SHARED.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TSCD_WEB
{
    public partial class DonVi : System.Web.UI.Page
    {
        Boolean isMobile = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            Site SetClassActive = this.Master as Site;
            SetClassActive.page = "DONVI";

            isMobile = MobileDetect.fBrowserIsMobile();
            if (!isMobile)
            {
                ucDonVi_Web.Visible = true;
                ucDonVi_Web.LoadData();
            }
            else
            {
                ucDonVi_Mobile.Visible = true;
                ucDonVi_Mobile.LoadData();
            }
        }
    }
}