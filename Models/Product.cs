using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ValidateNever] 
        public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
