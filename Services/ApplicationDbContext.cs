using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebsiteCms.Models;

namespace WebsiteCms.Services
{
    // Use IdentityDbContext with IdentityUser (recommended)
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // DbSet for your documents
        public DbSet<ADocumentModel> Documents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ADocumentModel>()
                .HasIndex(d => new { d.Category, d.Number });

            builder.Entity<ADocumentModel>()
                .Property(d => d.IssueDate)
                .HasColumnType("date");
        }
    }
}