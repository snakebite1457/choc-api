using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace choch_api.Models
{
    public class User : IdentityUser
    {
        public Provider ActiveProvider { get; set; }
    }
}