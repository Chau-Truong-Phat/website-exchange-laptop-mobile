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
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [ScaffoldColumn(false)]
        [Key, Column(Order = 0), ForeignKey("Order")]
        public string OrderID { get; set; }
        public virtual Order Order { get; set; }

        [ScaffoldColumn(false)]
        [Key, Column(Order = 1), ForeignKey("Product")]
        public string ProductID { get; set; }
        public virtual Product Product { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
    }
}
