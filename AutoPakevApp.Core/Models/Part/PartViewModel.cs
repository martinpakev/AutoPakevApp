using System.ComponentModel.DataAnnotations;

namespace AutoPakevApp.Core.Models.Part
{
    public class PartViewModel
    {

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category = string.Empty;
    }
}
