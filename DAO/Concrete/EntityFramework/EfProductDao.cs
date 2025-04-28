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
    internal class EfProductDao : IProductDao
    {
        public void Add(Product entity) //ürün ekleme işlemi dbde
        {
            //IDisposable Pattern implementation of C#
            using(NorthwindContext context= new NorthwindContext())
            { //using bittiği an belleği temizler boş kaynak tüketimi engellenir
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Product entity) //dbde ürün silme işlemi
        {
            using (NorthwindContext context = new NorthwindContext())
            { 
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public Product Get(Expression<Func<Product, bool>> filter) //dbden belli bir filtreyle tek ürün çekme
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); //Product içinde dönüyor ve filtera uyan tek ürünü döndürüyor.
            }
        }
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null) //db den birden çok ürün çekme
        {
            using(NorthwindContext context= new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }  

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            { 
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
