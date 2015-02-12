using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}