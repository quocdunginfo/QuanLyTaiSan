﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TSCD_WEB.Default" %>

<%@ Register Src="~/UserControl/TimKiem/ucTimKiem.ascx" TagPrefix="uc" TagName="ucTimKiem" %>
<%@ Register Src="~/UserControl/Footer/ucFooter.ascx" TagPrefix="uc" TagName="ucFooter" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>.: Tài sản cố định :.</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/css/metro/metro.css" />
    <link rel="stylesheet" type="text/css" href="Content/css/metro/metro_mobile.css" media="screen and (max-height: 500px), screen and (orientation:portrait)" />
    <link rel="stylesheet" type="text/css" href="Content/css/metro/website.css" />
    <script type="text/javascript" src="Scripts/scriptgates.js"></script>
    <div class="row timkiem">
        <div class="input-group <%Response.Write(isMobile ? "col-xs-12 col-sm-12 col-md-12" : "col-lg-3"); %> pull-right">
            <uc:ucTimKiem runat="server" ID="ucTimKiem" />
        </div>
    </div>
    <div class="panel-body fixpanel">
        <div class="row">
            <h3 class="title_orange fix">Tài sản cố định</h3>
        </div>
        <div class="row">
            <div class="widget_container full">
                <div class="widget widget2x2 widget_orange animation unloaded">
                    <a href="ViTri.aspx">
                        <div class="widget_content">
                            <div class="main" style="background-image: url('Images/metro/vitri.png');">
                                <span>VỊ TRÍ</span>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="widget widget2x2 widget_red animation unloaded">
                    <a href="Phong.aspx">
                        <div class="widget_content">
                            <div class="main" style="background-image: url('Images/metro/phong.png');">
                                <span>PHÒNG</span>
                            </div>
                        </div>
                    </a>
                </div>
                 <div class="widget widget2x2 widget_red animation unloaded">
                    <a href="LoaiPhong.aspx">
                        <div class="widget_content">
                            <div class="main" style="background-image: url('Images/metro/phong.png');">
                                <span>LOẠI PHÒNG</span>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="widget widget2x2 widget_darkblue animation unloaded">
                    <a href="DonVi.aspx">
                        <div class="widget_content">
                            <div class="main" style="background-image: url('Images/metro/phongthietbi.png');">
                                <span>ĐƠN VỊ</span>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="widget widget2x2 widget_blue widget_link animation unloaded">
                    <a href="LoaiTaiSan.aspx">
                        <div class="widget_content">
                            <div class="main" style="background-image: url('Images/metro/thietbi.png');">
                                <span>LOẠI TÀI SẢN</span>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="widget widget2x2 widget_darkgreen animation unloaded">
                    <a href="TaiSan.aspx">
                        <div class="widget_content">
                            <div class="main" style="background-image: url('Images/metro/loaithietbi.png');">
                                <span>TÀI SẢN</span>
                            </div>
                        </div>
                    </a>
                </div>
                <div class="widget widget2x2 widget_darkred animation unloaded">
                    <a href="DonViTaiSan.aspx">
                        <div class="widget_content">
                            <div class="main" style="background-image: url('Images/metro/nhanvien.png');">
                                <span>ĐƠN VỊ - TÀI SẢN</span>
                            </div>
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <uc:ucFooter runat="server" ID="ucFooter" />
</asp:Content>