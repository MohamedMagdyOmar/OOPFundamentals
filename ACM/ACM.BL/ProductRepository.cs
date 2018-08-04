using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public bool Save()
        {
            return true;
        }

        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 35.7m;
            }

            return product;
        }
    }
}
