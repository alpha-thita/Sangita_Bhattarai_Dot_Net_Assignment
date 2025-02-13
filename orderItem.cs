
namespace OnlineStoreFurniture.Models
{
    public class orderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }              // Foreign Key
        public order Order { get; set; } = new order(); // Navigation Property
        public int ProductId { get; set; }            // Foreign Key
        public Product Product { get; set; } = new Product(); // Navigation Property
        public int Quantity { get; set; }              // How many items in the order
        public decimal Price { get; set; }             // Price per item

    }
}
