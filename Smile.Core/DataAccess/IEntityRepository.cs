using Smile.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Smile.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        T Add(T Entity);
        T Update(T Entity);
        void Delete(T Entity);
    }
}
