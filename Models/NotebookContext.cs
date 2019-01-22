using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class NotebookContext : DbContext
    {
        public DbSet<NotebookItem> NotebookItems { get; set; }
        public DbSet<User> Users { get; set; }
        public NotebookContext(DbContextOptions<NotebookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}