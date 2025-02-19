using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static AutoPakevApp.Infrastructure.Constants.DataConstants;

namespace AutoPakevApp.Infrastructure.Data.Models
{
    [Comment("Represents an application user who can use the application and place orders.")]
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        [Comment("User's first name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        [Comment("User's Last name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserAddresMaxLength)]
        [Comment("User's address")]
        public string Address { get; set; } = string.Empty;

        [Comment("Collection of orders placed by the user.")]
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
