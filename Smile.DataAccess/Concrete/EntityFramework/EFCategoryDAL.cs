using Smile.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Smile.Core.DataAccess.EntityFramework;
using Smile.Entities.Concrete;

namespace Smile.DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDAL : EFEntityRepository<NorthwindContext,Category>,ICategoryDAL
    {
    }
}
