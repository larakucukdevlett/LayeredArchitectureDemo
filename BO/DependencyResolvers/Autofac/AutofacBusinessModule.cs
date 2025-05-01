using Autofac;
using BO.Abstract;
using BO.Concrete;
using DAO.Abstract;
using DAO.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bo.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductBo>().SingleInstance(); //IProductBo çağırıldığında ProductManagerı getir
            builder.RegisterType<EfProductDao>().As<IProductDao>().SingleInstance();
            //Program.cs de bu şekilde tanımlamak yerine bu modülde yukardaki gibi uygulandı 
            //builder.Services.AddSingleton<IProductBo, ProductManager>();
            //builder.Services.AddSingleton<IProductDao, EfProductDao>();
        }
    }
}
