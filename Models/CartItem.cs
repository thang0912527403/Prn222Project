namespace Prn222Project.Models
{
    public class CartItem
    {
        public int productVariantId { get; set; }
        public string productName { get; set; }
        public string? color { get; set; }
        public string? decoration { get; set; }      
        public decimal price { get; set; }
        public int quantity { get; set; }
    }
}
