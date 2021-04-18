using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement
{
    
    public class Order : EntityBase, ILoggable
    {
        public Order():this(0)
        {
            
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int customerId { get; set; }
        public DateTimeOffset? OrderDate{ get; set; }
        public int OrderId { get; private set;}
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public string Log()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"{OrderDate.Value.Date}({OrderId})";

        public override bool Validate()
        {
            var isvalid = true;

            if (OrderDate == null) isvalid = false;

            return isvalid;
        }
    }

   
}
