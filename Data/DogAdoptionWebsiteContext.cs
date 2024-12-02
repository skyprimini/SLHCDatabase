using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogAdoptionWebsite.Models;

namespace DogAdoptionWebsite.Data
{
    public class DogAdoptionWebsiteContext : DbContext
    {
        public DogAdoptionWebsiteContext (DbContextOptions<DogAdoptionWebsiteContext> options)
            : base(options)
        {
        }

        public DbSet<DogAdoptionWebsite.Models.Dog> Dog { get; set; } = default!;
        public DbSet<DogAdoptionWebsite.Models.User> User { get; set; } = default!;
        

    }


}

