using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity  //generic constraint: T bir referans tipi olmalı ve ya IEntity olabilir ya da IEntity den implemente eden bir class olabilir 
    {
        //ürünleri, kategorileri listelemek için delegate yapısı oluşturduk.
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //DAO Entities referans yaptı
        T Get(Expression<Func<T, bool>> filter); //filtre vermediyse tüm datayı getirecek
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
