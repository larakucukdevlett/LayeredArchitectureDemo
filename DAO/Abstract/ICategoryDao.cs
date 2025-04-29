using Core.DataAcess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Abstract
{
   public interface ICategoryDao:IEntityRepository<Category> //category IEntityden miras alıyor
    {
        //category databaseinde hangi işlemleri yapacağımızı metotlar halinde yazıcaz.
 
    }
}
