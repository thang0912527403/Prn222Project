using EllipticCurve.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prn222Project.Models
{
    public class OrderDetail
    {
        [Required]
        public int order_id { get; set; }

        [Required]
        public int productVariant_id { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal unit_price { get; set; }

        [Required]
        public int quantity { get; set; }
        [ForeignKey(nameof(order_id))]
        public virtual Orders Order { get; set; }
        [ForeignKey(nameof(productVariant_id))]
        public virtual ProductVariant ProductVariant { get; set; }
    }
}
