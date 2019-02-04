using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Entities.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Navigation Prop
        IList<Product> Products { get; set; }
    }
}
