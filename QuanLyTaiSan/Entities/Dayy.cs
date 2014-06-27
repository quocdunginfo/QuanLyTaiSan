﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTaiSan.Entities
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
        /*
         * FK
         */
        public int coso_id { get; set; }
        [Required]
        [ForeignKey("coso_id")]
        public virtual CoSo coso { get; set; }
        public virtual ICollection<Tang> tangs { get; set; }
        public virtual ICollection<ViTri> vitris { get; set; }
		#endregion
		
		#region Override method
        protected override void init()
        {
            base.init();
            vitris = new List<ViTri>();
            tangs = new List<Tang>();
        }
        public override int update()
        {
            //have to load all [Required] FK object first
            if (coso != null)
            {
                coso.trigger();
            }
            
            //...
            return base.update();
        }

        #endregion
    }
}
