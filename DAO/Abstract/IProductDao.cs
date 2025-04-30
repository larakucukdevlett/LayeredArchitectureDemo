using Core.DataAcess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Abstract
{
    public interface IProductDao : IEntityRepository<Product> 
    {
        //Specifying the operations for Product table
         List<ProductDetailDto> GetProductDetails();   //implemented in EfProductDao
    }


}
