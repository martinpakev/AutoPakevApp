using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AutoPakevApp.Infrastructure.Constants.DataConstants;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Represents an auto part available in the app.")]
    public class Part
    {
        [Key]
        [Comment("Part Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(PartNameMaxLength)]
        [Comment("Name of the part")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(PartDescriptionMaxLength)]
        [Comment("Description of the part.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Precision(18,2)]
        [Comment("Price of the part.")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Available stock quantity of the part.")]
        public int StockQuantity { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        [Comment("Foreign key to the category of the part.")]
        public int CategoryId { get; set; }

        [Comment("Navigation property for the category of the part.")]
        public Category Category { get; set; } = null!;

        [Comment("List of car model compatibilities for this part.")]
        public List<PartCompatibility> PartCompatibilities { get; set; } = new List<PartCompatibility>();
    }
}
