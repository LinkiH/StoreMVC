using System.Web.Mvc;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Infrastructure.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string _sessionKey = "Cart";
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Cart cart = null;
            if (controllerContext.HttpContext.Session != null)
            {
                cart = (Cart) controllerContext.HttpContext.Session[_sessionKey];
            }
            if (cart == null)
            {
                cart = new Cart();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[_sessionKey] = cart;
                }
            }
            return cart;
        }
    }
}