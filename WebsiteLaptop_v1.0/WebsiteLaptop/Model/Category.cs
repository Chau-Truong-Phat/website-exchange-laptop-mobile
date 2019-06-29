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
    [Table("Category")]
    public class Category
    {
        public int CategoryID { get; set; }
        [StringLength(200)]
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
