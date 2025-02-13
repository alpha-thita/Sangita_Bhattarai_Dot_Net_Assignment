namespace OnlineStoreFurniture.Models
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string ImageUrl { get; set; } // For storing image link
            public int Stock { get; set; } // Number of items in stock
            public int CategoryId { get; set; } // Foreign Key
            public Category Category { get; set; } // Navigation Property
        }
    }


