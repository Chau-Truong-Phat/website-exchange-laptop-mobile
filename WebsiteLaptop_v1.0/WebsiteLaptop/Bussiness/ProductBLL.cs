using Dataaccess;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class ProductBLL
    {
        ProductDAL productDAL;
        public ProductBLL()
        {
            productDAL = new ProductDAL();
        }
        public List<Product> getAllProduct()
        {
            return productDAL.getAllProduct();
        }
        public Product getProductByID(string _productID)
        {
            return productDAL.getProductByID(_productID);
        }
    }
}
