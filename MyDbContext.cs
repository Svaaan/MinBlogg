using Microsoft.EntityFrameworkCore;

class MyDbContext : DbContext
{
    public DbSet<Author> authors { get; set; }
    public DbSet<Blog> blogs { get; set; }
    public DbSet<BlogPost> blogPosts { get; set; }
    public DbSet<Comment> comments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source ={"database.db"}");
        //options.UseInMemoryDatabase("MinDatabas");
    }

}