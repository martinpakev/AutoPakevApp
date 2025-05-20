using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Represents an individual item added to a user's shopping cart")]
    public class ShoppingCarItem
    {
        [Key]
        [Comment("ShoppingCartItem Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Foreign Key to the Part added to the Shopping car.")]
        public int PartId { get; set; }
        [Required]
        [Comment("Navigation property")]
        public Part Part { get; set; } = null!;

        [Required]
        [Comment("Application User Identifier")]
        public string ApplicationUserId { get; set; } = string.Empty;

        [Comment("Navigation propert to the user who owns this shopping cart item.")]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        [Comment("Quantity of the part added to the Shopping cart.")]
        public int Quantity { get; set; } = 1;
    }
}
