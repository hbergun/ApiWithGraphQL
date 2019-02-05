using Smile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Entities.Concrete
{
    public class OrderDetail : IEntity
    {
       
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        
        //Navigation Property
        public Order Order { get; set; }
    }
}
