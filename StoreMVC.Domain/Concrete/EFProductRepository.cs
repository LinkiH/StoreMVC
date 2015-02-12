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
    }
}
