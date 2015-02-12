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
                    Name = "Ball", Description = "Football Ball", Price = 275M, ObjectState = ObjectState.Added
                },
                new Product
                {
                    Name = "Stadium", Description = "35 000 - seat stadium", Price = 8000000M, ObjectState = ObjectState.Added
                }
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
