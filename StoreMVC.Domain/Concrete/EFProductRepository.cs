using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreMVC.Domain.Abstract;
using StoreMVC.Domain.DataModels;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Domain.Concrete
{
    public class EfProductRepository : IProductRepository
    {
        private StoreMvcContext _context = new StoreMvcContext();

        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
        }

        public void SaveProduct(Product product)
        {
            if (product.Id == 0)
            {
                _context.Products.Add(product);
            }
            else
            {
                Product dbProduct = _context.Products.Find(product.Id);
                if (dbProduct != null)
                {
                    dbProduct.Name = product.Name;
                    dbProduct.Description = product.Description;
                    dbProduct.Price = product.Price;
                    dbProduct.Category = product.Category;
                }
                _context.SaveChanges();
            }
        }
    }
}
