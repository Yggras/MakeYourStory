using DataLayer.Model;

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
    }

    
}