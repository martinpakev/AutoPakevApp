using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AutoPakevApp.Infrastructure.Constants.DataConstants;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Car brand")]
    public class Brand
    {
        [Key]
        [Comment("Brand Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(BrandNameMaxLength)]
        [Comment("Brand name")]
        public string Name { get; set; } = string.Empty;


        public List<CarModel> CarModels { get; set; } = new List<CarModel>();
    }
}
