﻿using PTB.Libraries;
using SHARED.Libraries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB.Entities
{
    /*
     * Không thể đặt tên là Day vì trùng class Day của Winform
     */
    [Table("DAYS")]
    public class Dayy:_EntityAbstract2<Dayy>
    {
        public Dayy():base()
        {
            
        }
        
        
		#region Dinh nghia

        [Required]
        public String ten { get; set; }
        /*
         * FK
         */
        public Guid coso_id { get; set; }
        [Required]
        [ForeignKey("coso_id")]
        public virtual CoSo coso { get; set; }
        public virtual ICollection<Tang> tangs { get; set; }
        public virtual ICollection<ViTri> vitris { get; set; }

        public virtual ICollection<Permission> permissions { get; set; }
		#endregion
		
		#region Override method
        public static new string USNAME
        {
            get
            {
                return "DAY";
            }
        }
        public static new string VNNAME
        {
            get
            {
                return "DÃY";
            }
        }
        public override string niceName()
        {
            return VNNAME + ": " + ten + ", " + coso.niceName();
        }

        /// <summary>
        /// -2: dính phòng, -3: dính tầng
        /// </summary>
        /// <returns></returns>
        public override int delete()
        {
            try
            {
                //Nếu có ít nhất 1 phòng sử dụng vị trí chứa dãy này thì KHÔNG cho xóa
                if (vitris.Where(c => c.phongs.Count > 0).Count() > 0)
                {
                    return -2;
                }
                //Kiểm tra có tầng KHÔNG cho xóa
                if (tangs.Count > 0)
                {
                    return -3;
                }
                //======================================================
                //Xóa tất cả vị trí liên quan
                if (vitris != null)
                {
                    while (vitris.Count > 0)
                    {
                        vitris.FirstOrDefault().delete();
                    }
                }

                return base.delete();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return -1;
            }
        }
        protected override void init()
        {
            base.init();
            vitris = new List<ViTri>();
            tangs = new List<Tang>();
        }
        public override Dayy prevObj()
        {
            try
            {
                Dayy prev = null;
                prev = db.DAYYS.Where(c => c.order <= this.order && c.id!=this.id && c.coso_id == coso_id).OrderByDescending(c => c.order).FirstOrDefault();
                if (prev == null)
                {
                    prev = db.DAYYS.Where(c => c.date_create <= this.date_create && c.id!=this.id && c.coso_id == coso_id).OrderByDescending(c => c.date_create).FirstOrDefault();
                }
                return prev;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        public override Dayy nextObj()
        {
            try
            {
                Dayy next = null;
                next = db.DAYYS.Where(c => c.order >= this.order && c.id!=this.id && c.coso_id == coso_id).OrderBy(c => c.order).FirstOrDefault();
                if (next == null)
                {
                    next = db.DAYYS.Where(c => c.date_create >= this.date_create && c.id != this.id  && c.coso_id == coso_id).OrderBy(c => c.date_create).FirstOrDefault();
                }
                return next;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
        }
        public override void onAfterAdded()
        {
            this.order = DateTimeHelper.toMilisec(date_create);
            base.onAfterAdded();
        }
        public override void doTrigger()
        {
            if (coso != null)
            {
                coso.trigger();
            }
            base.doTrigger();
        }
        #endregion
    }
}
