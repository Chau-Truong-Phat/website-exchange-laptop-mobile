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
    [Table("Order")]
    public class Order
    {
        [DisplayName("Mã hóa đơn")]
        [StringLength(40)]
        public string OrderID { get; set; }
        [DisplayName("Mã khách hàng")]
        public string CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [DisplayName("Ngày lập hóa đơn")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime OrderDate { get; set; }
       
        [DisplayName("Thành tiền")]
        public double Total { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
