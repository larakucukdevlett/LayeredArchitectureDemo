using Core.DataAccess.EntityFramework;
using DAO.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;



namespace DAO.Concrete.EntityFramework
{
    //ef: ORM ürünü. LINQ destekli çalışıyor. ORM: veritabaındaki tabloyu classmış gibi onunla ilişkilendirip tüm veritabanı operasyonlarını LINQ ile yaptığımız yer.
    public class EfProductDao : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDao
    {
         
    }
}
