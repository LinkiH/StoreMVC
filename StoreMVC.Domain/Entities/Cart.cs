

using System.Collections.Generic;
using System.Linq;

namespace StoreMVC.Domain.Entities
{
    public class Cart : Entity
    {
        private List<CartLine>  _lines = new List<CartLine>();

        public void AddItem(Product product, int quantity)
        {
            CartLine line = _lines.FirstOrDefault(p => p.Product.Equals(product));
            if (line == null)
            {
                _lines.Add(new CartLine { Product = product, Quantity = quantity });
            }
        }

        public void RemoveLive(Product product)
        {
            _lines.RemoveAll(l => l.Product.Equals(product));
        }
        public decimal ComputeTotalValue()
        {
            return _lines.Sum(e => e.Product.Price*e.Quantity);
        }

        public void Clear()
        {
            _lines.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return _lines; }
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
