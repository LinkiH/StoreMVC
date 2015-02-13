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

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel {Cart = GetCart(), ReturnUrl = returnUrl});
        }

        public RedirectToRouteResult AddToCart(int Id,  string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(x => x.Id == Id);
            if (product != null) { GetCart().AddItem(product, 1); }

            return RedirectToAction("Index", new {returnUrl});
        }

        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = _repository.Products.FirstOrDefault(x => x.Id == productId);

            if (product != null) { GetCart().RemoveLive(product); }

            return RedirectToAction("Index", new {returnUrl});
        }

        private Cart GetCart()
        {
            Cart cart = (Cart) Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;
        }
    }
}