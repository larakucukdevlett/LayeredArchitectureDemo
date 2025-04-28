using BO.Abstract;
using BO.Concrete;
using DAO.Abstract;

namespace ConssoleUIApp
{
    class Program //Kullanıcının doğrudan göreceği çıktı ve giriş işlemleri burada olur.
    {   //Open closed principle: Yazılıma yeni bir özellik ekliyorsak mevcuttaki hiçbir koda dokunulmaz.
        static void Main(string[] args)
        {
            IProductBo productManager= new ProductManager(new EfProductDao());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
