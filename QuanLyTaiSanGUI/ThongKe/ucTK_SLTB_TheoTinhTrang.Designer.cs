﻿namespace QuanLyTaiSanGUI.ThongKe
{
    partial class ucTK_SLTB_TheoTinhTrang
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl_condition = new DevExpress.XtraEditors.GroupControl();
            this.checkedComboBoxEdit1 = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ucTreeLoaiTB = new QuanLyTaiSanGUI.MyUC.ucTreeLoaiTB();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.checkedComboBoxEdit_tinhTrang = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.dateEdit_to = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit_from = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_condition)).BeginInit();
            this.groupControl_condition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit_tinhTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_to.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_to.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_from.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_from.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl_condition);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(756, 458);
            this.splitContainerControl1.SplitterPosition = 536;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(536, 458);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "soluong", null, "(TC: {0})"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "soluong", null, "[Rows: {0}]")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng";
            this.gridColumn2.FieldName = "soluong";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 50;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tình trạng";
            this.gridColumn7.FieldName = "tentinhtrang";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 139;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Loại thiết bị";
            this.gridColumn8.FieldName = "tenltb";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 153;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Phòng";
            this.gridColumn6.FieldName = "tenphong";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 83;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tầng";
            this.gridColumn5.FieldName = "tentang";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 77;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Dãy";
            this.gridColumn4.FieldName = "tenday";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 78;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cơ sở";
            this.gridColumn3.FieldName = "tencoso";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 116;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 397);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(215, 61);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Tác vụ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(10, 24);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(42, 27);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupControl_condition
            // 
            this.groupControl_condition.Controls.Add(this.checkedComboBoxEdit1);
            this.groupControl_condition.Controls.Add(this.btnOK);
            this.groupControl_condition.Controls.Add(this.labelControl5);
            this.groupControl_condition.Controls.Add(this.ucTreeLoaiTB);
            this.groupControl_condition.Controls.Add(this.labelControl4);
            this.groupControl_condition.Controls.Add(this.checkedComboBoxEdit_tinhTrang);
            this.groupControl_condition.Controls.Add(this.dateEdit_to);
            this.groupControl_condition.Controls.Add(this.labelControl3);
            this.groupControl_condition.Controls.Add(this.labelControl2);
            this.groupControl_condition.Controls.Add(this.dateEdit_from);
            this.groupControl_condition.Controls.Add(this.labelControl1);
            this.groupControl_condition.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_condition.Location = new System.Drawing.Point(0, 0);
            this.groupControl_condition.Name = "groupControl_condition";
            this.groupControl_condition.Size = new System.Drawing.Size(215, 397);
            this.groupControl_condition.TabIndex = 0;
            this.groupControl_condition.Text = "Điều kiện thống kê";
            // 
            // checkedComboBoxEdit1
            // 
            this.checkedComboBoxEdit1.Location = new System.Drawing.Point(45, 247);
            this.checkedComboBoxEdit1.Name = "checkedComboBoxEdit1";
            this.checkedComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit1.Size = new System.Drawing.Size(100, 20);
            this.checkedComboBoxEdit1.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(135, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 28);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 150);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Loại thiết bị:";
            // 
            // ucTreeLoaiTB
            // 
            this.ucTreeLoaiTB.Location = new System.Drawing.Point(45, 172);
            this.ucTreeLoaiTB.Name = "ucTreeLoaiTB";
            this.ucTreeLoaiTB.Size = new System.Drawing.Size(147, 20);
            this.ucTreeLoaiTB.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Tình trạng:";
            // 
            // checkedComboBoxEdit_tinhTrang
            // 
            this.checkedComboBoxEdit_tinhTrang.EditValue = "";
            this.checkedComboBoxEdit_tinhTrang.Location = new System.Drawing.Point(45, 123);
            this.checkedComboBoxEdit_tinhTrang.Name = "checkedComboBoxEdit_tinhTrang";
            this.checkedComboBoxEdit_tinhTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEdit_tinhTrang.Properties.DisplayMember = "value";
            this.checkedComboBoxEdit_tinhTrang.Size = new System.Drawing.Size(147, 20);
            this.checkedComboBoxEdit_tinhTrang.TabIndex = 6;
            // 
            // dateEdit_to
            // 
            this.dateEdit_to.EditValue = null;
            this.dateEdit_to.Location = new System.Drawing.Point(45, 73);
            this.dateEdit_to.Name = "dateEdit_to";
            this.dateEdit_to.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_to.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_to.Size = new System.Drawing.Size(147, 20);
            this.dateEdit_to.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "đến";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(11, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "từ";
            // 
            // dateEdit_from
            // 
            this.dateEdit_from.EditValue = null;
            this.dateEdit_from.Location = new System.Drawing.Point(45, 47);
            this.dateEdit_from.Name = "dateEdit_from";
            this.dateEdit_from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_from.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_from.Size = new System.Drawing.Size(147, 20);
            this.dateEdit_from.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn ngày:";
            // 
            // ucTK_SLTB_TheoTinhTrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucTK_SLTB_TheoTinhTrang";
            this.Size = new System.Drawing.Size(756, 458);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_condition)).EndInit();
            this.groupControl_condition.ResumeLayout(false);
            this.groupControl_condition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEdit_tinhTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_to.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_to.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_from.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_from.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl_condition;
        private DevExpress.XtraEditors.DateEdit dateEdit_to;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateEdit_from;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit_tinhTrang;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private MyUC.ucTreeLoaiTB ucTreeLoaiTB;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEdit1;
    }
}