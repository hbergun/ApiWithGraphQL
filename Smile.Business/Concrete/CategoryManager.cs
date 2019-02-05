using Smile.Business.Abstract;
using Smile.DataAccess.Abstract;
using Smile.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public Category Add(Category category)
        {
            return _categoryDAL.Add(category);
            
        }
        public Category Update(Category category)
        {
           return _categoryDAL.Update(category);
        }
        public void Delete(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public IList<Category> GetAll()
        {
            return _categoryDAL.GetList();
        }

        public Category GetCategoryByID(int CategoryID)
        {
            return _categoryDAL.Get(c => c.CategoryID == CategoryID);
        }

      
        //TODO : Gerekli Mi İkinci Bir Öğe Yada Bu Gerekli Mi ??
    }
}
