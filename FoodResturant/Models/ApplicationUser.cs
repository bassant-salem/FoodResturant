using Microsoft.AspNetCore.Identity;

namespace FoodResturant.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
