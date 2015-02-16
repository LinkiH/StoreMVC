using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreMVC.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите первую строчку адреса")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool GiftWrap { get; set; }


    }
}
