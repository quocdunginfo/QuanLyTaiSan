﻿namespace QuanLyTaiSanGUI.HeThong
{
    partial class ucPhanQuyen
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_create = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate_modified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colten_group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatKhauQuanTriVien = new DevExpress.XtraEditors.TextEdit();
            this.txtTaiKhoanQuanTriVien = new DevExpress.XtraEditors.TextEdit();
            this.txtTenQuanTriVien = new DevExpress.XtraEditors.TextEdit();
            this.txtMaQuanTriVien = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit_group = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtXacNhanMK = new DevExpress.XtraEditors.TextEdit();
            this.dateCreated = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauQuanTriVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoanQuanTriVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenQuanTriVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuanTriVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreated.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlPhanQuyen);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(788, 469);
            this.splitContainerControl1.SplitterPosition = 283;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlPhanQuyen
            // 
            this.gridControlPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.gridControlPhanQuyen.MainView = this.gridViewPhanQuyen;
            this.gridControlPhanQuyen.Name = "gridControlPhanQuyen";
            this.gridControlPhanQuyen.Size = new System.Drawing.Size(500, 469);
            this.gridControlPhanQuyen.TabIndex = 0;
            this.gridControlPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhanQuyen});
            // 
            // gridViewPhanQuyen
            // 
            this.gridViewPhanQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colhoten,
            this.colusername,
            this.coldate_create,
            this.coldate_modified,
            this.colten_group});
            this.gridViewPhanQuyen.GridControl = this.gridControlPhanQuyen;
            this.gridViewPhanQuyen.GroupCount = 1;
            this.gridViewPhanQuyen.Name = "gridViewPhanQuyen";
            this.gridViewPhanQuyen.OptionsBehavior.Editable = false;
            this.gridViewPhanQuyen.OptionsBehavior.ReadOnly = true;
            this.gridViewPhanQuyen.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewPhanQuyen.OptionsFind.AlwaysVisible = true;
            this.gridViewPhanQuyen.OptionsView.ShowGroupPanel = false;
            this.gridViewPhanQuyen.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colten_group, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewPhanQuyen.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPhanQuyen_FocusedRowChanged);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colhoten
            // 
            this.colhoten.Caption = "Họ tên";
            this.colhoten.FieldName = "hoten";
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            // 
            // colusername
            // 
            this.colusername.Caption = "Tài khoản";
            this.colusername.FieldName = "username";
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 2;
            // 
            // coldate_create
            // 
            this.coldate_create.Caption = "Ngày tạo";
            this.coldate_create.FieldName = "date_create";
            this.coldate_create.Name = "coldate_create";
            this.coldate_create.Visible = true;
            this.coldate_create.VisibleIndex = 3;
            // 
            // coldate_modified
            // 
            this.coldate_modified.Caption = "Ngày chỉnh sửa";
            this.coldate_modified.FieldName = "date_modified";
            this.coldate_modified.Name = "coldate_modified";
            this.coldate_modified.Visible = true;
            this.coldate_modified.VisibleIndex = 4;
            // 
            // colten_group
            // 
            this.colten_group.Caption = "Nhóm quản trị";
            this.colten_group.FieldName = "ten_group";
            this.colten_group.Name = "colten_group";
            this.colten_group.Visible = true;
            this.colten_group.VisibleIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dateCreated);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtXacNhanMK);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lookUpEdit_group);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnOK);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMatKhauQuanTriVien);
            this.groupControl1.Controls.Add(this.txtTaiKhoanQuanTriVien);
            this.groupControl1.Controls.Add(this.txtTenQuanTriVien);
            this.groupControl1.Controls.Add(this.txtMaQuanTriVien);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(283, 266);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chi tiết";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(145, 221);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(64, 221);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 159);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Ngày tạo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Mật khẩu:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tài khoản:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Tên quản trị viên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mã quản trị viên:";
            // 
            // txtMatKhauQuanTriVien
            // 
            this.txtMatKhauQuanTriVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhauQuanTriVien.Location = new System.Drawing.Point(93, 101);
            this.txtMatKhauQuanTriVien.Name = "txtMatKhauQuanTriVien";
            this.txtMatKhauQuanTriVien.Properties.ReadOnly = true;
            this.txtMatKhauQuanTriVien.Size = new System.Drawing.Size(185, 20);
            this.txtMatKhauQuanTriVien.TabIndex = 3;
            // 
            // txtTaiKhoanQuanTriVien
            // 
            this.txtTaiKhoanQuanTriVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoanQuanTriVien.Location = new System.Drawing.Point(93, 76);
            this.txtTaiKhoanQuanTriVien.Name = "txtTaiKhoanQuanTriVien";
            this.txtTaiKhoanQuanTriVien.Properties.ReadOnly = true;
            this.txtTaiKhoanQuanTriVien.Size = new System.Drawing.Size(185, 20);
            this.txtTaiKhoanQuanTriVien.TabIndex = 3;
            // 
            // txtTenQuanTriVien
            // 
            this.txtTenQuanTriVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenQuanTriVien.Location = new System.Drawing.Point(93, 50);
            this.txtTenQuanTriVien.Name = "txtTenQuanTriVien";
            this.txtTenQuanTriVien.Properties.ReadOnly = true;
            this.txtTenQuanTriVien.Size = new System.Drawing.Size(185, 20);
            this.txtTenQuanTriVien.TabIndex = 2;
            // 
            // txtMaQuanTriVien
            // 
            this.txtMaQuanTriVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaQuanTriVien.Location = new System.Drawing.Point(93, 24);
            this.txtMaQuanTriVien.Name = "txtMaQuanTriVien";
            this.txtMaQuanTriVien.Properties.ReadOnly = true;
            this.txtMaQuanTriVien.Size = new System.Drawing.Size(185, 20);
            this.txtMaQuanTriVien.TabIndex = 1;
            // 
            // lookUpEdit_group
            // 
            this.lookUpEdit_group.Location = new System.Drawing.Point(93, 183);
            this.lookUpEdit_group.Name = "lookUpEdit_group";
            this.lookUpEdit_group.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_group.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ten", "Tên nhóm")});
            this.lookUpEdit_group.Properties.DisplayMember = "ten";
            this.lookUpEdit_group.Properties.ValueMember = "id";
            this.lookUpEdit_group.Size = new System.Drawing.Size(185, 20);
            this.lookUpEdit_group.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 185);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Nhóm:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(7, 131);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Xác nhận MK:";
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(93, 128);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Properties.ReadOnly = true;
            this.txtXacNhanMK.Size = new System.Drawing.Size(185, 20);
            this.txtXacNhanMK.TabIndex = 14;
            // 
            // dateCreated
            // 
            this.dateCreated.EditValue = null;
            this.dateCreated.Location = new System.Drawing.Point(93, 155);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCreated.Size = new System.Drawing.Size(185, 20);
            this.dateCreated.TabIndex = 16;
            this.dateCreated.EditValueChanged += new System.EventHandler(this.dateCreated_EditValueChanged);
            // 
            // ucPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucPhanQuyen";
            this.Size = new System.Drawing.Size(788, 469);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauQuanTriVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoanQuanTriVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenQuanTriVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaQuanTriVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreated.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_create;
        private DevExpress.XtraGrid.Columns.GridColumn coldate_modified;
        private DevExpress.XtraGrid.Columns.GridColumn colten_group;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoanQuanTriVien;
        private DevExpress.XtraEditors.TextEdit txtTenQuanTriVien;
        private DevExpress.XtraEditors.TextEdit txtMaQuanTriVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMatKhauQuanTriVien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_group;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMK;
        private DevExpress.XtraEditors.DateEdit dateCreated;

    }
}
