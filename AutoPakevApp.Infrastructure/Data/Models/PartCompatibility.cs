using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Represents the compatibility relationship between an auto part and a car model.")]
    public class PartCompatibility
    {
        [Key]
        [Comment("Identifier for the part compatibility record.")]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Part))]
        [Comment("Foreign key referencing the associated part.")]
        public int PartId { get; set; }


        [Comment("Navigation property for the associated part.")]
        public Part Part { get; set; } = null!;


        [Required]
        [ForeignKey(nameof(CarModel))]
        [Comment("Foreign key referencing the associated car model.")]
        public int CarModelId { get; set; }


        [Comment("Navigation property for the associated car model.")]
        public CarModel CarModel { get; set; } = null!;
    }
}
