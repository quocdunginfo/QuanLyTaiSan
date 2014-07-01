﻿namespace QuanLyTaiSanGUI.QLNhanVien
{
    partial class ucQuanLyNhanVien
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsodienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_modified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhinh_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxPhong = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnImage = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSodt = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ribbonNhanVienPT = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnThemNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSuaNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoaNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPhanCong = new DevExpress.XtraBars.BarButtonItem();
            this.rbnPageNhanVien_Home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbnGroupNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnGroupNhanVienPhong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonNhanVienPT)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 142);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlNhanVien);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(868, 467);
            this.splitContainerControl1.SplitterPosition = 463;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhanVien.MainView = this.gridViewNhanVien;
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(463, 467);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colsubId,
            this.colhoten,
            this.colsodienthoai,
            this.coldate_create,
            this.coldate_modified,
            this.colhinh_id});
            this.gridViewNhanVien.GridControl = this.gridControlNhanVien;
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsBehavior.Editable = false;
            this.gridViewNhanVien.OptionsBehavior.ReadOnly = true;
            this.gridViewNhanVien.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewNhanVien.OptionsView.ShowAutoFilterRow = true;
            this.gridViewNhanVien.OptionsView.ShowGroupPanel = false;
            this.gridViewNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNhanVien_FocusedRowChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            // 
            // colsubId
            // 
            this.colsubId.Caption = "Mã nhân viên";
            this.colsubId.FieldName = "subId";
            this.colsubId.Name = "colsubId";
            this.colsubId.Visible = true;
            this.colsubId.VisibleIndex = 0;
            // 
            // colhoten
            // 
            this.colhoten.Caption = "Họ tên";
            this.colhoten.FieldName = "hoten";
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            // 
            // colsodienthoai
            // 
            this.colsodienthoai.Caption = "Số điện thoại";
            this.colsodienthoai.FieldName = "sodienthoai";
            this.colsodienthoai.Name = "colsodienthoai";
            this.colsodienthoai.Visible = true;
            this.colsodienthoai.VisibleIndex = 2;
            // 
            // coldate_create
            // 
            this.coldate_create.FieldName = "date_create";
            this.coldate_create.Name = "coldate_create";
            // 
            // coldate_modified
            // 
            this.coldate_modified.FieldName = "date_modified";
            this.coldate_modified.Name = "coldate_modified";
            // 
            // colhinh_id
            // 
            this.colhinh_id.FieldName = "hinh_id";
            this.colhinh_id.Name = "colhinh_id";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.listBoxPhong);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 259);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(400, 208);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách phòng";
            // 
            // listBoxPhong
            // 
            this.listBoxPhong.DisplayMember = "ten";
            this.listBoxPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPhong.Location = new System.Drawing.Point(2, 24);
            this.listBoxPhong.Name = "listBoxPhong";
            this.listBoxPhong.Size = new System.Drawing.Size(396, 182);
            this.listBoxPhong.TabIndex = 13;
            this.listBoxPhong.ValueMember = "id";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnOK);
            this.groupControl1.Controls.Add(this.btnImage);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtSodt);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.txtMa);
            this.groupControl1.Controls.Add(this.imageSlider1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(400, 259);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Chi tiết";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(165, 229);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(84, 229);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(210, 25);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(67, 23);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Chọn";
            this.btnImage.Visible = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 209);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Số điện thoại:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 183);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tên nhân viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 157);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mã nhân viên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Hình ảnh:";
            // 
            // txtSodt
            // 
            this.txtSodt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSodt.Location = new System.Drawing.Point(84, 206);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Properties.ReadOnly = true;
            this.txtSodt.Size = new System.Drawing.Size(311, 20);
            this.txtSodt.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(84, 180);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(311, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtMa
            // 
            this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMa.Location = new System.Drawing.Point(84, 154);
            this.txtMa.Name = "txtMa";
            this.txtMa.Properties.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(311, 20);
            this.txtMa.TabIndex = 1;
            // 
            // imageSlider1
            // 
            this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.imageSlider1.Location = new System.Drawing.Point(84, 25);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(120, 120);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // ribbonNhanVienPT
            // 
            this.ribbonNhanVienPT.ApplicationIcon = global::QuanLyTaiSanGUI.Properties.Resources.Logo;
            this.ribbonNhanVienPT.ExpandCollapseItem.Id = 0;
            this.ribbonNhanVienPT.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonNhanVienPT.ExpandCollapseItem,
            this.barBtnThemNhanVien,
            this.barBtnSuaNhanVien,
            this.barBtnXoaNhanVien,
            this.barBtnPhanCong});
            this.ribbonNhanVienPT.Location = new System.Drawing.Point(0, 0);
            this.ribbonNhanVienPT.MaxItemId = 39;
            this.ribbonNhanVienPT.Name = "ribbonNhanVienPT";
            this.ribbonNhanVienPT.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnPageNhanVien_Home});
            this.ribbonNhanVienPT.Size = new System.Drawing.Size(868, 142);
            // 
            // barBtnThemNhanVien
            // 
            this.barBtnThemNhanVien.Caption = "Thêm nhân viên";
            this.barBtnThemNhanVien.Glyph = global::QuanLyTaiSanGUI.Properties.Resources.plus_2;
            this.barBtnThemNhanVien.Id = 18;
            this.barBtnThemNhanVien.Name = "barBtnThemNhanVien";
            this.barBtnThemNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnThemNhanVien_ItemClick);
            // 
            // barBtnSuaNhanVien
            // 
            this.barBtnSuaNhanVien.Caption = "Sửa nhân viên";
            this.barBtnSuaNhanVien.Glyph = global::QuanLyTaiSanGUI.Properties.Resources.pencil_edit;
            this.barBtnSuaNhanVien.Id = 19;
            this.barBtnSuaNhanVien.Name = "barBtnSuaNhanVien";
            this.barBtnSuaNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSuaNhanVien_ItemClick);
            // 
            // barBtnXoaNhanVien
            // 
            this.barBtnXoaNhanVien.Caption = "Xóa nhân viên";
            this.barBtnXoaNhanVien.Glyph = global::QuanLyTaiSanGUI.Properties.Resources.minus_2;
            this.barBtnXoaNhanVien.Id = 20;
            this.barBtnXoaNhanVien.Name = "barBtnXoaNhanVien";
            this.barBtnXoaNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnXoaNhanVien_ItemClick);
            // 
            // barBtnPhanCong
            // 
            this.barBtnPhanCong.Caption = "Phân công";
            this.barBtnPhanCong.Id = 21;
            this.barBtnPhanCong.LargeGlyph = global::QuanLyTaiSanGUI.Properties.Resources.Actions_view_pim_tasks_icon;
            this.barBtnPhanCong.Name = "barBtnPhanCong";
            this.barBtnPhanCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPhanCong_ItemClick);
            // 
            // rbnPageNhanVien_Home
            // 
            this.rbnPageNhanVien_Home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbnGroupNhanVien,
            this.rbnGroupNhanVienPhong});
            this.rbnPageNhanVien_Home.Name = "rbnPageNhanVien_Home";
            this.rbnPageNhanVien_Home.Text = "Nhân viên";
            // 
            // rbnGroupNhanVien
            // 
            this.rbnGroupNhanVien.ItemLinks.Add(this.barBtnThemNhanVien);
            this.rbnGroupNhanVien.ItemLinks.Add(this.barBtnSuaNhanVien);
            this.rbnGroupNhanVien.ItemLinks.Add(this.barBtnXoaNhanVien);
            this.rbnGroupNhanVien.Name = "rbnGroupNhanVien";
            this.rbnGroupNhanVien.ShowCaptionButton = false;
            this.rbnGroupNhanVien.Text = "Nhân viên";
            // 
            // rbnGroupNhanVienPhong
            // 
            this.rbnGroupNhanVienPhong.ItemLinks.Add(this.barBtnPhanCong);
            this.rbnGroupNhanVienPhong.Name = "rbnGroupNhanVienPhong";
            this.rbnGroupNhanVienPhong.ShowCaptionButton = false;
            this.rbnGroupNhanVienPhong.Text = "Phân công";
            // 
            // ucQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.ribbonNhanVienPT);
            this.Name = "ucQuanLyNhanVien";
            this.Size = new System.Drawing.Size(868, 609);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSodt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonNhanVienPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colsubId;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colsodienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_create;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_modified;
        private DevExpress.XtraGrid.Columns.GridColumn colhinh_id;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSodt;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnImage;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.ListBoxControl listBoxPhong;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonNhanVienPT;
        private DevExpress.XtraBars.BarButtonItem barBtnThemPhong;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaPhong;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaPhong;
        private DevExpress.XtraBars.BarButtonItem barBtnThemThietBi;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaThietBi;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaThietBi;
        private DevExpress.XtraBars.BarButtonItem barBtnCHuyenTinhTrang;
        private DevExpress.XtraBars.BarButtonItem barBtnChuyenPhong;
        private DevExpress.XtraBars.BarButtonItem barBtnThemCoSo;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaCoSo;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaCoSo;
        private DevExpress.XtraBars.BarButtonItem barBtnThemDay;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaDay;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaDay;
        private DevExpress.XtraBars.BarButtonItem barBtnThemTang;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaTang;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaTang;
        private DevExpress.XtraBars.BarButtonItem barBtnThemNhanVien;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaNhanVien;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaNhanVien;
        private DevExpress.XtraBars.BarButtonItem barBtnPhanCong;
        private DevExpress.XtraBars.BarButtonItem barBtnThemLoaiTB;
        private DevExpress.XtraBars.BarButtonItem barBtnSuaLoaiTB;
        private DevExpress.XtraBars.BarButtonItem barBtnXoaLoaiTB;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnPageNhanVien_Home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnGroupNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnGroupNhanVienPhong;
    }
}
