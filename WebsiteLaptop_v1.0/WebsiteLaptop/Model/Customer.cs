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
    [Table("Customer")]
    public class Customer
    {
        [ScaffoldColumn(false)]
        [StringLength(40)]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        [DisplayName("Tên khách hàng")]
        [StringLength(200)]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DisplayName("Số điện thoại")]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Số CMND không được để trống")]
        [DisplayName("Chứng minh nhân dân")]
        [StringLength(15)]
        public string IdentityNumber { get; set; }
        [StringLength(100)]

        public string Email { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
