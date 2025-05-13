namespace StoreFlow.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int OrderCount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public string? Status { get; set; }
    }
}
