using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Entities.Concrete
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public ulong OrderTrackingCode { get; set; } //---- Long(OK!) Ulong Support ?

        //Navigation Property
        IList<OrderDetail> OrderDetails { get; set; }
    }
}
