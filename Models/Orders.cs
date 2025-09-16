using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prn222Project.Models
{
    public class Orders
    {
        [Key]
        public int order_id { get; set; }

        public string UserId { get; set; }

        [Required]
        public DateTime order_date { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
