using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreMVC.Domain.Abstract;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class ProdController : Controller
    {
        private IProductRepository _repository;

        public ProdController(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        //public ViewResult List()
        //{
        //    return View(_repository.Products);
        //}

        // GET: Prod
        public ViewResult List(string category)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = _repository.Products.Where(p => category == string.Empty || p.Category == category),
                CurrentCategory = category
            };
            return View(model);
        }
    }
}