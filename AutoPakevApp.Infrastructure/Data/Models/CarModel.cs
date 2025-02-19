using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AutoPakevApp.Infrastructure.Constants.DataConstants;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Car model of a brand")]
    public class CarModel
    {
        [Key]
        [Comment("CarModel Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CarModelNameMaxLength)]
        [Comment("Model Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Year of manufacture")]
        public int Year { get; set; }

        [Required]
        [Comment("Body type of the car")]
        public string BodyType { get; set; } = string.Empty;

        [Required]
        [Comment("Engine type(e.g Petrol, Diesel, Electric, Hybrid)")]
        public string EngineType {  get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(Brand))]
        [Comment("Foreign key to the brand of the car")]
        public int BrandId { get; set; }

        public Brand Brand { get; set; } = null!;

        [Comment("List of compatible parts of this car model")]
        public List<PartCompatibility> PartCompatibilities { get; set; } = new List<PartCompatibility>();
    }
}
