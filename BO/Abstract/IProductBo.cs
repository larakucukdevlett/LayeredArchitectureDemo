using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Abstract
{
    public interface IProductBo //productla ilgili business işlemleri burda oluşturuluyor.
    {
        List<Product> GetAll();
        //Producta ulaşmak için BO'ya sağ tıklayıp add reference ile entities ve DAO ya referans ekledik.
        List<Product> GetAllByCategoryId(int id); //category id ye göre ürün getirme
        List<Product> GetByUnitPrice(decimal min, decimal max);

    }

}
