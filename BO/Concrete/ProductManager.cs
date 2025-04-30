using Bo.Constants;
using BO.Abstract;
using Core.Utilities.Results;
using DAO.Abstract;
using DAO.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Concrete
{
    public class ProductManager : IProductBo 
    {
        IProductDao _productDao; //injecton yaptık.DAO katmanına bağımlıdır.

        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }
 
        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDao.GetAll(),Messages.ProductsListed);
        }
        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDao.GetAll(p=>p.CategoryId==id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDao.Get(p=>p.ProductId==productId));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDao.GetProductDetails());
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDao.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        IDataResult<List<Product>> IProductBo.GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDao.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }
    }
}
