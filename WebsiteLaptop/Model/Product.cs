using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Product")]
    public class Product
    {
        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        [StringLength(30)]
        [DisplayName("Mã sản phẩm")]
        //[RegularExpression("")]
        public string ProductID { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(200)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "CPU không được để trống")]
        [StringLength(100)]
        public string CPU { get; set; }

        [Required(ErrorMessage = "RAM không được để trống")]
        [StringLength(100)]
        public string RAM { get; set; }

        [Required(ErrorMessage = "Thông tin ổ cứng không được để trống")]
        [StringLength(100)]
        public string HardDrive { get; set; }

        [StringLength(100)]
        public string VideoCard { get; set; }

        [Required(ErrorMessage = "Thông tin hệ điều hành mặc định không được để trống")]
        [DisplayName("Hệ điều hành")]
        [StringLength(100)]
        public string OperatingSystem { get; set; }

        [DisplayName("Trọng lượng")]
        [Range(0.1,10,ErrorMessage = "Trọng lượng laptop/điện thoại trong khoảng từ 0.1kg - 10kg")]
        public double Weight { get; set; }

        [StringLength(50)]
        [RegularExpression(@"^\d*\.?\d* x \d*\.?\d* x \d*\.?\d*$",ErrorMessage = "chiều rộng x chiều dài x chiều cao")]
        [DisplayName("Kích thước")]
        public string Size { get; set; }

        [DisplayName("Giá")]
        public double Price { get; set; }

        [DisplayName("Ảnh")]
        public string ImgName { get; set; }

        [Required(ErrorMessage = "Mã NSX không được để trống")]
        [DisplayName("Mã NSX")]
        public string ProducerID { get; set; }
        public virtual Producer Producer { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}