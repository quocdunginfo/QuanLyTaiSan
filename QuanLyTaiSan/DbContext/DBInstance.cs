﻿using QuanLyTaiSan.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace QuanLyTaiSan.Entities
{
    public class DBInstance
    {
        private static OurDBContext db = null;
        public static OurDBContext DB
        {
            get
            {
                if (db == null)
                {
                    if (Global.working_database.use_internal_config)
                    {
                        db = new OurDBContext();
                    }
                    else
                    {
                        //by default, point to working database
                        db = new OurDBContext(Global.working_database.get_connection_string());
                    }
                }
                
                if (!db.Database.Exists())
                {
                    //DB CONNECTION FAIl
                    Debug.WriteLine("=========DB CONNECTION FAIL==========");
                }
                return db;
            }
        }
        /// <summary>
        /// Bắt buộc phải gọi mới thấy được sự thay đổi CSDL do nơi khác chỉnh sửa,
        /// Tất cả Object get ra bởi DBInstace cũ sẽ phải reload mới có thể tiếp tục sử dụng lại được,
        /// Nếu không Object cũ sẽ vẫn phải chịu sự giám sát của DbContext cũ
        /// </summary>
        public static void reNew()
        {
            if (db != null)
            {
                db.Dispose();
                db = null;
            }
            
            db = DB;
        }
        public static void autoRandom()
        {
            Random rd = new Random();
            DBInstance.reNew();
            List<CoSo> list_coso = new List<CoSo>();
            List<Dayy> list_day = new List<Dayy>();
            List<Tang> list_tang = new List<Tang>();
            HinhAnh hinhanh = new HinhAnh();
            //generate CS
            for (int i = 0; i < 5; i++)
            {
                CoSo tmp = new CoSo();
                tmp.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                tmp.subId = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                tmp.ten = "Cơ sở " + i;
                tmp.date_create = tmp.date_modified = DateTime.Now;

                tmp.hinhanhs.Add(new HinhAnh { path = rd.Next(10)+".JPEG"});
                list_coso.Add(tmp);

                //generate DAY
                for (int j = 0; j < 5; j++)
                {
                    Dayy tmpd = new Dayy();
                    tmpd.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpd.subId = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpd.ten = "Dãy " + j;
                    tmpd.hinhanhs.Add(new HinhAnh { path = rd.Next(10) + ".JPEG" });
                    tmpd.date_create = tmpd.date_modified = DateTime.Now;
                    tmpd.coso = tmp;

                    list_day.Add(tmpd);

                    //generate Tang
                    for (int t = 0; t < 5; t++)
                    {
                        Tang tmpt = new Tang();
                        tmpt.date_create = tmpt.date_modified = DateTime.Now;
                        tmpt.day = tmpd;
                        tmpt.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                        tmpt.subId = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                        tmpt.ten = "Tầng " + t;
                        tmpt.day = tmpd;
                        tmpt.hinhanhs.Add(new HinhAnh { path = rd.Next(10) + ".JPEG" });

                        list_tang.Add(tmpt);
                    }
                }
            }
            DB.TANGS.AddRange(list_tang);
            DB.SaveChanges();

            //generate LTB
            List<LoaiThietBi> ltb_list = new List<LoaiThietBi>();
            for(int i=0;i<20;i++)
            {
                LoaiThietBi tmp = new LoaiThietBi();
                tmp.date_create = tmp.date_modified = DateTime.Now;
                tmp.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                tmp.ten = "Thiết bị "+i;
                tmp.parent = null;
                ltb_list.Add(tmp);
                //generate childs
                for(int j=0;j<3;j++)
                {
                    LoaiThietBi tmpc = new LoaiThietBi();
                    tmpc.date_create = tmpc.date_modified = DateTime.Now;
                    tmpc.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpc.parent = tmp;
                    tmpc.ten = "Thiết bị "+i+j;
                    ltb_list.Add(tmpc);
                }
            }

            List<TinhTrang> list_tinhtrang = new List<TinhTrang>();
            //generate tinh trang
            for(int i=0;i<=4;i++)
            {
                TinhTrang tmp = new TinhTrang();
                tmp.key = "tinhtrang"+i;
                tmp.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                tmp.value = "Tình trạng "+i;

                list_tinhtrang.Add(tmp);
            }

            //generate vitri
            List<ViTri> list_vitri = new List<ViTri>();
            List<Phong> list_phong = new List<Phong>();
            List<NhanVienPT> list_nvpt = new List<NhanVienPT>();
            List<ThietBi> list_tb = new List<ThietBi>();
            List<CTThietBi> list_cttb = new List<CTThietBi>();
            for (int i = 0; i < list_tang.Count; i++)
            {
                ViTri tmp = new ViTri();
                tmp.tang = list_tang[i];
                tmp.day = tmp.tang.day;
                tmp.coso = tmp.day.coso;

                list_vitri.Add(tmp);

                //generate Phong
                for (int j = 0; j < 10; j++)
                {
                    Phong tmpp = new Phong();
                    tmpp.date_create = tmpp.date_modified = DateTime.Now;
                    tmpp.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpp.subId = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpp.ten = "Phòng "+j;
                    tmpp.vitri = tmp;
                    tmpp.hinhanhs.Add(new HinhAnh { path = rd.Next(10) + ".JPEG" });
                    //generate NVPT
                    tmpp.nhanvienpt = new NhanVienPT();
                    tmpp.nhanvienpt.date_create = tmpp.nhanvienpt.date_modified = DateTime.Now;
                    tmpp.nhanvienpt.subId = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpp.nhanvienpt.hoten = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpp.nhanvienpt.sodienthoai = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                    tmpp.nhanvienpt.hinhanhs.Add(new HinhAnh { path = rd.Next(10) + ".JPEG" });
                    list_nvpt.Add(tmpp.nhanvienpt);
                    list_phong.Add(tmpp);
                    //generate TB
                    for (int t = 0; t < 20; t++)
                    {
                        ThietBi tmpb = new ThietBi();
                        tmpb.date_create = tmpb.date_modified = DateTime.Now;
                        tmpb.loaithietbi = ltb_list[rd.Next(ltb_list.Count)];
                        tmpb.mota = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                        tmpb.ngaylap = tmpb.ngaymua = DateTime.Now;
                        tmpb.subId = DateTime.Now.ToString("dd-MM-yyyy H:i:s.ffff");
                        tmpb.ten = "Thiết bị "+t;
                        tmpb.hinhanhs.Add(new HinhAnh { path = rd.Next(10) + ".JPEG" });

                        list_tb.Add(tmpb);

                        //generate CTTB
                        CTThietBi tmpct = new CTThietBi();
                        tmpct.phong = tmpp;
                        tmpct.soluong = rd.Next(10)+1;
                        tmpct.thietbi = tmpb;
                        tmpct.tinhtrang = list_tinhtrang[rd.Next(list_tinhtrang.Count)];

                        list_cttb.Add(tmpct);

                        DB.CTTHIETBIS.Add(tmpct);
                        DB.SaveChanges();
                        Console.WriteLine(list_cttb.Count);
                    }
                }
            }
            //DBInstance.DB.TANGS.AddRange(list_tang);
            //DBInstance.DB.LOAITHIETBIS.AddRange(ltb_list);
            Console.WriteLine("CTTB: "+list_cttb.Count);
        }
        public static void TaoDuLieuMau()
        {
            //Cơ sở
            List<CoSo> list_coso = new List<CoSo>();
            CoSo coso = new CoSo();
            coso.mota = "Chưa có";
            coso.subId = "CSC";
            coso.ten = "Cơ sở chính";
            list_coso.Add(coso);

            coso = new CoSo();
            coso.mota = "Chưa có";
            coso.subId = "CS1";
            coso.ten = "Cơ sở 1";
            list_coso.Add(coso);

            coso = new CoSo();
            coso.mota = "Chưa có";
            coso.subId = "CS2";
            coso.ten = "Cơ sở 2";
            list_coso.Add(coso);

            foreach (CoSo item in list_coso)
            {
                CoSo tmp = DB.COSOS.FirstOrDefault(c => c.subId.ToUpper().Equals(item.subId.ToUpper()));
                if (tmp == null)
                {
                    item.add();
                }
            }
            coso = DB.COSOS.FirstOrDefault(c=>c.subId.ToUpper().Equals("CSC"));
            //Dãy
            List<Dayy> list_day = new List<Dayy>();
            Dayy day = new Dayy();
            day.mota = "Chưa có";
            day.subId = "DAYA";
            day.ten = "Dãy A";
            day.coso = coso;
            list_day.Add(day);

            day = new Dayy();
            day.mota = "Chưa có";
            day.subId = "DAYB";
            day.ten = "Dãy B";
            day.coso = coso;
            list_day.Add(day);

            day = new Dayy();
            day.mota = "Chưa có";
            day.subId = "DAYC";
            day.ten = "Dãy C";
            day.coso = coso;
            list_day.Add(day);
            
            foreach (Dayy item in list_day)
            {
                Dayy tmp = DB.DAYYS.FirstOrDefault(c => c.subId.ToUpper().Equals(item.subId.ToUpper()) && c.coso.id == item.coso.id);
                if (tmp == null)
                {
                    item.add();
                }
            }
            day = DB.DAYYS.FirstOrDefault(c => c.subId.ToUpper().Equals("DAYA") && c.coso.subId.Equals("CSC"));
            //Tầng
            List<Tang> list_tang = new List<Tang>();
            Tang tang = new Tang();
            tang.mota = "Chưa có";
            tang.subId = "TANG1";
            tang.day = day;
            tang.ten = "Tầng 1";
            list_tang.Add(tang);

            tang = new Tang();
            tang.mota = "Chưa có";
            tang.subId = "TANG2";
            tang.day = day;
            tang.ten = "Tầng 2";
            list_tang.Add(tang);

            tang = new Tang();
            tang.mota = "Chưa có";
            tang.subId = "TANG3";
            tang.day = day;
            tang.ten = "Tầng 3";
            list_tang.Add(tang);

            foreach (Tang item in list_tang)
            {
                Tang tmp = DB.TANGS.FirstOrDefault(c => c.subId.ToUpper().Equals(item.subId.ToUpper()) && c.day.id == item.day.id);
                if (tmp == null)
                {
                    item.add();
                }
            }
            tang = DB.TANGS.FirstOrDefault(c=>c.subId.ToUpper().Equals("TANG1") && c.day.subId.ToUpper().Equals("DAYA") && c.day.coso.subId.ToUpper().Equals("CSC"));
            //Vị trí
            List<ViTri> list_vitri = new List<ViTri>();
            ViTri vitri = new ViTri();
            vitri.coso = coso;
            vitri.day = day;
            vitri.tang = tang;
            list_vitri.Add(vitri);

            foreach (ViTri item in list_vitri)
            {
                ViTri tmp = DB.VITRIS.FirstOrDefault(c=>c.coso.id == item.coso.id && c.day.id == item.day.id && c.tang.id ==item.tang.id);
                if (tmp == null)
                {
                    item.add();
                }
            }

            
        }
    }
}
