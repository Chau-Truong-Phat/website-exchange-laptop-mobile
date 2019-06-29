using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataaccess
{
    public class ProductDAL
    {
        LaptopsDBContext db;
        public ProductDAL()
        {
            db = new LaptopsDBContext();
        }
        public List<Product> getAllProduct()
        {
            return db.Products.ToList();
        }
        public Product getProductByID(string _productID)
        {
            return db.Products.FirstOrDefault(x => x.ProductID.Equals(_productID));
        }
    }
}
