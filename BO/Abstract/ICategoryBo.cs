using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo.Abstract
{
    public interface ICategoryBo
    {
        List<Category> GetAll();
        Category GetByCategoryId(int categoryId);
    }
}
