using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class NotebookContext : DbContext
    {
        public DbSet<NotebookItem> NotebookItem { get; set; }
        public NotebookContext(DbContextOptions<NotebookContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}