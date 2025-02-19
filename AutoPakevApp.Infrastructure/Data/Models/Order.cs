using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoPakevApp.Infrastructure.Data.Models
{

    [Comment("Represents a customer order conatining multiple ordered parts.")]
    public class Order
    {
        [Key]
        [Comment("Order Identifier")]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        [Comment("Identifier of the user who placed the order.")]
        public string UserId { get; set; } = string.Empty;

        [Comment("Navigation property for the user who placed the order.")]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("The date and time when the order was placed.")]
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [Required]
        [Precision(18,2)]
        [Comment("Total price of the order, including all ordered items.")]
        public decimal TotalPrice { get; set; }

        [Comment("Collection of orderd items in this order")]
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}
