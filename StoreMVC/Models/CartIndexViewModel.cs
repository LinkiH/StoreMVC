using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}