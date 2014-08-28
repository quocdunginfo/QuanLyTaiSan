﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyTaiSan.Entities;
using QuanLyTaiSan.DataFilter;
using QuanLyTaiSan.Libraries;

namespace WebQLPH.UserControl.PhongThietBi
{
    public partial class ucPhongThietBi_Mobile : System.Web.UI.UserControl
    {
        public Guid idThietBi = Guid.Empty;
        List<ViTriHienThi> listViTriHienThi = new List<ViTriHienThi>();
        List<ChiTietTBHienThi> listThietBiCuaPhong = new List<ChiTietTBHienThi>();
        QuanLyTaiSan.Entities.Phong objPhong = null;
        QuanLyTaiSan.Entities.ThietBi objThietBi = null;
        string key = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            _ucTreeViTri.NotFocusOnCreated();
            _ucTreeViTri.ASPxTreeList_ViTri.CustomDataCallback += new DevExpress.Web.ASPxTreeList.TreeListCustomDataCallbackEventHandler(this.ASPxTreeList_ViTri_CustomDataCallback);
            _ucTreeViTri.ASPxTreeList_ViTri.HtmlDataCellPrepared += new DevExpress.Web.ASPxTreeList.TreeListHtmlDataCellEventHandler(this.ASPxTreeList_ViTri_HtmlDataCellPrepared);
        }

        public void LoadData()
        {
            listViTriHienThi = ViTriHienThi.getAllHavePhong();
            if (listViTriHienThi.Count > 0)
            {
                if (listViTriHienThi.Where(item => Object.Equals(item.loai, typeof(QuanLyTaiSan.Entities.Phong).Name)).FirstOrDefault() != null)
                {
                    _ucTreeViTri.ASPxTreeList_ViTri.DataSource = listViTriHienThi;
                    _ucTreeViTri.ASPxTreeList_ViTri.DataBind();
                    if (Request.QueryString["key"] != null)
                    {
                        key = "";
                        try
                        {
                            key = Request.QueryString["key"].ToString();
                        }
                        catch
                        {
                            Response.Redirect(Request.Url.AbsolutePath);
                        }

                        DevExpress.Web.ASPxTreeList.TreeListNode node = _ucTreeViTri.ASPxTreeList_ViTri.FindNodeByKeyValue(key);
                        if (node != null)
                        {
                            objPhong = QuanLyTaiSan.Entities.Phong.getById(GUID.From(node.GetValue("id")));
                            if (objPhong != null)
                            {
                                if (Request.QueryString["id"] != null)
                                {
                                    idThietBi = Guid.Empty;
                                    try
                                    {
                                        idThietBi = GUID.From(Request.QueryString["id"]);
                                    }
                                    catch
                                    {
                                        Response.Redirect(Request.Url.AbsolutePath);
                                    }
                                    objThietBi = QuanLyTaiSan.Entities.ThietBi.getById(idThietBi);
                                    if (objThietBi != null)
                                    {
                                        Label_ThongTinThietBi.Text = string.Format("Thông tin {0}", objThietBi.ten);
                                        Panel_ThietBi.Visible = true;
                                        QuanLyTaiSan.Libraries.ImageHelper.LoadImageWeb(objThietBi.hinhanhs.ToList(), ASPxImageSlider_ThietBi);
                                        Label_MaThietBi.Text = objThietBi.subId;
                                        Label_TenThietBi.Text = objThietBi.ten;
                                        if (objThietBi.loaithietbi != null)
                                        {
                                            Label_LoaiThietBi.Text = objThietBi.loaithietbi.ten;
                                            if (objThietBi.loaithietbi.loaichung)
                                            {
                                                Panel_NgayMua.Visible = false;
                                                Label_NgayMua.Text = "";
                                                Label_KieuQuanLy.Text = "Theo số lượng";
                                            }
                                            else
                                            {
                                                Panel_NgayMua.Visible = true;
                                                Label_NgayMua.Text = objThietBi.ngaymua.ToString();
                                                Label_KieuQuanLy.Text = "Theo cá thể";
                                            }
                                        }
                                        else
                                        {
                                            Label_LoaiThietBi.Text = "[Loại thiết bị]";
                                            Panel_NgayMua.Visible = false;
                                            Label_NgayMua.Text = "";
                                            Label_KieuQuanLy.Text = "Chưa rõ";
                                        }
                                        Label_Phong.Text = objPhong.ten;
                                        Label_NgayLap.Text = objThietBi.ctthietbis != null ? objThietBi.ctthietbis.Where(item => item.phong_id == objPhong.id).FirstOrDefault().ngay.ToString() : "";
                                        Label_MoTa.Text = QuanLyTaiSan.Libraries.StringHelper.ConvertRNToBR(objThietBi.mota);
                                        Button_XemLog.OnClientClick = string.Format("location.href='{0}'; return false;", QuanLyTaiSan.Libraries.StringHelper.AddParameter(new Uri("http://" + Request.Url.Authority + "/" + ResolveClientUrl("~/LogThietBi.aspx")), "id", idThietBi.ToString()));
                                    }
                                    else
                                    {
                                        Response.Redirect(Request.Url.AbsolutePath);
                                    }
                                }
                                else
                                {
                                    LoadDataObjPhong();
                                    Panel_DanhSachThietBi.Visible = true;
                                }
                            }
                            else
                            {
                                Response.Redirect(Request.Url.AbsolutePath);
                            }
                        }
                        else
                        {
                            Response.Redirect(Request.Url.AbsolutePath);
                        }
                    }
                    else
                    {
                        Panel_TreeListViTri.Visible = true;
                    }
                }
                else
                {
                    Panel_ThongBaoLoi.Visible = true;
                    Label_ThongBaoLoi.Text = "Chưa có phòng";
                }
            }
            else
            {
                Panel_ThongBaoLoi.Visible = true;
                Label_ThongBaoLoi.Text = "Chưa có vị trí";
            }
        }

        private void ASPxTreeList_ViTri_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxTreeList.TreeListHtmlDataCellEventArgs e)
        {
            if (Object.Equals(e.GetValue("loai"), typeof(QuanLyTaiSan.Entities.Phong).Name))
                e.Cell.Font.Bold = true;
        }

        private void ASPxTreeList_ViTri_CustomDataCallback(object sender, DevExpress.Web.ASPxTreeList.TreeListCustomDataCallbackEventArgs e)
        {
            string key = e.Argument.ToString();
            DevExpress.Web.ASPxTreeList.TreeListNode node = _ucTreeViTri.ASPxTreeList_ViTri.FindNodeByKeyValue(key);
            if (node != null)
            {
                if (Object.Equals(node.GetValue("loai"), typeof(QuanLyTaiSan.Entities.Phong).Name))
                    e.Result = Request.Url.AbsolutePath + "?key=" + key;
                else
                    e.Result = "";
            }
            else
                e.Result = Request.Url.AbsolutePath;
        }

        private void LoadDataObjPhong()
        {
            if (objPhong != null)
            {
                if (objPhong.vitri != null)
                {
                    if (objPhong.vitri.coso != null)
                    {
                        Label_DanhSachThietBiTitle.Text = string.Format("Danh sách thiết bị phòng {0} ({1}", objPhong.ten, objPhong.vitri.coso.ten);
                        if (objPhong.vitri.day != null)
                        {
                            Label_DanhSachThietBiTitle.Text += string.Format(" - {0}", objPhong.vitri.day.ten);
                            if (objPhong.vitri.tang != null)
                            {
                                Label_DanhSachThietBiTitle.Text += string.Format(" - {0})", objPhong.vitri.tang.ten);
                            }
                            else
                            {
                                Label_DanhSachThietBiTitle.Text += ")";
                            }
                        }
                        else
                        {
                            Label_DanhSachThietBiTitle.Text += ")";
                        }
                    }
                    else
                    {
                        Label_DanhSachThietBiTitle.Text = string.Format("Danh sách thiết bị phòng {0}", objPhong.ten);
                    }
                }
                else
                {
                    Label_DanhSachThietBiTitle.Text = string.Format("Danh sách thiết bị phòng {0}", objPhong.ten);
                }
                listThietBiCuaPhong = ChiTietTBHienThi.getAllByPhongId(objPhong.id);
                var bind = listThietBiCuaPhong.Select(a => new
                {
                    id = a.idTB,
                    ten = a.ten,
                    tinhtrang = a.tinhtrang,
                    soluong = a.soluong,
                    url = QuanLyTaiSan.Libraries.StringHelper.AddParameter(new Uri(Request.Url.AbsoluteUri), "id", a.idTB.ToString()),
                    urlLog = QuanLyTaiSan.Libraries.StringHelper.AddParameter(new Uri("http://" + Request.Url.Authority + "/" + ResolveClientUrl("~/LogThietBi.aspx")), "id", a.idTB.ToString())
                }).OrderBy(item => item.tinhtrang).ToList();
                CollectionPagerDanhSachThietBi.DataSource = bind;
                CollectionPagerDanhSachThietBi.BindToControl = RepeaterDanhSachThietBi;
                RepeaterDanhSachThietBi.DataSource = CollectionPagerDanhSachThietBi.DataSourcePaged;
                RepeaterDanhSachThietBi.DataBind();

                if (listThietBiCuaPhong != null)
                {
                    if (listThietBiCuaPhong.Count > 0)
                        Label_DanhSachThietBi.Text = string.Format("Danh sách thiết bị của {0}", objPhong.ten);
                    else
                        Label_DanhSachThietBi.Text = string.Format("{0} chưa có thiết bị", objPhong.ten);
                }
                else
                    Label_DanhSachThietBi.Text = string.Format("{0} chưa có thiết bị", objPhong.ten);
            }
            else
            {
                Response.Redirect(Request.Url.AbsolutePath);
            }
        }

        protected void ButtonBack_DanhSachThietBi_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsolutePath);
        }

        protected void ButtonBack_ThietBi_Click(object sender, EventArgs e)
        {
            if (!key.Equals(""))
                Response.Redirect(QuanLyTaiSan.Libraries.StringHelper.AddParameter(new Uri(Request.Url.AbsoluteUri), "key", key, new List<string>(new string[] { "id" })).ToString());
            else
                Response.Redirect(Request.Url.AbsolutePath);
        }
    }
}