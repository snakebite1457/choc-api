using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace choch_api.Models
{
    public class ChochDbContext : IdentityDbContext<User>
    {
        private static bool _created = false;

        public ChochDbContext(DbContextOptions<ChochDbContext> options)
            : base(options)
        {
            if (!_created)
            {
                Database.Migrate();
                _created = true;
            }
        }
    }
}
