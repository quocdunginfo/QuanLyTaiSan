﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QuanLyTaiSan.Entities;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTaiSan.Properties;
using System.Data.Entity;
using SHARED.Libraries;

namespace QuanLyTaiSan.Entities
{
    [Table("HINHANHS")]
    public class HinhAnh : _EntityAbstract1<HinhAnh>
    {
        public HinhAnh():base()
        {

        }
        #region Dinh nghia
        /*
         * Relative path "FILENAME ONLY"
         */
        [Required]
        [Index(IsUnique = true)]
        [StringLength(255)]
        public String path { get; set; }

        public virtual ICollection<CoSo> cosos { get; set; }
        public virtual ICollection<CTThietBi> ctthietbis { get; set; }
        public virtual ICollection<Dayy> days { get; set; }
        public virtual ICollection<LogSuCoPhong> logsucophongs { get; set; }
        public virtual ICollection<LogThietBi> logthietbis { get; set; }
        public virtual ICollection<NhanVienPT> nhanvienpts { get; set; }
        public virtual ICollection<Phong> phongs { get; set; }
        public virtual ICollection<SuCoPhong> sucophongs { get; set; }
        public virtual ICollection<Tang> tangs { get; set; }
        public virtual ICollection<ThietBi> thietbis { get; set; }

        #endregion

        #region Nghiệp vụ
        public static HinhAnh getByPath(string path)
        {
            if (path == null)
            {
                return null;
            }
            return db.HINHANHS.Where(c => c.path.ToUpper().Equals(path.ToUpper())).FirstOrDefault();
        }
        ///// <summary>
        ///// Clone ListHinh ra list khác, xóa khóa ngoại, chỉ giữa lại các thuộc tính cần thiết,
        ///// Can tim phuong an thiet ke khac huu hieu hon viec override static method
        ///// </summary>
        ///// <param name="list"></param>
        ///// <returns></returns>
        //public static List<HinhAnh> clone(ICollection<HinhAnh> list)
        //{
        //    if (list == null || list.Count <= 0)
        //    {
        //        return new List<HinhAnh>();
        //    }
        //    List<HinhAnh> tmp = new List<HinhAnh>();
        //    foreach (HinhAnh item in list)
        //    {
        //        HinhAnh neww = item.clone();
        //        tmp.Add(neww);
        //    }
        //    return tmp;
        //}
        
        /// <summary>
        /// Hình ảnh mặc định khi không có mạng hoặc hình bị fail
        /// </summary>
        [NotMapped]
        public static Bitmap DEFAULT_IMAGE
        {
            get
            {
                return Resources.default_image_when_fail;
            }
        }
        /// <summary>
        /// URL hình ảnh mặc định (dành riêng cho web)
        /// </summary>
        [NotMapped]
        public static String DEFAULT_IMAGE_URL
        {
            get
            {
                return "https://www.google.com.vn/images/srpr/logo11w.png";
            }
        }
        /// <summary>
        /// Lay tat ca cac hinh cua tat ca CoSo
        /// </summary>
        /// <returns></returns>
        public List<HinhAnh> getAllCoSo()
        {
            //List<HinhAnh> list = db.HINHANHS.Where(c => c.coso != null).ToList();
            //return list;
            return new List<HinhAnh>();
        }
        /// <summary>
        /// Kiểm tra hình ảnh có trên Disk
        /// </summary>
        /// <returns></returns>
        private Boolean isCacheDiskExist()
        {
            //TU dong tao Folder cached neu chua co
            FileHelper.createFolderIfNotExist(
                Path.Combine(FileHelper.localPath(),CACHE_PATH)
                );
            return FileHelper.isExist(getCacheDiskPath());
        }
        /// <summary>
        /// Generate local path của hình hiện tại
        /// </summary>
        /// <returns></returns>
        private String getCacheDiskPath()
        {
            return Path.Combine(FileHelper.localPath(), HinhAnh.CACHE_PATH, path);
        }
        
        protected Bitmap image=null;
        /// <summary>
        /// Trả về URL tuyệt đối của Hình ảnh
        /// </summary>
        /// <returns></returns>
        public String getImageURL()
        {
            return Global.remote_setting.http_host.getCombinedPath(path);
        }
        [NotMapped]
        public Bitmap IMAGE
        {
            get
            {
                //CACHE
                //check inner cached first
                if (image != null)
                {
                    return image;
                }
                //build abs path
                String abs_path =
                    Global.remote_setting.http_host.getCombinedPath(this.path);
                //check global RAM repository
                image = QuanLyTaiSan.Libraries.ImageHelper.CACHE.get(abs_path);
                if(image != null)
                {
                    return image;
                }
                
                //check folder cache
                if (isCacheDiskExist())
                {
                    //load to Object REF
                    image = ImageHelper.fromFile(getCacheDiskPath());
                    //register to CACHE repository
                    QuanLyTaiSan.Libraries.ImageHelper.CACHE.register(abs_path, image);

                    return image;
                }

                //get image from INternet via HTTP Helper
                image = HTTPHelper.getImage(abs_path);

                if (image != null)
                {
                    //IMAGE GET FROM NETWORK OK
                    //WRITE CACHE TO DISK
                    image.Save(getCacheDiskPath());
                    //register to CACHE
                    QuanLyTaiSan.Libraries.ImageHelper.CACHE.register(abs_path, image);
                    return image;
                }
                else
                {
                    //NETWORK FAIL OR URL INVALID
                    QuanLyTaiSan.Libraries.ImageHelper.CACHE.mark_url_fail(abs_path);
                    return image = DEFAULT_IMAGE;
                }
            }
            set
            {
                image = value;
            }
        }
        protected String file_name = null;
        [NotMapped]
        public String FILE_NAME {
            get
            {
                return file_name;
            }
            set
            {
                file_name = value;
            }
            
        }

        
        protected int max_size = -1;
        [NotMapped]
        public int MAX_SIZE {
            get
            {
                return this.max_size;
            }
            set
            {
                this.max_size = value;
            }
        }
        
        protected static String cache_path = "ImageCache";
        [NotMapped]
        public static String CACHE_PATH
        {
            get
            {
                return cache_path;
            }
        }
        /// <summary>
        /// Hàm đồng bộ (phải chờ để load hình),
        /// Tài khoản FTP được cấu hình trong
        /// Global.remote_setting.ftp_host
        /// </summary>
        /// <returns>null: Chưa load được tài khoản FTP, hình không tồn tại</returns>
        public Bitmap getImage()
        {
            return IMAGE;
        }

        /// <summary>
        /// Lay tat ca nhung hinh dang su dung, dung getall binh thuong thi se co anh ma tat ca khoa ngoai NULL
        /// </summary>
        public static List<HinhAnh> getAllHinhAnhDangDung()
        {
            //to List se loai bo tracking
            return db.HINHANHS.ToList();//.Where(c=>c.path!=null).GroupBy(h => h.path).Select(s => s.FirstOrDefault()).ToList();
        }
        /// <summary>
        /// Kiểm tra this.path (sau khi chạy qua hàm lọc tên) đã có trong CSDL hay chưa

        /// <summary>
        /// Set IMAGE (Bitmap), MAX_SIZE (pixel), FILE_NAME (Tên File nguyên thủy), FK Object(COSO hay PHONG hay ...) truoc
        /// </summary>
        /// <returns>-5: IMAGE, FILE_NAME FAIL, </returns>
        public int upload(Boolean ghide=false)
        {
            if (image == null || file_name.Equals(""))
            {
                return -5;
            }
            //resize hinh neu co
            if (max_size > 0)
            {
                image = ImageHelper.ScaleBySize(image,max_size);
            }
            
            String relative_path = StringHelper.CoDauThanhKhongDau(file_name) + ".JPEG";
            this.path = relative_path;
            //Kiểm tra trùng tên hình, không cho upload nữa nếu CHƯA BẬT GHI ĐÈ
            if (!ghide && db.HINHANHS.Where(c=>c.path.ToUpper().Equals(this.path.ToUpper())).Count()>0)
            {
                return 1;
            }
            
            //prepare upload
            String abs_path =
                Global.remote_setting.ftp_host.getCombinedPath(this.path);

            //upload hinh
            return FTPHelper.uploadImage(
                image,
                abs_path,
                Global.remote_setting.ftp_host.USER_NAME,
                Global.remote_setting.ftp_host.PASS_WORD
            );
        }
        /// <summary>
        /// Chuyển list HinhAnh sang dạng chuẩn,
        /// item trong list sẽ bị reload,
        /// vd: nếu HinhAnh có path trùng rồi thì load object lên thay thế,
        /// HinhAnh mà path chưa có trong CSDL sẽ lấy luôn (Entity Framework sẽ tự động add),
        /// HinhAnh có path trùng nhau sẽ bị bỏ qua luôn
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<HinhAnh> validate(List<HinhAnh> list)
        {
            //Kiểm duyệt và load lại list hình ảnh
            List<HinhAnh> new_list = new List<HinhAnh>();
            foreach (HinhAnh item in list)
            {
                //null check
                if (item == null)
                {
                    continue;
                }
                //trùng path
                if (new_list.Where(c => c.path.ToUpper().Equals(item.path.ToUpper())).Count() > 0)
                {
                    db.Entry(item).State = EntityState.Detached;
                    continue;
                }
                
                //đã được load lên bởi dbContext
                if (item.id != Guid.Empty)
                {
                    new_list.Add(item);
                }
                else
                {
                    HinhAnh tmp = HinhAnh.getByPath(item.path);
                    if (tmp != null)
                    {
                        db.Entry(item).State = EntityState.Detached;
                        new_list.Add(tmp);
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Added;
                        new_list.Add(item);
                        continue;
                    }
                }
            }
            return new_list;
        }
        #endregion

        #region Override method
        /// <summary>
        /// Hình ảnh không có update
        /// </summary>
        /// <returns></returns>
        public override int update()
        {
            return -1;
        }
        /// <summary>
        /// nên gọi theo dạng if(obj.upload()>0) obj.add();
        /// </summary>
        /// <returns></returns>
        public override int add()
        {
            return base.add();
        }
        /// <summary>
        /// Clone có kèm xóa hết khóa ngoại
        /// </summary>
        /// <returns></returns>
        public override HinhAnh clone()
        {
            HinhAnh tmp = new HinhAnh();
            tmp.path = this.path;
            return tmp;
        }
        #endregion
    }
}
