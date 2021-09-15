using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve  (int productId)
        {
            //Create instance of the product class

            Product product = new Product(productId);

            //code that retrieves the defined product

            if (productId == 2)
            {
                product.ProductName = "Monitor";
                product.ProductDescription = "24 Inch";
                product.CurrentPrice = 12000;
            }

            return product;
        }

        //save current product

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //Call an Insert Stored Procedure
                    }
                    else
                    {
                        //Call an Update Stored Procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;  
        }
    }
}
