using Smile.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Business.Abstract
{
    public interface IProductService
    {
        IList<Product> GetAll();
        IList<Product> GetProductsByCategory(int categoryID);
        Product Add(Product product);
        Product Update(Product product);
        void Delete(Product productID);
        Product GetByID(int ProductID);
    }
}
