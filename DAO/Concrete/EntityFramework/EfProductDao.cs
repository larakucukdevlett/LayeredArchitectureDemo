using Core.DataAccess.EntityFramework;
using DAO.Abstract;
using Entities.Concrete;
using Entities.DTO;
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
    public class EfProductDao : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDao
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.CategoryId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }
    }
}
