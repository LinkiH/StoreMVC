using StoreMVC.Domain.Entities;

namespace StoreMVC.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}