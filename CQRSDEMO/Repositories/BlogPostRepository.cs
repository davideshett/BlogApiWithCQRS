using CQRSDEMO.Data;
using CQRSDEMO.Entities;
using CQRSDEMO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CQRSDEMO.Repositories;

public class BlogPostRepository: Repository<BlogPost>, IBlogPostRepository
{
    private readonly AppDbContext _context;

    public BlogPostRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BlogPost>> GetBlogPostByAge(int age)
    {
        return await _context.BlogPosts
            .Where(b => b.Age >= age).ToListAsync();
    }
}