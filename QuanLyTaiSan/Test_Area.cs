﻿using QuanLyTaiSan.Entities;
using QuanLyTaiSan.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiSan
{
    public partial class Test_Area : Form
    {
        /*
         * 
         * Đang dính lỗi sau khi get object ra mà Dispose cái Context thì không truy xuất được FK obj => update lỗi kéo theo, do Lazy loading
         * Nếu không Dispose thì dính lỗi Multi Context Tracking (Tìm cách sửa chỗ này)
         * 
         * 
         * 
         */
        public Test_Area()
        {
            InitializeComponent();
            

            ////init Entity
            //QuanTriVien obj = new QuanTriVien();//context not init yet
            ////get from DB
            //obj = obj.getById(2);//new context created inside
            ////reference to FK obj via context
            //Console.WriteLine(obj.group.key);
            ////assign
            //obj.hoten = "new value";
            ////update
            //obj.update();//use existing context created before to avoid Exception because of multiple Context tracking
            
            //Console.WriteLine("Finish");

            //init Entity
            QuanTriVien obj = new QuanTriVien();//context not init yet
            //init new value
            obj.hoten = "hoten_shudghfgdf";
            obj.password = "password_6t37434";
            obj.username = "admin_ghyty6t734";
            //init new group
            Group gp = new Group(obj.DB);//context created using GET, SET procedure, passing context to Group obj
            //init new value
            gp.key = "admin333";
            gp.ten = "bhsgd6t34";
            gp.mota = "Quarn tri cap cao";
            //assign FK obj
            obj.group = gp;
            //add
            obj.add();//use existing context created before to avoid Exception because of multiple Context tracking, both "obj" and "gp" is under same context
            //update
            obj.update();//use existing context created before to avoid Exception because of multiple Context tracking

            Console.WriteLine("Finish");
        }
    }
}
