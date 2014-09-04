﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace QuanLyTaiSan.Entities
{
    /// <summary>
    /// Cá nhân, đơn vị, tổ chức có vai trò quản lý, sử dụng tài sản cố định
    /// </summary>
    [Table("TSCD_CHUTHE")]
    public class ChuThe : _EntityAbstract1<ChuThe>
    {
        public ChuThe()
            : base()
        {

        }
        #region Định nghĩa
        /// <summary>
        /// Tên gọi của chủ thể
        /// </summary>
        [Required]
        public String ten { get; set; }

        /*
         * FK
         */
        public Guid? parent_id { get; set; }
        /// <summary>
        /// Chủ thể cha
        /// </summary>
        [ForeignKey("parent_id")]
        public virtual ChuThe parent { get; set; }

        public Guid loaichuthe_id { get; set; }
        /// <summary>
        /// Loại chủ thể: Cá nhấn, tổ chức, phòng ban, ...
        /// </summary>
        [Required]
        [ForeignKey("loaichuthe_id")]
        public virtual LoaiChuThe loaichuthe { get; set; }

        /// <summary>
        /// DS chủ thể con
        /// </summary>
        public virtual ICollection<ChuThe> childs { get; set; }

        /// <summary>
        /// DS CT tài sản mà chủ thể này đống vai trò là đơn vị quản lý
        /// </summary>
        public virtual ICollection<CTTaiSan> cttaisan_dangquanlys { get; set; }

        /// <summary>
        /// DS CT tài sản mà chủ thể này đống vai trò là đơn vị trực tiếp sử dụng
        /// </summary>
        public virtual ICollection<CTTaiSan> cttaisan_dangsudungs { get; set; }

        
        public virtual ICollection<LogTaiSan> logtaisan_dangquanlys { get; set; }
        public virtual ICollection<LogTaiSan> logtaisan_dangsudungs { get; set; }
        #endregion

        #region Nghiệp vụ
        /// <summary>
        /// Lấy tất cả đám con cháu dưới root
        /// </summary>
        /// <param name="root"></param>
        /// <param name="included_root_in_result"></param>
        /// <returns></returns>
        public List<ChuThe> getAllRecursive(ChuThe root, Boolean included_root_in_result=true)
        {
            List<ChuThe> tmp = new List<ChuThe>();
            if (root != null)
            {
                if (included_root_in_result)
                {
                    tmp.Add(root);
                }
                if (childs != null)
                {
                    foreach (ChuThe item in childs)
                    {
                        tmp.AddRange(getAllRecursive(item));
                    }
                }
            }
            else
            {
                foreach (ChuThe item in ChuThe.getAll())
                {
                    tmp.AddRange(getAllRecursive(item));
                }
            }
            return tmp;
        }
        #endregion

        #region Override
        public override string niceName()
        {
            return loaichuthe.ten + ": " + ten;
        }
        protected override void init()
        {
            base.init();
        }
        #endregion
    }
}
