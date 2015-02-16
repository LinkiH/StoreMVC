using System.ComponentModel.DataAnnotations;

namespace StoreMVC.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
