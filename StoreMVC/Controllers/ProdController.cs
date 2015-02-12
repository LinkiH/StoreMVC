using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreMVC.Domain.Abstract;

namespace StoreMVC.Controllers
{
    public class ProdController : Controller
    {
        private IProductRepository _repository;

        public ProdController(IProductRepository productRepository)
        {
            _repository = productRepository;
        }
        // GET: Prod
        public ViewResult List()
        {
            return View(_repository.Products);
        }
    }
}