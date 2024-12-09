namespace shop_app.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string IdentityUserId { get; set; }
        public int ProductId { get; set; }

        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        // Навігаційні властивості
        public virtual Product Product { get; set; }
    }
}
