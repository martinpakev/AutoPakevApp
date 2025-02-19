using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AutoPakevApp.Infrastructure.Constants.DataConstants;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Represents a category of auto parts")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [Comment("Category's name")]
        public string Name { get; set; } = string.Empty;

        [Comment("Collection of parts under this category")]
        public List<Part> Parts { get; set; } = new List<Part>();
    }
}
