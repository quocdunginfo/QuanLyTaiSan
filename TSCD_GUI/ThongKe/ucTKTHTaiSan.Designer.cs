﻿namespace TSCD_GUI.ThongKe
{
    partial class ucTKTHTaiSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTKTHTaiSan));
            this.panelSearch = new DevExpress.XtraEditors.PanelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblDonGia = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.ucComboBoxViTri1 = new TSCD_GUI.MyUserControl.ucComboBoxViTri();
            this.ucComboBoxLoaiTS1 = new TSCD_GUI.MyUserControl.ucComboBoxLoaiTS();
            this.checkViTri = new DevExpress.XtraEditors.CheckEdit();
            this.checkLoaiTS = new DevExpress.XtraEditors.CheckEdit();
            this.checkDonVi = new DevExpress.XtraEditors.CheckEdit();
            this.checkedCbxTinhTrang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.ucComboBoxDonVi1 = new TSCD_GUI.MyUserControl.ucComboBoxDonVi();
            this.dateNgayTK = new DevExpress.XtraEditors.DateEdit();
            this.labelTinhTrang = new DevExpress.XtraEditors.LabelControl();
            this.labelNgaySuDung = new DevExpress.XtraEditors.LabelControl();
            this.gridControlTaiSan = new DevExpress.XtraGrid.GridControl();
            this.gridViewTaiSan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay_ct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsohieuct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colloaits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldonvitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngaysudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthanhtien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnuocsx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvitri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldvql = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLoaiTS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedCbxTinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTaiSan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiSan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.spinEdit1);
            this.panelSearch.Controls.Add(this.comboBoxEdit2);
            this.panelSearch.Controls.Add(this.lblDonGia);
            this.panelSearch.Controls.Add(this.comboBoxEdit1);
            this.panelSearch.Controls.Add(this.btnClear);
            this.panelSearch.Controls.Add(this.btnTim);
            this.panelSearch.Controls.Add(this.ucComboBoxViTri1);
            this.panelSearch.Controls.Add(this.ucComboBoxLoaiTS1);
            this.panelSearch.Controls.Add(this.checkViTri);
            this.panelSearch.Controls.Add(this.checkLoaiTS);
            this.panelSearch.Controls.Add(this.checkDonVi);
            this.panelSearch.Controls.Add(this.checkedCbxTinhTrang);
            this.panelSearch.Controls.Add(this.ucComboBoxDonVi1);
            this.panelSearch.Controls.Add(this.dateNgayTK);
            this.panelSearch.Controls.Add(this.labelTinhTrang);
            this.panelSearch.Controls.Add(this.labelNgaySuDung);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(832, 82);
            this.panelSearch.TabIndex = 0;
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(124, 29);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(90, 20);
            this.spinEdit1.TabIndex = 31;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(84, 29);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<="});
            this.comboBoxEdit2.Size = new System.Drawing.Size(34, 20);
            this.comboBoxEdit2.TabIndex = 30;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Location = new System.Drawing.Point(5, 32);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(41, 13);
            this.lblDonGia.TabIndex = 29;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(84, 5);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "=",
            ">=",
            ">",
            "<="});
            this.comboBoxEdit1.Size = new System.Drawing.Size(34, 20);
            this.comboBoxEdit1.TabIndex = 28;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(737, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Làm sạch";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.Location = new System.Drawing.Point(656, 29);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 26;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // ucComboBoxViTri1
            // 
            this.ucComboBoxViTri1.EditValue = null;
            this.ucComboBoxViTri1.Location = new System.Drawing.Point(372, 54);
            this.ucComboBoxViTri1.Name = "ucComboBoxViTri1";
            this.ucComboBoxViTri1.Phong = null;
            this.ucComboBoxViTri1.Size = new System.Drawing.Size(200, 20);
            this.ucComboBoxViTri1.TabIndex = 25;
            this.ucComboBoxViTri1.ViTri = null;
            // 
            // ucComboBoxLoaiTS1
            // 
            this.ucComboBoxLoaiTS1.EditValue = null;
            this.ucComboBoxLoaiTS1.LoaiTS = null;
            this.ucComboBoxLoaiTS1.Location = new System.Drawing.Point(372, 29);
            this.ucComboBoxLoaiTS1.Name = "ucComboBoxLoaiTS1";
            this.ucComboBoxLoaiTS1.Size = new System.Drawing.Size(200, 20);
            this.ucComboBoxLoaiTS1.TabIndex = 24;
            // 
            // checkViTri
            // 
            this.checkViTri.Location = new System.Drawing.Point(276, 54);
            this.checkViTri.Name = "checkViTri";
            this.checkViTri.Properties.Caption = "Vị trí:";
            this.checkViTri.Size = new System.Drawing.Size(58, 19);
            this.checkViTri.TabIndex = 23;
            // 
            // checkLoaiTS
            // 
            this.checkLoaiTS.Location = new System.Drawing.Point(276, 29);
            this.checkLoaiTS.Name = "checkLoaiTS";
            this.checkLoaiTS.Properties.Caption = "Loại tài sản:";
            this.checkLoaiTS.Size = new System.Drawing.Size(82, 19);
            this.checkLoaiTS.TabIndex = 22;
            // 
            // checkDonVi
            // 
            this.checkDonVi.Location = new System.Drawing.Point(276, 5);
            this.checkDonVi.Name = "checkDonVi";
            this.checkDonVi.Properties.Caption = "Đơn vị quản lý:";
            this.checkDonVi.Size = new System.Drawing.Size(93, 19);
            this.checkDonVi.TabIndex = 21;
            // 
            // checkedCbxTinhTrang
            // 
            this.checkedCbxTinhTrang.Location = new System.Drawing.Point(84, 54);
            this.checkedCbxTinhTrang.Name = "checkedCbxTinhTrang";
            this.checkedCbxTinhTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedCbxTinhTrang.Properties.DisplayMember = "value";
            this.checkedCbxTinhTrang.Properties.ValueMember = "id";
            this.checkedCbxTinhTrang.Size = new System.Drawing.Size(130, 20);
            this.checkedCbxTinhTrang.TabIndex = 20;
            // 
            // ucComboBoxDonVi1
            // 
            this.ucComboBoxDonVi1.DonVi = null;
            this.ucComboBoxDonVi1.EditValue = null;
            this.ucComboBoxDonVi1.Location = new System.Drawing.Point(372, 5);
            this.ucComboBoxDonVi1.Name = "ucComboBoxDonVi1";
            this.ucComboBoxDonVi1.Size = new System.Drawing.Size(200, 20);
            this.ucComboBoxDonVi1.TabIndex = 19;
            // 
            // dateNgayTK
            // 
            this.dateNgayTK.EditValue = null;
            this.dateNgayTK.Location = new System.Drawing.Point(124, 5);
            this.dateNgayTK.Name = "dateNgayTK";
            this.dateNgayTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTK.Size = new System.Drawing.Size(90, 20);
            this.dateNgayTK.TabIndex = 18;
            // 
            // labelTinhTrang
            // 
            this.labelTinhTrang.Location = new System.Drawing.Point(5, 57);
            this.labelTinhTrang.Name = "labelTinhTrang";
            this.labelTinhTrang.Size = new System.Drawing.Size(53, 13);
            this.labelTinhTrang.TabIndex = 17;
            this.labelTinhTrang.Text = "Tình trạng:";
            // 
            // labelNgaySuDung
            // 
            this.labelNgaySuDung.Location = new System.Drawing.Point(4, 8);
            this.labelNgaySuDung.Name = "labelNgaySuDung";
            this.labelNgaySuDung.Size = new System.Drawing.Size(71, 13);
            this.labelNgaySuDung.TabIndex = 16;
            this.labelNgaySuDung.Text = "Ngày sử dụng:";
            // 
            // gridControlTaiSan
            // 
            this.gridControlTaiSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTaiSan.Location = new System.Drawing.Point(0, 82);
            this.gridControlTaiSan.MainView = this.gridViewTaiSan;
            this.gridControlTaiSan.Name = "gridControlTaiSan";
            this.gridControlTaiSan.Size = new System.Drawing.Size(832, 459);
            this.gridControlTaiSan.TabIndex = 1;
            this.gridControlTaiSan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaiSan});
            // 
            // gridViewTaiSan
            // 
            this.gridViewTaiSan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colngay_ct,
            this.colsohieuct,
            this.colten,
            this.colloaits,
            this.coldonvitinh,
            this.colngaysudung,
            this.coldongia,
            this.colsoluong,
            this.colthanhtien,
            this.colnuocsx,
            this.coltinhtrang,
            this.colvitri,
            this.colphong,
            this.coldvql});
            this.gridViewTaiSan.GridControl = this.gridControlTaiSan;
            this.gridViewTaiSan.Name = "gridViewTaiSan";
            this.gridViewTaiSan.OptionsBehavior.Editable = false;
            this.gridViewTaiSan.OptionsBehavior.ReadOnly = true;
            // 
            // colid
            // 
            this.colid.Caption = "id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // colngay_ct
            // 
            this.colngay_ct.Caption = "Ngày chứng từ";
            this.colngay_ct.FieldName = "ngay_ct";
            this.colngay_ct.Name = "colngay_ct";
            this.colngay_ct.Visible = true;
            this.colngay_ct.VisibleIndex = 0;
            // 
            // colsohieuct
            // 
            this.colsohieuct.Caption = "Số hiệu chứng từ";
            this.colsohieuct.FieldName = "sohieu_ct";
            this.colsohieuct.Name = "colsohieuct";
            this.colsohieuct.Visible = true;
            this.colsohieuct.VisibleIndex = 1;
            // 
            // colten
            // 
            this.colten.Caption = "Tên tài sản";
            this.colten.FieldName = "ten";
            this.colten.Name = "colten";
            this.colten.Visible = true;
            this.colten.VisibleIndex = 2;
            // 
            // colloaits
            // 
            this.colloaits.Caption = "Loại tài sản";
            this.colloaits.FieldName = "loaits";
            this.colloaits.Name = "colloaits";
            this.colloaits.Visible = true;
            this.colloaits.VisibleIndex = 3;
            // 
            // coldonvitinh
            // 
            this.coldonvitinh.Caption = "Đơn vị tính";
            this.coldonvitinh.FieldName = "donvitinh";
            this.coldonvitinh.Name = "coldonvitinh";
            this.coldonvitinh.Visible = true;
            this.coldonvitinh.VisibleIndex = 4;
            // 
            // colngaysudung
            // 
            this.colngaysudung.Caption = "Ngày sử dụng";
            this.colngaysudung.FieldName = "ngay";
            this.colngaysudung.Name = "colngaysudung";
            this.colngaysudung.Visible = true;
            this.colngaysudung.VisibleIndex = 5;
            // 
            // coldongia
            // 
            this.coldongia.Caption = "Đơn giá";
            this.coldongia.FieldName = "dongia";
            this.coldongia.Name = "coldongia";
            this.coldongia.Visible = true;
            this.coldongia.VisibleIndex = 8;
            // 
            // colsoluong
            // 
            this.colsoluong.Caption = "Số lượng";
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 7;
            // 
            // colthanhtien
            // 
            this.colthanhtien.Caption = "Thành tiền";
            this.colthanhtien.FieldName = "thanhtien";
            this.colthanhtien.Name = "colthanhtien";
            this.colthanhtien.Visible = true;
            this.colthanhtien.VisibleIndex = 9;
            // 
            // colnuocsx
            // 
            this.colnuocsx.Caption = "Nước sản xuất";
            this.colnuocsx.FieldName = "nuocsx";
            this.colnuocsx.Name = "colnuocsx";
            this.colnuocsx.Visible = true;
            this.colnuocsx.VisibleIndex = 6;
            // 
            // coltinhtrang
            // 
            this.coltinhtrang.Caption = "Tình trạng";
            this.coltinhtrang.FieldName = "tinhtrang";
            this.coltinhtrang.Name = "coltinhtrang";
            this.coltinhtrang.Visible = true;
            this.coltinhtrang.VisibleIndex = 10;
            // 
            // colvitri
            // 
            this.colvitri.Caption = "Vị trí";
            this.colvitri.FieldName = "vitri";
            this.colvitri.Name = "colvitri";
            this.colvitri.Visible = true;
            this.colvitri.VisibleIndex = 11;
            // 
            // colphong
            // 
            this.colphong.Caption = "Phòng";
            this.colphong.FieldName = "phong";
            this.colphong.Name = "colphong";
            this.colphong.Visible = true;
            this.colphong.VisibleIndex = 12;
            // 
            // coldvql
            // 
            this.coldvql.Caption = "Đơn vị quản lý";
            this.coldvql.FieldName = "dvquanly";
            this.coldvql.Name = "coldvql";
            this.coldvql.Visible = true;
            this.coldvql.VisibleIndex = 13;
            // 
            // ucTKTHTaiSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlTaiSan);
            this.Controls.Add(this.panelSearch);
            this.Name = "ucTKTHTaiSan";
            this.Size = new System.Drawing.Size(832, 541);
            ((System.ComponentModel.ISupportInitialize)(this.panelSearch)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkLoaiTS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedCbxTinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTaiSan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTaiSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelSearch;
        private DevExpress.XtraGrid.GridControl gridControlTaiSan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaiSan;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private MyUserControl.ucComboBoxViTri ucComboBoxViTri1;
        private MyUserControl.ucComboBoxLoaiTS ucComboBoxLoaiTS1;
        private DevExpress.XtraEditors.CheckEdit checkViTri;
        private DevExpress.XtraEditors.CheckEdit checkLoaiTS;
        private DevExpress.XtraEditors.CheckEdit checkDonVi;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedCbxTinhTrang;
        private MyUserControl.ucComboBoxDonVi ucComboBoxDonVi1;
        private DevExpress.XtraEditors.DateEdit dateNgayTK;
        private DevExpress.XtraEditors.LabelControl labelTinhTrang;
        private DevExpress.XtraEditors.LabelControl labelNgaySuDung;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colten;
        private DevExpress.XtraGrid.Columns.GridColumn colloaits;
        private DevExpress.XtraGrid.Columns.GridColumn coldonvitinh;
        private DevExpress.XtraGrid.Columns.GridColumn coldongia;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private DevExpress.XtraGrid.Columns.GridColumn colthanhtien;
        private DevExpress.XtraGrid.Columns.GridColumn colnuocsx;
        private DevExpress.XtraGrid.Columns.GridColumn coltinhtrang;
        private DevExpress.XtraGrid.Columns.GridColumn colvitri;
        private DevExpress.XtraGrid.Columns.GridColumn colphong;
        private DevExpress.XtraGrid.Columns.GridColumn coldvql;
        private DevExpress.XtraGrid.Columns.GridColumn colsohieuct;
        private DevExpress.XtraGrid.Columns.GridColumn colngaysudung;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl lblDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colngay_ct;
    }
}