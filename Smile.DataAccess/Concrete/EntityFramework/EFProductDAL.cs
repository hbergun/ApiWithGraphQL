using System;
using System.Collections.Generic;
using System.Text;
using Smile.Core.DataAccess.EntityFramework;
using Smile.DataAccess.Abstract;
using Smile.Entities.Concrete;

namespace Smile.DataAccess.Concrete.EntityFramework
{
    public class EFProductDAL : EFEntityRepository<NorthwindContext, Product>, IProductDAL
    {
    }
}
