using DAO.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Concrete.InMemory
{
    public class InMemoryProductDao : IProductDao
    {
        List<Product> _products; //global değişken ve global değişkenler _ ile verilir
        public InMemoryProductDao()
        {
            _products = new List<Product> {
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock=5 },
            new Product { ProductId = 2, CategoryId = 1, ProductName = "Televizyon", UnitPrice = 20, UnitsInStock=1 },
            new Product { ProductId = 3, CategoryId = 1, ProductName = "Kamera", UnitPrice = 25, UnitsInStock=9 },
            new Product { ProductId = 4, CategoryId = 1, ProductName = "Telefon", UnitPrice = 45, UnitsInStock=12 },
            new Product { ProductId = 5, CategoryId = 1, ProductName = "Klavye", UnitPrice = 50, UnitsInStock=14 },
            new Product { ProductId = 6, CategoryId = 1, ProductName = "Fare", UnitPrice = 13, UnitsInStock=18 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product porductToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); // referans numarası atadık böylece belleği yormadık. new Product() deseydik yeni ve gereksiz bir referans numarası oluşturacaktık.
            //listedeki her p için productid ile karşılaştırma yapıp referanslarını birbirine eşitledi
            _products.Remove(porductToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        { //VERİTABANINDAKİ DATAYI BO YA VERECEK.
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId==categoryId).ToList();
            //WHERE ile bu koşulu döndüren tüm kategorileri listeleyip döndürdü
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product porductToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            porductToUpdate.ProductName = product.ProductName;
            porductToUpdate.ProductId = product.ProductId;
            porductToUpdate.UnitPrice = product.UnitPrice;
            porductToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
