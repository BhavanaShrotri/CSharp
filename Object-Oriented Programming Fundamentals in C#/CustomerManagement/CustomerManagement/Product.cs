using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {
            
        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set;}

        private string _productName;
        public string ProductName {
            get
            {
           
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }


        public string Log()
        {
            var logString = ProductId + " : " + " " +
                        ProductName + " " +
                       ProductDescription + " " +
                       "Status : " + EntityState.ToString(); 
                     

            return logString;
        }



        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isvalid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isvalid = false;
            if (CurrentPrice == null) isvalid = false;

            return isvalid;
        }
    }

   
}
