using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RealmDigitalDirectories.Models
{
    public class RealmDigitalDirectoriesContext : DbContext
    {
        public RealmDigitalDirectoriesContext (DbContextOptions<RealmDigitalDirectoriesContext> options)
            : base(options)
        {
        }

        public DbSet<RealmDigitalDirectories.Models.User> User { get; set; }
    }
}
