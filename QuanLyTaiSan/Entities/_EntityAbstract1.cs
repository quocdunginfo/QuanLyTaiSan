﻿using QuanLyTaiSan.Entities;
using QuanLyTaiSan.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan.Entities
{
    /// <summary>
    /// Định nghĩa cơ bản mà mọi Entity phải có
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class _EntityAbstract1<T> : _EFEventRegisterInterface, _CRUDInterface<T> where T : _EntityAbstract1<T>
    {
        public _EntityAbstract1()
        {
            //Need to find out another approach, reporting by code analysized
            //it will call TOP level first
            init();
        }
        #region Định nghĩa
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        /// <summary>
        /// Optional
        /// </summary>
        public String subId { get; set; }

        /// <summary>
        /// Dùng để sắp xếp, mặc định khi thêm mới thì sẽ bật trigger để tự lấy id qua
        /// </summary>
        public int? order { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        public String mota { get; set; }
        /// <summary>
        /// Ngay record insert vao he thong
        /// Optional
        /// </summary>
        public DateTime? date_create { get; set; }
        /// <summary>
        /// Ngay record updated gan day nhat
        /// Optional
        /// </summary>
        public DateTime? date_modified { get; set; }
        #endregion
        
        #region Nghiệp vụ
        protected virtual void init()
        {
            
        }
        /*
         * Method of interface
         */
        [NotMapped]
        protected static OurDBContext db
        {
            get
            {
                return DBInstance.DB;
            }
        }
        /// <summary>
        /// Tự động add nếu chưa có trong CSDL
        /// </summary>
        /// <returns></returns>
        public virtual int add()
        {
            //Nếu đã có trong CSDL rồi
            if (id > 0)
            {
                return id;
            }

            try
            {
                //script
                db.Set<T>().Add((T)this);
                //db.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                //db.Set<T>().Remove((T)this);//remove if fail
                return -1;
            }
        }

        public virtual int update()
        {
            //Nếu chưa có trong CSDL
            if (id <= 0)
            {
                return -1;
            }

            try
            {
                //have to use if autodetectchange off
                //db.Entry(this).State = EntityState.Modified;
                return 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
        }

        public virtual int delete()
        {
            //Nếu chưa có trong CSDL
            if (id <= 0)
            {
                return -1;
            }

            try
            {
                db.Set<T>().Remove((T)this);
                
                //END
                return 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                //nếu bị lỗi thì Attach lại, để không bị mất khóa ngoại, cháu chắt
                db.Set<T>().Attach((T)this);
                return -1;
            }
        }
        public static T getById(int id)
        {
            try
            {
                return db.Set<T>().Find(id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return null;
            }
        }
        /// <summary>
        /// Có thể query trên danh sách sau đó mới trả về List,
        /// Sẽ nhanh hơn nhiều so với getAll,
        /// Có thể quăng Exception do mất kết nối tới Database (Cần tìm phương án khắc phục)
        /// </summary>
        /// <returns></returns>
        public static IQueryable<T> getQuery()
        {
            //if (db.Database.Connection.State == ConnectionState.Broken ||
            //    db.Database.Connection.State == ConnectionState.Closed
            //    )
            //{
            //    return new List<T>().AsQueryable<T>();
            //}
            try
            {
                db.Set<T>().AsQueryable().FirstOrDefault();
                return db.Set<T>().AsQueryable<T>();
            }
            catch (Exception)
            {
                return new List<T>().AsQueryable<T>();
            }
        }
        /// <summary>
        /// Sử dụng để đổ DataSource nhanh,
        /// Muốn query được thì nên sử dụng getQuery sẽ nhanh hơn
        /// </summary>
        /// <returns></returns>
        public static List<T> getAll()
        {
            try
            {
                return db.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return new List<T>();
            }
        }
        /// <summary>
        /// Clone nguyên list ra list mới, giữ nguyên khóa ngoại
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<T> clone(List<T> list)
        {
            if (list == null || list.Count <= 0)
            {
                return new List<T>();
            }
            List<T> tmp = new List<T>();
            foreach (T item in list)
            {
                tmp.Add(item.clone());
            }
            return tmp;
        }
        /// <summary>
        /// Load lại Object theo DBContext mới trong DBInstance (Vì có thể đã bị new mới bởi ai đó)
        /// Cần có id trước
        /// </summary>
        /// <returns></returns>
        public virtual T reload()
        {
            if (id <= 0)
            {
                return null;
            }

            try
            {
                db.Entry(this).Reload();
                return (T)this;
            }
            catch (Exception)
            {
                try
                {
                    //Case 1: Multi db context tracking
                    //Case 2: Object not loaded before
                    return db.Set<T>().Find(this.id);
                }
                catch (Exception ex)
                {
                    //for any other error
                    Debug.WriteLine(ex.ToString());
                    return null;
                }
            }
        }
        /// <summary>
        /// Force to load object because of Lazy Loading,
        /// Have to use when call update procedure or you
        /// got Validation Excaption
        /// 
        /// </summary>
        public void trigger()
        {
            //DO NOT THING, JUST ACTIVATE ENTITY FRAMEWORK TO LOAD
        }
        public static List<T> convert(int[] id_array)
        {
            return convert(id_array.ToList());
        }
        public static List<T> convert(List<int> id_array)
        {
            List<T> re = new List<T>();
            foreach (int item in id_array)
            {
                T tmp = getById(item);
                if (tmp != null)
                {
                    re.Add(tmp);
                }
            }
            return re;
        }
        /// <summary>
        /// Clone to new Object
        /// </summary>
        /// <returns></returns>
        public virtual T clone()
        {
            //T tmp = db.Set<T>().AsNoTracking<T>().Where(c => c.id == this.id).FirstOrDefault();
            //if (tmp == null)
            //{
            //    return null;
            //}
            //tmp.id = 0;
            //return tmp;
            return null;
        }
        /// <summary>
        /// Move object lên 1 nấc (sử dụng trường order),
        /// Tự động update
        /// </summary>
        public virtual void moveUp()
        {
            T prev = db.Set<T>().Where(c => c.order < this.order).OrderByDescending(c => c.order).FirstOrDefault();
            if (prev == null)
            {
                return;
            }
            //SWAP order value
            int? order_1 = this.order == null ? this.id : this.order;
            int? order_2 = prev.order == null ? prev.id : prev.order;

            this.order = order_2;
            prev.order = order_1;

            this.update();
            prev.update();
        }

        /// <summary>
        /// Move object xuống 1 nấc (sử dụng trường order),
        /// Tự động update
        /// </summary>
        public virtual void moveDown()
        {
            T next = db.Set<T>().Where(c => c.order > this.order).OrderBy(c => c.order).FirstOrDefault();
            if (next == null)
            {
                return;
            }
            next.moveUp();
        }
        /// <summary>
        /// Build log hệ thống cho this
        /// </summary>
        /// <param name="action_name"></param>
        /// <returns></returns>
        private Dictionary<string, string> buildLog(String action_name=null)
        {
            Dictionary<string, string> re = new Dictionary<string, string>();
            if(Global.current_quantrivien_login!=null)
            {
                re.Add("uName", Global.current_quantrivien_login.username + " | " +Global.current_quantrivien_login.hoten);
                re.Add("uID", Global.current_quantrivien_login.id.ToString());
            }
            if (action_name != null && !action_name.Equals(""))
            {
                re.Add("action", action_name);
            }
            re.Add("objType", typeof(T).Name);
            try
            {
                //Hình thức ghép: username | ten | hoten
                List<string> nicename = new List<string>();

                var ppp = this.GetType().GetProperty("username");
                if (ppp != null)
                {
                    nicename.Add(ppp.GetValue(this).ToString());
                }
                ppp = this.GetType().GetProperty("ten");
                if (ppp != null)
                {
                    nicename.Add(ppp.GetValue(this).ToString());
                }
                ppp = this.GetType().GetProperty("hoten");
                if (ppp != null)
                {
                    nicename.Add(ppp.GetValue(this).ToString());
                }
                
                //
                if (nicename != null && nicename.Count>0)
                {
                    re.Add("objName", String.Join(" | ", nicename));
                    nicename = null;
                }
            }
            catch (Exception)
            {

            }
            re.Add("objID", this.id.ToString());
            return re;
        }
        #endregion
        
        #region Event register
        /// <summary>
        /// Kiểm tra Entity type hiện tại có cần phải ghi log ?
        /// </summary>
        /// <returns></returns>
        private Boolean needToWriteLogHeThong()
        {
            //DO NOT WRITE LOG FOR LOGHETHONG (LOOPBACK!)
            return (
                this is CoSo
                || this is Dayy
                || this is Tang
                || this is CTThietBi
                || this is PhieuMuonPhong
                || this is ThietBi
                || this is QuanTriVien
                || this is Group
                || this is LoaiThietBi
                || this is NhanVienPT
                || this is Phong
                || this is Setting
                || this is SuCoPhong
                || this is TinhTrang
                );
        }
        /// <summary>
        /// Chạy nghiệp vụ trước khi bị xóa
        /// </summary>
        public virtual void onBeforeDeleted()
        {
            //DO NOT WRITE LOG FOR LOGHETHONG (LOOPBACK!)
            if (needToWriteLogHeThong())
            {
                LogHeThong log = new LogHeThong();
                log.onBeforeAdded();
                //quocdunginfo fail (conflict with write log hethong)
                log.mota = StringHelper.toJSON(buildLog("delete"));
                log.add();
            }
        }
        /// <summary>
        /// Chạy nghiệp vụ trước khi được cập nhật vào CSDL
        /// </summary>
        public virtual void onBeforeUpdated()
        {
            date_modified = ServerTimeHelper.getNow();
        }
        /// <summary>
        /// Chạy nghiệp vụ trước khi được thêm vào CSDL
        /// </summary>
        public virtual void onBeforeAdded()
        {
            //time
            date_create = date_modified = (date_create == null) ? ServerTimeHelper.getNow() : date_create;
        }

        public void onAfterUpdated()
        {
            //DO NOT WRITE LOG FOR LOGHETHONG (LOOPBACK!)
            if (needToWriteLogHeThong())
            {
                LogHeThong log = new LogHeThong();
                log.onBeforeAdded();//MANUAL MODE
                log.mota = StringHelper.toJSON(buildLog("edit"));
                log.add();
            }
        }

        public void onAfterAdded()
        {
            //AUTO ORDER
            this.order = this.id;

            //LOGHETHONG
            //DO NOT WRITE LOG FOR LOGHETHONG (LOOPBACK!)
            if (needToWriteLogHeThong())
            {
                LogHeThong log = new LogHeThong();
                log.onBeforeAdded();//MANUAL MODE
                log.mota = StringHelper.toJSON(buildLog("add"));
                log.add();
            }
        }
        #endregion
    }
}
