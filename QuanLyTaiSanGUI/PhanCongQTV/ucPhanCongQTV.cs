﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTB.Entities;
using PTB.DataFilter;
using SHARED.Libraries;

namespace PTB_GUI.PhanCongQTV
{
    public partial class ucPhanCongQTV : UserControl,_ourUcInterface
    {
        //QuanLyTaiSanGUI.MyUC.ucTreePhongHaveCheck _ucTreePhongHaveCheck = new QuanLyTaiSanGUI.MyUC.ucTreePhongHaveCheck(true);
        MyUC.ucTreePhongHaveCheck _ucTreePhongHaveCheck = new MyUC.ucTreePhongHaveCheck();
        List<QuanTriVien> QuanTriViens = new List<QuanTriVien>();
        List<Phong> listPhong = new List<Phong>();
        QuanTriVien objQuanTriVien = new QuanTriVien();
        Boolean working = false;
        bool canPhanCong = false;

        MyUC.MyLayout layout = new MyUC.MyLayout();

        public ucPhanCongQTV()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            ribbonPhanCongQTV.Parent = null;
            _ucTreePhongHaveCheck.Dock = DockStyle.Fill;
            _ucTreePhongHaveCheck.loadListPhong = new MyUC.ucTreePhongHaveCheck.LoadListPhong(LoadListPhong);
            listBoxPhong.SortOrder = SortOrder.Ascending;
            layout.save(gridViewQuanTriVien);
        }

        public void loadData()
        {
            try
            {
                checkPermission();
                PhanCong(false);
                layout.load(gridViewQuanTriVien);
                QuanTriViens = QuanTriVien.getQuery().OrderBy(c=>c.hoten).ToList();
                gridControlQuanTriVien.DataSource = QuanTriViens;
                if (QuanTriViens.Count == 0)
                {
                    barBtnPhanCong.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(this.Name + "->loadData: " + ex.Message);
            }
        }

        private void checkPermission()
        {
            canPhanCong = Permission.canEdit<Phong>(null);
        }

        public void PhanCong(bool _bool)
        {
            try
            {
                splitContainerControl1.Panel1.Controls.Clear();
                if (_bool)
                {
                    List<ViTriHienThi> listVT = ViTriHienThi.getAllHavePhongNotQuanTriVien(objQuanTriVien.id);
                    _ucTreePhongHaveCheck.loadData(listVT, objQuanTriVien);
                    splitContainerControl1.Panel1.Controls.Add(_ucTreePhongHaveCheck);
                }
                else
                {
                    splitContainerControl1.Panel1.Controls.Add(gridControlQuanTriVien);
                }
                working = _bool;
                btnOK.Visible = _bool;
                btnHuy.Visible = _bool;
                barBtnPhanCong.Enabled = !_bool && canPhanCong;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(this.Name + "->PhanCong: " + ex.Message);
            }
        }

        public DevExpress.XtraBars.Ribbon.RibbonControl getRibbon()
        {
            return ribbonPhanCongQTV;
        }

        private void gridViewQuanTriVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            setDataView();
        }

        private void clearText()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtUsername.Text = "";
            listBoxPhong.DataSource = null;
        }

        private void setDataView()
        {
            try
            {
                if (gridViewQuanTriVien.RowCount > 0)
                {
                    if (gridViewQuanTriVien.FocusedRowHandle > -1 && gridViewQuanTriVien.GetFocusedRow() != null)
                    {
                        objQuanTriVien = gridViewQuanTriVien.GetFocusedRow() as QuanTriVien;
                        txtMa.Text = objQuanTriVien.subId;
                        txtTen.Text = objQuanTriVien.hoten;
                        txtUsername.Text = objQuanTriVien.username;
                        txtMota.Text = objQuanTriVien.mota;
                        listPhong = objQuanTriVien.phongs.ToList();
                        listBoxPhong.DataSource = listPhong;
                    }
                    else
                    {
                        clearText();
                        objQuanTriVien = new QuanTriVien();
                    }
                }
                else
                {
                    clearText();
                    objQuanTriVien = new QuanTriVien();
                }
                checkPermission();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(this.Name + "->setDataView: " + ex.Message);
            }
        }

        private void barBtnPhanCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhanCong(true);
        }

        private void LoadListPhong(List<Phong> list)
        {
            listBoxPhong.DataSource = list;
            listPhong = list;
        }

        private void gridViewQuanTriVien_DataSourceChanged(object sender, EventArgs e)
        {
            setDataView();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this.ParentForm, typeof(WaitForm1), true, true, false);
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Đang phân công...");
            Guid id = objQuanTriVien.id;
            try
            {
                objQuanTriVien.phongs.Clear();
                objQuanTriVien.phongs = listPhong;
                ////Quan hệ 0 - n nên không thể gán list
                //List<Phong> listToRemove = objQuanTriVien.phongs.ToList();
                //foreach (Phong objToRemove in listToRemove)
                //{
                //    objToRemove.quantrivien = null;
                //    objToRemove.update();
                //}
                //foreach (Phong objToAdd in listPhong)
                //{
                //    objToAdd.quantrivien = objQuanTriVien;
                //    objToAdd.update();
                //}
                if (DBInstance.commit() > 0)
                {
                    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Phân công quản trị viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhanCong(false);
                    reLoadAndFocused(id);
                }
                else
                {
                    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
                    DevExpress.XtraEditors.XtraMessageBox.Show("Phân công quản trị viên không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
                Debug.WriteLine(this.Name + "->btnOK_Click: " + ex.Message);
            }
        }

        private void reLoadAndFocused(Guid _id)
        {
            try
            {
                loadData();
                int rowHandle = gridViewQuanTriVien.LocateByValue(colid.FieldName, _id);
                if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    gridViewQuanTriVien.FocusedRowHandle = rowHandle;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(this.Name + "->reLoadAndFocused: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Guid id = objQuanTriVien.id;
            PhanCong(false);
            int rowHandle = gridViewQuanTriVien.LocateByValue(colid.FieldName, id);
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                gridViewQuanTriVien.FocusedRowHandle = rowHandle;
        }

        public bool checkworking()
        {
            try
            {
                if (working)
                {
                    return
                        objQuanTriVien.phongs.Except(listPhong).Count() > 0 ||
                        listPhong.Except(objQuanTriVien.phongs).Count() > 0;
                }
                else 
                    return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(this.Name + "->checkworking: " + ex.Message);
                return true;
            }
        }

        public void reLoad()
        {
            throw new NotImplementedException();
        }
    }
}
