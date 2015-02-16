using StoreMVC.Domain.Abstract;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Domain.Concrete
{
    public class EmailSetting
    {
        public string Mail = "order@example.com";
    }
    public class EmailOrderProcessor : IOrderProcessor
    {
        private EmailSetting _emailSetting;

        public EmailOrderProcessor(EmailSetting emailSetting)
        {
            _emailSetting = emailSetting;
        }


        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails)
        {
            //throw new System.NotImplementedException();
        }
    }
}