using Core.DataAccess.EntityFramework;
using Core.Entities;
using Dao.Abstract;
using DAO.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Concrete.EntityFramework
{
    public class EfOrderDao : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDao
    {
    }
}
