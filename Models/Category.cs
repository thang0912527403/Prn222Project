namespace Prn222Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string? Description { get; set; } 
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; } 
        public DateTime? ModifiedDate { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
