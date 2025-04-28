using BO.Abstract;
using DAO.Abstract;
using DAO.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Concrete
{
    public class ProductManager : IProductBo //interfacete initialize edilen metodları concreteleştirdik.
    {
        IProductDao _productDao; //injecton yaptık.DAO katmanına bağımlıdır.

        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }
        public List<Product> GetAll()
        {
            //iş kodları
            return _productDao.GetAll();
        }
        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDao.GetAll(p=>p.CategoryId==id);
        }
        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDao.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
