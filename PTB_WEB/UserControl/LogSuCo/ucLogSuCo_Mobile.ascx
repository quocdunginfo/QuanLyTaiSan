﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogSuCo_Mobile.ascx.cs" Inherits="PTB_WEB.UserControl.LogSuCo.ucLogSuCo_Mobile" %>

<%@ Register Src="~/UserControl/ucASPxImageSlider_Mobile.ascx" TagPrefix="uc" TagName="ucASPxImageSlider_Mobile" %>
<%@ Register Src="~/UserControl/ucCollectionPager.ascx" TagPrefix="uc" TagName="ucCollectionPager" %>
<%@ Register Src="~/UserControl/LogSuCo/ucLogSuCo_BreadCrumb.ascx" TagPrefix="uc" TagName="ucLogSuCo_BreadCrumb" %>

<asp:Panel ID="Panel_ThongBaoLoi" runat="server" Visible="False">
    <div class="row">
        <div class="alert alert-danger" role="alert">
            <button type="button" class="close" data-dismiss="alert"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
            <span class="glyphicon glyphicon-exclamation-sign"></span>
            <asp:Label ID="Label_ThongBaoLoi" runat="server" Text="Label"></asp:Label>
        </div>
    </div>
</asp:Panel>
<uc:ucLogSuCo_BreadCrumb runat="server" ID="ucLogSuCo_BreadCrumb" />
<asp:Panel ID="Panel_DanhSachLog" runat="server" Visible="false">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <asp:Label ID="Label_LogSuCo" runat="server" Text="Log"></asp:Label>
        </div>
        <% if (RepeaterDanhSachLogSuCo.Items.Count == 0)
           { %>
        <div class="panel-body">
            <asp:Label ID="Label_DanhSachLogSuCo" runat="server"></asp:Label>
        </div>
        <% }
           else
           { %>
        <table class="table table-bordered table-striped table-hover">
            <thead class="centered">
                <tr>
                    <th>#</th>
                    <th>Tình trạng</th>
                    <th>Phòng</th>
                    <th>Ngày</th>
                </tr>
            </thead>
            <tbody class="centered">
                <asp:Repeater ID="RepeaterDanhSachLogSuCo" runat="server">
                    <ItemTemplate>
                        <tr onclick="location.href='<%# Eval("url") %>'" style="cursor: pointer">
                            <td><%# Container.ItemIndex + 1 + ((_ucCollectionPager_DanhSachSuCo.CollectionPager_Object.CurrentPage - 1)*_ucCollectionPager_DanhSachSuCo.CollectionPager_Object.PageSize) %></td>
                            <td><%# Eval("tinhtrang") %></td>
                            <td><%# Eval("phong") %></td>
                            <td><%# Eval("ngay") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
        <% } %>
    </div>
    <uc:ucCollectionPager runat="server" ID="_ucCollectionPager_DanhSachSuCo" />
</asp:Panel>

<asp:Panel ID="Panel_ThongTinLog" runat="server" Visible="false">
    <div class="panel panel-primary">
        <div class="panel-heading">
            <asp:Label ID="Label_ThongTinLog" runat="server" Text="Thông tin nhân viên"></asp:Label>
        </div>
        <div class="panel-body">
            <uc:ucASPxImageSlider_Mobile runat="server" ID="_ucASPxImageSlider_Mobile" />
            <table class="table table-striped">
                <tbody>
                    <tr>
                        <td style="width: 120px">Tên sự cố:</td>
                        <td>
                            <asp:Label ID="Label_TenSuCo" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Tình trạng:</td>
                        <td>
                            <asp:Label ID="Label_TinhTrang" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Ngày:</td>
                        <td>
                            <asp:Label ID="Label_Ngay" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Phòng:</td>
                        <td>
                            <asp:Label ID="Label_Phong" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Quản trị viên:</td>
                        <td>
                            <asp:Label ID="Label_QuanTriVien" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Ghi chú:</td>
                        <td>
                            <asp:Label ID="Label_GhiChu" runat="server"></asp:Label>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <asp:Button ID="Button_Back" CssClass="btn btn-default" runat="server" Text="Quay lại" Width="100px" OnClick="Button_Back_Click" />
</asp:Panel>