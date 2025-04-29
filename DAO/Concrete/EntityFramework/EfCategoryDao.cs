using Core.DataAccess.EntityFramework;
using DAO.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Concrete.EntityFramework
{
    public class EFCategoryDao : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDao
    {
       
    }
}
