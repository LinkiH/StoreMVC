using System.Linq;
using System.Web.Mvc;
using StoreMVC.Domain.Abstract;
using StoreMVC.Domain.Entities;
using StoreMVC.Models;

namespace StoreMVC.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _repository;

        public CartController(IProductRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel { Cart = cart, ReturnUrl = returnUrl });
        }

        public RedirectToRouteResult AddToCart(Cart cart, int Id, string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(x => x.Id == Id);
            if (product != null) { cart.AddItem(product, 1); }

            return RedirectToAction("Index", new {returnUrl});
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int Id, string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(x => x.Id == Id);

            if (product != null) { cart.RemoveLive(product); }

            return RedirectToAction("Index", new {returnUrl});
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }
        
    }
}