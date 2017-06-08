using DataLayer.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoryContext : ApplicationDbContext
    {
        public DbSet<Story> Stories { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Line> Lines { get; set; }
        public override IDbSet<ApplicationUser> Users { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("name=StoryDb", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}