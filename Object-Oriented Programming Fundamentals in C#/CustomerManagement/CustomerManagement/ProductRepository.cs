using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Set of 4 Bright Yellow mini Sunflowers ";
                product.CurrentPrice = 20.50M;
            }

            

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {

                    }
                    else
                    {
                        
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
