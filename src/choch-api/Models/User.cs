using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace choch_api.Models
{
    public class User : IdentityUser
    {
        public Provider ActiveProvider { get; set; }
    }
}
