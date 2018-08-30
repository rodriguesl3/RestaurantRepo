using System;

namespace Cedris.Restaurant.Domain.Entities
{
    public class Item
    {
        public Item()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}