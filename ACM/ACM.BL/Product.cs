﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product: EntityBase
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

        // note that it is "Auto Implemented" property, so we can not add code to
        // "setter" or "getter". so the first step is to convert it from "auto implemented"
        // property, into "fully implemented" property.
        public string ProductName { get; set; }

        // so is it better to add the code for adding the space here in the "getter"
        // or it is better to add it in seperate method? seperate method will be easier
        // to build and test. so we are going to create method called "InsertSpaces"
        //private string _productName;

        //public string ProductnName
        //{
        //    get { return _productName; }
        //    set { _productName = value; }
        //}

        // so thisnis general purpose function that takes string and add
        // spaces to it. but this is not "product" class responsiblity to add spaces
        // to string, so it is better to be in seperate class for common use, so we are going
        // to create new project for common use code.
        //public string InsertSpaces(string source)
        //{

        //}


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

        public override bool Validate()
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

        public override string ToString()
        {
            return ProductName;
        }

    }
}
