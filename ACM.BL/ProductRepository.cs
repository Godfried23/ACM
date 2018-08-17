﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class
            //Pass in the requested Id
            Product product = new Product(productId);

            //Code that retrieves the defined product

            //Temporary hard coded values to return a popluated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Sizes";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
