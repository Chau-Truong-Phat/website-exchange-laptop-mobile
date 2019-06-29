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
    [Table("Producer")]
    public class Producer
    {
        [Required(ErrorMessage = "Mã nhà sản xuất không được để trống")]
        [DisplayName("Mã NSX")]
        [StringLength(10)]
        public string ProducerID { get; set; }

        [Required(ErrorMessage = "Tên nhà sản xuất không được để trống")]
        [StringLength(200)]
        [DisplayName("Nhà Sản Xuất")]
        public string ProducerName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
