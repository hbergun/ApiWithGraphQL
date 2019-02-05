using Smile.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smile.Business.Abstract
{
    public interface ICategoryService
    {
        IList<Category> GetAll();
        Category GetCategoryByID(int CategoryID);
        Category Add(Category category);
        Category Update(Category category);
        void Delete(Category CategoryID);
    }
}
