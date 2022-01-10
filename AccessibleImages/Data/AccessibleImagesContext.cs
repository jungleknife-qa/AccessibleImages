using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AccessibleImages.Models;

namespace AccessibleImages.Data
{
    public class AccessibleImagesContext : DbContext
    {
        public AccessibleImagesContext (DbContextOptions<AccessibleImagesContext> options)
            : base(options)
        {
        }

        public DbSet<AccessibleImages.Models.Image> Image { get; set; }

        public DbSet<AccessibleImages.Models.User> User { get; set; }
    }
}
