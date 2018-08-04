using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }

        public string ProductName { get; set; }
        
        // question mark deckares a "nullable type".
        // "nullable type" is a "value type" like int, string, and ....
        // "nullable type" allows variable to have "value" or a "null".
        // it is used to distinguish between "Not Set" and "zero".
        public decimal? CurrentPrice { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool validate()
        {
            bool isValid = true;

            if(string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if(CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
