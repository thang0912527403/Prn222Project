namespace Prn222Project.Models
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? Decoration { get; set; }
        public DateTime ImportDate { get; set; }
        public decimal Price { get; set; }
        public int NumberInStock { get; set; }
        public int NumberInOrder { get; set; }
        public int NumberSold { get; set; }
        public string? ImageUrl { get; set; }

    }
}
