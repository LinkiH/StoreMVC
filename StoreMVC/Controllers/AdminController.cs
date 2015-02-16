using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreMVC.Domain.Abstract;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository _repository;

        public AdminController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index()
        {
            return View(_repository.Products);
        }

        public ViewResult Edit(int Id)
        {
            Product product = _repository.Products.FirstOrDefault(x => x.Id == Id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} сохранено", product.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }
    }
}