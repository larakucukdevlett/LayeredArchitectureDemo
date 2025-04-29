using Bo.Abstract;
using DAO.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo.Concrete
{
    public class CategoryManager : ICategoryBo
    {
        ICategoryDao _categoryDao;

        public CategoryManager(ICategoryDao categoryDao)
        {
            _categoryDao = categoryDao;
        }

        public List<Category> GetAll()
        {
            return _categoryDao.GetAll();
        }
        //Select * from Categories where CategoryId=3
        public Category GetByCategoryId(int categoryId)
        {
            return _categoryDao.Get(c=>c.CategoryId == categoryId);
        }
    }
}
