using Smile.Business.Abstract;
using Smile.DataAccess.Abstract;
using Smile.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public Product Add(Product product)
        {
           return _productDAL.Add(product);
        }

        public void Delete(Product productID)
        {
            _productDAL.Delete(productID);
        }

        public IList<Product> GetAll()
        {
            return _productDAL.GetList();
        }

        public Product GetByID(int ProductID)
        {
            return _productDAL.Get(p => p.ProductID == ProductID);
        }

        public IList<Product> GetProductsByCategory(int categoryID)
        {
            return _productDAL.GetList(c => c.CategoryID == categoryID);
        }

        public Product Update(Product product)
        {
            return _productDAL.Update(product);
        }
    }
}
