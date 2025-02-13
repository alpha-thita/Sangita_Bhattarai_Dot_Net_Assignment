namespace OnlineStoreFurniture.Models
{
    public class order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; } // Foreign Key
        public Customer Customer { get; set; } // Navigation Property
        public ICollection<orderItem> orderItems { get; set; } = new List<orderItem>();
        public decimal TotalAmount { get; set; } // Total Price for the Order
    }
}
