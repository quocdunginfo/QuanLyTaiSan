﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using QuanLyTaiSanGUI.MyUC;
using QuanLyTaiSan.Entities;
using QuanLyTaiSan.DataFilter;
using QuanLyTaiSan.Libraries;
using DevExpress.XtraEditors;

namespace QuanLyTaiSanGUI.QLCoSo.MyUserControl
{
    public partial class ucQuanLyCoSo : UserControl
    {
        List<ViTriFilter> listTree = new List<ViTriFilter>();
        ucTreeViTri _ucTreeViTri;
        ucTreeViTri _ucTreeViTriHaveDay;
        CoSo objCoSo = new CoSo();
        Dayy objDay = new Dayy();
        Tang objTang = new Tang();
        CoSo objCoSoNew = null;
        Dayy objDayNew = null;
        Tang objTangNew = null;
        String type = "";
        String function = "";
        String node = "";
		
        public ucQuanLyCoSo()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            listTree = new ViTriFilter().getAll();
            treeListViTri.DataSource = listTree;
            listTree = new ViTriFilter().getAllCoSo();
            _ucTreeViTri = new ucTreeViTri(listTree, false, false);
            listTree = new ViTriFilter().getAllHaveDay();
            _ucTreeViTriHaveDay = new ucTreeViTri(listTree, true, false);
        }

        private void treeListViTri_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            try
            {
                if (e.Node != null)
                {
                    SetTextGroupControl("Chi tiết", false);
                    if (function.Equals("edit") || function.Equals("add"))
                        enableEdit(false, "", "");
                    if (e.Node.GetValue(2).ToString().Equals(typeof(CoSo).Name))
                    {
                        objCoSo = new CoSo().getById(Convert.ToInt32(e.Node.GetValue(0)));
                        setData(typeof(CoSo).Name);
                    }
                    else if (e.Node.GetValue(2).ToString().Equals(typeof(Dayy).Name))
                    {
                        objDay = new Dayy().getById(Convert.ToInt32(e.Node.GetValue(0)));
                        setData(typeof(Dayy).Name);
                    }
                    else if (e.Node.GetValue(2).ToString().Equals(typeof(Tang).Name))
                    {
                        objTang = new Tang().getById(Convert.ToInt32(e.Node.GetValue(0)));
                        setData(typeof(Tang).Name);
                    }
                }
            }
            catch (Exception ex)
            { }
            finally
            { }
        }

        public void enableEdit(bool _enable, String _type, String _function)
        {
            function = _function;
            if (_enable)
            {
                btnImage.Visible = true;
                btnOK.Visible = true;
                btnHuy.Visible = true;
                txtTen.Properties.ReadOnly = false;
                txtMoTa.Properties.ReadOnly = false;
                _ucTreeViTri.setReadOnly(false);
                _ucTreeViTriHaveDay.setReadOnly(false);
                type = _type;
            }
            else
            {
                btnImage.Visible = false;
                btnOK.Visible = false;
                btnHuy.Visible = false;
                txtTen.Properties.ReadOnly = true;
                txtMoTa.Properties.ReadOnly = true;
                _ucTreeViTri.setReadOnly(true);
                _ucTreeViTriHaveDay.setReadOnly(true);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                switch (function)
                {
                    case "edit":
                        editObj(type);
                        break;
                    case "add":
                        addObj(type);
                        break;
                }
                enableEdit(false, "", "");
            }
        }

        private void editObj(String _type)
        {
            FindNode findNode = null;
            switch (_type)
            {
                case "CoSo":
                    objCoSo.ten = txtTen.Text;
                    objCoSo.mota = txtMoTa.Text;
                    objCoSo.hinhanhs = new List<HinhAnh>(listHinhAnh);
                    //objCoSo.date_modified = ServerTimeHelper.getNow();
                    if (objCoSo.update() != -1)
                    {
                        XtraMessageBox.Show("Sửa cơ sở thành công!");
                        reLoad();
                        findNode = new FindNode(objCoSo.id, typeof(CoSo).Name);
                        treeListViTri.NodesIterator.DoOperation(findNode);
                        treeListViTri.FocusedNode = findNode.Node;
                    }
                    else
                    {
                        XtraMessageBox.Show("Lỗi rồi!");
                    }
                    break;
                case "Dayy":
                    objDay.ten = txtTen.Text;
                    objDay.mota = txtMoTa.Text;
                    objDay.date_modified = ServerTimeHelper.getNow();
                    ViTri _vitri = _ucTreeViTri.getViTri(objDay.DB);
                    objDay.coso = _vitri.coso;
                    if (objDay.update() != -1)
                    {
                        XtraMessageBox.Show("Sửa dãy thành công!");
                        reLoad();
                        findNode = new FindNode(objDay.id, typeof(Dayy).Name);
                        treeListViTri.NodesIterator.DoOperation(findNode);
                        treeListViTri.FocusedNode = findNode.Node;
                    }
                    break;
                case "Tang":
                    objTang.ten = txtTen.Text;
                    objTang.mota = txtMoTa.Text;
                    objTang.date_modified = ServerTimeHelper.getNow();
                    ViTri _vitri2 = _ucTreeViTriHaveDay.getViTri(objTang.DB);
                    objTang.day = _vitri2.day;
                    if (objTang.update() != -1)
                    {
                        XtraMessageBox.Show("Sửa tầng thành công!");
                        reLoad();
                        findNode = new FindNode(objTang.id, typeof(Tang).Name);
                        treeListViTri.NodesIterator.DoOperation(findNode);
                        treeListViTri.FocusedNode = findNode.Node;
                    }
                    break;
            }
        }

        public void beforeAdd(String _type)
        {
            txtTen.Text = "";
            txtMoTa.Text = "";
            imageSlider1.Images.Clear();
            ViTri _vitri;
            type = _type;
            switch (_type)
            {
                case "CoSo":
                    objCoSoNew = new CoSo();
                    panelControl1.Controls.Clear();
                    TextEdit txt = new TextEdit();
                    txt.Properties.ReadOnly = true;
                    txt.Text = "Đại học Sài Gòn";
                    txt.Dock = DockStyle.Fill;
                    panelControl1.Controls.Add(txt);
                    break;
                case "Dayy":
                    objDayNew = new Dayy();
                    panelControl1.Controls.Clear();
                    _ucTreeViTri.Dock = DockStyle.Fill;
                    _vitri = new ViTri();
                    if (node.Equals(typeof(CoSo).Name))
                        _vitri.coso = objCoSo;
                    else if (node.Equals(typeof(Dayy).Name))
                        _vitri.coso = objDay.coso;
                    else
                        _vitri.coso = objTang.day.coso;
                    _ucTreeViTri.setViTri(_vitri);
                    panelControl1.Controls.Add(_ucTreeViTri);
                    break;
                case "Tang":
                    objTangNew = new Tang();
                    panelControl1.Controls.Clear();
                    _ucTreeViTriHaveDay.Dock = DockStyle.Fill;
                    _vitri = new ViTri();
                    if (node.Equals(typeof(Dayy).Name))
                    {
                        _vitri.coso = objDay.coso;
                        _vitri.day = objDay;
                    }
                    else
                    {
                        _vitri.coso = objTang.day.coso;
                        _vitri.day = objTang.day;
                    }
                    _ucTreeViTriHaveDay.setViTri(_vitri);
                    panelControl1.Controls.Add(_ucTreeViTriHaveDay);
                    break;
            }
        }

        private void addObj(String _type)
        {
            FindNode findNode = null;
            switch (_type)
            {
                case "CoSo":
                    //objCoSo = new CoSo();
                    objCoSoNew.ten = txtTen.Text;
                    objCoSoNew.mota = txtMoTa.Text;
                    objCoSoNew.date_create = ServerTimeHelper.getNow();
                    objCoSoNew.date_modified = ServerTimeHelper.getNow();
                    if (objCoSoNew.add() != -1)
                    {
                        XtraMessageBox.Show("Thêm cơ sở thành công!");
                        reLoad();
                        findNode = new FindNode(objCoSoNew.id, typeof(CoSo).Name);
                        treeListViTri.NodesIterator.DoOperation(findNode);
                        treeListViTri.FocusedNode = findNode.Node;
                    }
                    break;
                case "Dayy":
                    objDayNew.ten = txtTen.Text;
                    objDayNew.mota = txtMoTa.Text;
                    objDayNew.date_create = ServerTimeHelper.getNow();
                    objDayNew.date_modified = ServerTimeHelper.getNow();
                    ViTri _vitri = _ucTreeViTri.getViTri(objDayNew.DB);
                    objDayNew.coso = _vitri.coso;
                    if (objDayNew.add() != -1)
                    {
                        XtraMessageBox.Show("Thêm dãy thành công!");
                        reLoad();
                        findNode = new FindNode(objDayNew.id, typeof(Dayy).Name);
                        treeListViTri.NodesIterator.DoOperation(findNode);
                        treeListViTri.FocusedNode = findNode.Node;
                    }
                    break;
                case "Tang":
                    objTangNew.ten = txtTen.Text;
                    objTangNew.mota = txtMoTa.Text;
                    objTangNew.date_create = ServerTimeHelper.getNow();
                    objTangNew.date_modified = ServerTimeHelper.getNow();
                    ViTri _vitri2 = _ucTreeViTriHaveDay.getViTri(objTangNew.DB);
                    objTangNew.day = _vitri2.day;
                    if (objTangNew.add() != -1)
                    {
                        XtraMessageBox.Show("Thêm tầng thành công!");
                        reLoad();
                        findNode = new FindNode(objTangNew.id, typeof(Tang).Name);
                        treeListViTri.NodesIterator.DoOperation(findNode);
                        treeListViTri.FocusedNode = findNode.Node;
                    }
                    break;
            }
        }

        public void deleteObj(String _type)
        {
            switch (_type)
            {
                case "CoSo":
                    if (XtraMessageBox.Show("Bạn có chắc là muốn xóa cơ sở?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (objCoSo.delete() != -1)
                        {
                            XtraMessageBox.Show("Xóa cơ sở thành công!");
                            reLoad();
                        }
                    }
                    break;
                case "Dayy":
                    if (XtraMessageBox.Show("Bạn có chắc là muốn xóa dãy?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CoSo obj = objDay.coso;
                        if (objDay.delete() != -1)
                        {
                            XtraMessageBox.Show("Xóa dãy thành công!");
                            reLoad();
                        }
                    }
                    break;
                case "Tang":
                    if (XtraMessageBox.Show("Bạn có chắc là muốn xóa tầng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Dayy obj = objTang.day;
                        if (objTang.delete() != -1)
                        {
                            XtraMessageBox.Show("Xóa tầng thành công!");
                            reLoad();
                        }
                    }
                    break;
            }
        }

        private void reLoad()
        {
            errorProvider1.Clear();
            treeListViTri.ClearNodes();
            listTree = new ViTriFilter().getAll();
            treeListViTri.DataSource = listTree;
            //kiem tra truoc khi reload
            listTree = new ViTriFilter().getAllCoSo();
            _ucTreeViTri.reLoad(listTree);
            listTree = new ViTriFilter().getAllHaveDay();
            _ucTreeViTriHaveDay.reLoad(listTree);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            enableEdit(false, "", "");
            errorProvider1.Clear();
            SetTextGroupControl("Chi tiết", false);
            errorProvider1.Clear();
            setData(node);
        }

        public void SetTextGroupControl(String _text, bool _color)
        {
            groupControl1.Text = _text;
            if(_color)
                groupControl1.AppearanceCaption.ForeColor = Color.Red;
            else
                groupControl1.AppearanceCaption.ForeColor = Color.Black;   
        }

        private Boolean CheckInput()
        {
            errorProvider1.Clear();
            Boolean check = true;
            if (txtTen.Text.Length == 0)
            {
                check = false;
                errorProvider1.SetError(txtTen, "Chưa điền tên");
            }
            return check;
        }

        private void reloadImage()
        {
            List<HinhAnh> hinhs = null;
            if (function.Equals(""))
            {
                switch (node)
                {
                    case "CoSo":
                        hinhs = objCoSo.hinhanhs.ToList();
                        break;
                    case "Dayy":
                        hinhs = objDay.hinhanhs.ToList();
                        break;
                    case "Tang":
                        hinhs = objTang.hinhanhs.ToList();
                        break;
                }
            }
            else
            {
                if (listHinhAnh.Count > 0)
                {
                    case "CoSo":
                        hinhs = objCoSoNew.hinhanhs.ToList();
                        break;
                    case "Dayy":
                        hinhs = objDayNew.hinhanhs.ToList();
                        break;
                    case "Tang":
                        hinhs = objTangNew.hinhanhs.ToList();
                        break;
                }
            }
            //if (!function.Equals("add"))
            //{
            //    switch (node)
            //    {
            //        case "CoSo":
            //            hinhs = objCoSo.hinhanhs.ToList();
            //            break;
            //        case "Dayy":
            //            hinhs = objDay.hinhanhs.ToList();
            //            break;
            //        case "Tang":
            //            hinhs = objTang.hinhanhs.ToList();
            //            break;
            //    }
            //}
            //else
            //{
            //    switch (type)
            //    {
            //        case "CoSo":
            //            hinhs = objCoSo.hinhanhs.ToList();
            //            break;
            //        case "Dayy":
            //            hinhs = objDay.hinhanhs.ToList();
            //            break;
            //        case "Tang":
            //            hinhs = objTang.hinhanhs.ToList();
            //            break;
            //    }
            //}
            imageSlider1.Images.Clear();
            foreach (HinhAnh h in hinhs)
            {
                imageSlider1.Images.Add(h.getImage());
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                frmHinhAnh frm = null;
                switch (type)
                {
                    case "CoSo":
                        //frm = new frmHinhAnh(objCoSo.id, objCoSo.hinhanhs.ToList(), typeof(CoSo).Name);
                        if (function.Equals("edit"))
                        {
                            if (!(listHinhAnh.Count > 0))
                            {
                                listHinhAnh = objCoSo.hinhanhs.ToList();
                            }
                            frm = new frmHinhAnh(listHinhAnh, objCoSo.DB);
                            frm.Text = "Quản lý hình ảnh " + objCoSo.ten;
                            frm.ShowDialog();
                            //objCoSo.hinhanhs = frm.getHinhAnhs();
                        }
                        else
                        {
                            if (objCoSoNew.hinhanhs == null)
                            objCoSoNew.hinhanhs = new List<HinhAnh>();
                            frm = new frmHinhAnh(objCoSoNew.hinhanhs.ToList(), objCoSoNew.DB);
                            frm.Text = "Quản lý hình ảnh cơ sở mới";
                            frm.ShowDialog();
                            objCoSoNew.hinhanhs = frm.getHinhAnhs();
                        }
                        break;
                    case "Dayy":
                        if (function.Equals("edit"))
                        {
                            frm = new frmHinhAnh(objDay.hinhanhs.ToList(), objDay.DB);
                            frm.Text = "Quản lý hình ảnh " + objDay.ten;
                            frm.ShowDialog();
                            objDay.hinhanhs = frm.getHinhAnhs();
                        }
                        else
                        {
                            if (objDayNew.hinhanhs == null)
                            objDayNew.hinhanhs = new List<HinhAnh>();
                            frm = new frmHinhAnh(objDayNew.hinhanhs.ToList(), objDayNew.DB);
                            frm.Text = "Quản lý hình ảnh dãy mới";
                            frm.ShowDialog();
                            objDayNew.hinhanhs = frm.getHinhAnhs();
                        }
                        //frm = new frmHinhAnh(objDay.id, objDay.hinhanhs.ToList(), typeof(Dayy).Name);
                        //frm.Text = "Quản lý hình ảnh của dãy";
                        //frm.ShowDialog();
                        //objDay = new Dayy().getById(objDay.id);
                        break;
                    case "Tang":
                        if (function.Equals("edit"))
                        {
                            frm = new frmHinhAnh(objTang.hinhanhs.ToList(), objTang.DB);
                            frm.Text = "Quản lý hình ảnh " + objTang.ten;
                            frm.ShowDialog();
                            objTang.hinhanhs = frm.getHinhAnhs();
                        }
                        else
                        {
                            if (objTangNew.hinhanhs == null)
                            objTangNew.hinhanhs = new List<HinhAnh>();
                            frm = new frmHinhAnh(objTangNew.hinhanhs.ToList(), objTangNew.DB);
                            frm.Text = "Quản lý hình ảnh tầng mới";
                            frm.ShowDialog();
                            objTangNew.hinhanhs = frm.getHinhAnhs();
                        }
                        //frm = new frmHinhAnh(objTang.id, objTang.hinhanhs.ToList(), typeof(Tang).Name);
                        //frm.Text = "Quản lý hình ảnh của tầng";
                        //frm.ShowDialog();
                        //objTang = new Tang().getById(objTang.id);
                        break;
                }

                reloadImage();
            }
            catch (Exception ex)
            { }
            finally
            { }
        }

        public void setData(String _type)
        {
            ViTri objViTri = null;
            switch (_type)
            {
                case "CoSo":
                    txtTen.Text = objCoSo.ten;
                    txtMoTa.Text = objCoSo.mota;
                    panelControl1.Controls.Clear();
                    TextEdit txt = new TextEdit();
                    txt.Properties.ReadOnly = true;
                    txt.Text = "Đại học Sài Gòn";
                    txt.Dock = DockStyle.Fill;
                    panelControl1.Controls.Add(txt);
                    node = typeof(CoSo).Name;
                    reloadImage();
                    if (this.ParentForm != null)
                    {
                        frmMain frm = (frmMain)this.ParentForm;
                        frm.enableGroupViTri(typeof(CoSo).Name);
                    }
                    break;
                case "Dayy":
                    panelControl1.Controls.Clear();
                    _ucTreeViTri.Dock = DockStyle.Fill;
                    panelControl1.Controls.Add(_ucTreeViTri);
                    txtTen.Text = objDay.ten;
                    txtMoTa.Text = objDay.mota;
                    objViTri = new ViTri();
                    objViTri.coso = objDay.coso;
                    _ucTreeViTri.setViTri(objViTri);
                    node = typeof(Dayy).Name;
                    reloadImage();
                    if (this.ParentForm != null)
                    {
                        frmMain frm = (frmMain)this.ParentForm;
                        frm.enableGroupViTri(typeof(Dayy).Name);
                    }
                    break;
                case "Tang":
                    panelControl1.Controls.Clear();
                    _ucTreeViTriHaveDay.Dock = DockStyle.Fill;
                    panelControl1.Controls.Add(_ucTreeViTriHaveDay);
                    txtTen.Text = objTang.ten;
                    txtMoTa.Text = objTang.mota;
                    objViTri = new ViTri();
                    objViTri.day = objTang.day;
                    objViTri.coso = objTang.day.coso;
                    _ucTreeViTriHaveDay.setViTri(objViTri);
                    node = typeof(Tang).Name;
                    reloadImage();
                    if (this.ParentForm != null)
                    {
                        frmMain frm = (frmMain)this.ParentForm;
                        frm.enableGroupViTri(typeof(Tang).Name);
                    }
                    break;
            }
        }

    }
}