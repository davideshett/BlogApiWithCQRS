using CQRSDEMO.CQRS.Queries.GetAllPosts;
using CQRSDEMO.Entities;

namespace CQRSDEMO.Interfaces;

public interface IBlogPostRepository: IRepository<BlogPost>
{
    Task<IEnumerable<BlogPost>> GetBlogPostByAge(int age);
}   