﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyTaiSan.Entities;

namespace WebQLPH.UserControl.NhanVien
{
    public partial class ucNhanVien_Mobile : System.Web.UI.UserControl
    {
        List<NhanVienPT> listNhanVienPT = null;
        NhanVienPT _NhanVienPT = new NhanVienPT();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void LoadData()
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = -1;
                    try
                    {
                        id = Int32.Parse(Request.QueryString["id"].ToString());
                    }
                    catch
                    {
                        Response.Redirect(Request.Url.AbsolutePath);
                        return;
                    }

                    _NhanVienPT = NhanVienPT.getById(id);
                    if (_NhanVienPT != null)
                    {
                        PanelThongTinNhanVienPhuTrach.Visible = true;
                        Label_ThongTin.Text = String.Format("Thông tin {0}", _NhanVienPT.hoten);
                        TextBox_MaNhanVien.Text = _NhanVienPT.subId;
                        TextBox_HoTen.Text = _NhanVienPT.hoten;
                        TextBox_SoDienThoai.Text = _NhanVienPT.sodienthoai;
                        ImageSliderNhanVienPhuTrach.Items.Clear();
                        if (_NhanVienPT.hinhanhs != null && _NhanVienPT.hinhanhs.Count > 0)
                        {
                            foreach (HinhAnh hinhanh in _NhanVienPT.hinhanhs)
                            {
                                DevExpress.Web.ASPxImageSlider.ImageSliderItem item = new DevExpress.Web.ASPxImageSlider.ImageSliderItem();
                                item.ImageUrl = hinhanh.getImageURL();
                                if (hinhanh.mota != null && hinhanh.mota.Length > 0)
                                    item.Text = hinhanh.mota;
                                else
                                    item.Text = hinhanh.FILE_NAME;
                                ImageSliderNhanVienPhuTrach.Items.Add(item);
                            }
                        }
                        else
                        {
                            DevExpress.Web.ASPxImageSlider.ImageSliderItem item = new DevExpress.Web.ASPxImageSlider.ImageSliderItem();
                            item.ImageUrl = "~/Images/NoImage.jpg";
                            item.Text = "Không có ảnh";
                            ImageSliderNhanVienPhuTrach.Items.Add(item);
                        }
                        CollectionPagerDanhSachPhong.DataSource = _NhanVienPT.phongs.ToList();
                        CollectionPagerDanhSachPhong.BindToControl = RepeaterDanhSachPhong;
                        RepeaterDanhSachPhong.DataSource = CollectionPagerDanhSachPhong.DataSourcePaged;
                        RepeaterDanhSachPhong.DataBind();
                    }
                    else
                    {
                        Panel_ThongBaoLoi.Visible = true;
                        Label_ThongBaoLoi.Text = "Không có nhân viên này";
                    }
                }
                else
                {
                    listNhanVienPT = NhanVienPT.getQuery().OrderBy(c => c.hoten).ToList();
                    if (listNhanVienPT != null && listNhanVienPT.Count > 0)
                    {
                        PanelDanhSachNhanVienPhuTrach.Visible = true;
                        BindData();
                    }
                    else
                    {
                        Panel_ThongBaoLoi.Visible = true;
                        Label_ThongBaoLoi.Text = "Chưa có nhân viên";
                        return;
                    }
                }
            }
        }

        private void BindData()
        {
            if (listNhanVienPT != null && listNhanVienPT.Count > 0)
            {
                var list = listNhanVienPT.Select(a => new
                {
                    id = a.id,
                    subid = a.subId,
                    hoten = a.hoten,
                    sodienthoai = a.sodienthoai,
                    url = QuanLyTaiSan.Libraries.StringHelper.AddParameter(new Uri(Request.Url.AbsoluteUri), "id", a.id.ToString(), new List<string>(new string[] { CollectionPagerDanhSachPhong.QueryStringKey })).ToString()
                }).ToList();
                CollectionPagerQuanLyNhanVien.DataSource = list;
                CollectionPagerQuanLyNhanVien.BindToControl = RepeaterQuanLyNhanVien;
                RepeaterQuanLyNhanVien.DataSource = CollectionPagerQuanLyNhanVien.DataSourcePaged;
                RepeaterQuanLyNhanVien.DataBind();
            }
        }

        protected void Button_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}