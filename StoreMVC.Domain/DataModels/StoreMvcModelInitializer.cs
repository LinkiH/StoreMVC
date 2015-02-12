using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreMVC.Domain.Entities;
using StoreMVC.Domain.Infrastructure;

namespace StoreMVC.Domain.DataModels
{
    public class StoreMvcModelInitializer : DropCreateDatabaseIfModelChanges<StoreMvcContext>
    {
        protected override void Seed(StoreMvcContext context)
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Name = "Мяч", Description = "Футбольный мяч", Price = 275M, Category = "Футбол", ObjectState = ObjectState.Added
                },
                new Product
                {
                    Name = "Стадион", Description = "на 35 000 мест", Category = "Футбол", Price = 8000000M, ObjectState = ObjectState.Added
                },
                new Product
                {
                    Name = "Теннисная ракетка", Description = "Карбон", Category = "Теннис", Price = 50000M, ObjectState = ObjectState.Added
                },
                new Product
                {
                    Name = "Беговая дорожка", Description = "с электронными датчиками", Category = "Бег", Price = 6000M, ObjectState = ObjectState.Added
                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
