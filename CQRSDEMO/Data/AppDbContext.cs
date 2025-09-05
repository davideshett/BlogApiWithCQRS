using CQRSDEMO.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDEMO.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<BlogPost> BlogPosts { get; set; }
}