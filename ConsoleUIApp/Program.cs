using Bo.Concrete;
using BO.Abstract;
using BO.Concrete;
using DAO.Abstract;
using DAO.Concrete.EntityFramework;

namespace ConssoleUIApp
{
    class Program 
    {   
        static void Main(string[] args)
        {
            //ProductTest();
            CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDao());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDao());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
