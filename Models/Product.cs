namespace Prn222Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; } = new List<ProductVariant>();
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
