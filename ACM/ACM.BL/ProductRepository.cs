using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid)
            {
                if (product.IsNew)
                {
                    // call insert procedure
                }

                else
                {
                    // call update procedure
                }

            }
            return success;
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
