using Microsoft.EntityFrameworkCore;

namespace WebApplication19.Models
{
    public class MyWebsiteFirstCode:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        public DbSet<Example> Examples { get; set; }
        public DbSet<Skill> Skills { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=MyWebsiteFirstCode;Integrated Security=True ; TrustServerCertificate=True");
        }

    }
}
