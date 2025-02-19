using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Represents and individual item in an order.")]
    public class OrderItem
    {
        [Key]
        [Comment("OrderItem Identifier")]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Order))]
        [Comment("Foreign key to the associated order.")]
        public int OrderId { get; set; }

        [Comment("Navigation property to the associated order.")]
        public Order Order { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Part))]
        [Comment("Foreign key to the ordered part")]
        public int PartId  { get; set; }

        [Comment("Navigation property to the ordered part.")]
        public Part Part { get; set; } = null!;

        [Required]
        [Comment("Quantity of the part ordered.")]
        public int Quantity { get; set; }

        [Required]
        [Precision(18,2)]
        [Comment("Price per unit of part")]
        public decimal Price { get; set; }
    }
}
