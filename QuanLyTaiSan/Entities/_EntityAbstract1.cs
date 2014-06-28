﻿using QuanLyTaiSan.Libraries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan.Entities
{
    /// <summary>
    /// Chỉ bao gồm định nghĩa về id
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class _EntityAbstract1<T> : _CRUDInterface<T> where T : _EntityAbstract1<T>
    {
        public _EntityAbstract1()
        {
            init();//it will call TOP level first
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
        protected OurDBContext db
        {
            get
            {
                return DBInstance.DB;
            }
        }
        
        public virtual int add()
        {
            try
            {
                //time
                date_create = date_modified = date_create == null ? ServerTimeHelper.getNow() : date_create;

                //script
                db.Set<T>().Add((T)this);
                db.SaveChanges();
                return id;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                db.Set<T>().Remove((T)this);//remove if fail
                return -1;
            }
            finally
            {
                
            }
        }

        public virtual int update()
        {
            try
            {
                //time
                date_modified = ServerTimeHelper.getNow();
                
                //script
                db.Set<T>().Attach((T)this);
                //Sử dụng EntityState.Modified có thể gây lỗi Validation Error, khi update 1 object mà có [Required] FK object khác, mà FK Object  chưa được load ít nhất 1 lần => Bắt buộc phải load FK Object trước
                db.Entry(this).State = EntityState.Modified;//importance
                db.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return -1;
            }
            finally
            {
                
            }
        }

        public virtual int delete()
        {
            try
            {
                db.Set<T>().Attach((T)this);//Có thể gây lỗi bị clear list khóa ngoại,...
                db.Set<T>().Remove((T)this);
                db.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                db.Set<T>().Attach((T)this);//nếu bị lỗi thì Attach lại, để không bị mất khóa ngoại, cháu chắt
                return -1;
            }
            finally
            {
                
            }
        }
        public virtual T getById(int id)
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
            finally
            {
                
            }
        }

        public virtual List<T> getAll()
        {
            try
            {
                List<T> objs = db.Set<T>().ToList();
                return objs;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return new List<T>();
            }
            finally
            {
                
            }
        }
        public virtual void dispose()
        {
            //if (db != null)
            //{
            //    db.Dispose();
            //    db = null;
            //}
        }
        /// <summary>
        /// Load lại Object theo DBContext mới trong DBInstance (Vì có thể đã bị new mới bởi ai đó)
        /// Cần có id trước
        /// </summary>
        /// <returns></returns>
        public virtual T reload()
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
            finally
            {

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
        public List<T> parse(List<int> id_array)
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
        #endregion
    }
}
