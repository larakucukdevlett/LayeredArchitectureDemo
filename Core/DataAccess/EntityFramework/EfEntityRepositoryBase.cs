using Core.DataAcess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
   public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
    where TEntity : class,IEntity,new()
    where TContext:DbContext, new()

    {
        public void Add(TEntity entity) //ürün ekleme işlemi dbde
        {
            //IDisposable Pattern implementation of C#
            using (TContext context = new TContext())
            { //using bittiği an belleği temizler boş kaynak tüketimi engellenir
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity) //dbde ürün silme işlemi
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter) //dbden belli bir filtreyle tek ürün çekme
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //Product içinde dönüyor ve filtera uyan tek ürünü döndürüyor.
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null) //db den birden çok ürün çekme
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
