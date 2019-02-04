using Smile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Navigation Prop
        IList<Product> Products { get; set; }
    }
}
