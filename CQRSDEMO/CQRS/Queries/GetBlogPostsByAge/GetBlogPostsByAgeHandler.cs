using CQRSDEMO.Entities;
using CQRSDEMO.Interfaces;
using MediatR;

namespace CQRSDEMO.CQRS.Queries.GetBlogPostsByAge;


public class GetBlogPostsByAgeHandler : IRequestHandler<GetBlogPostsByAgeQuery, IEnumerable<BlogPost>>
{
    private readonly IBlogPostRepository _blogPostRepository;

    public GetBlogPostsByAgeHandler(IBlogPostRepository blogPostRepository)
    {
        _blogPostRepository = blogPostRepository;
    }
    public async Task<IEnumerable<BlogPost>> Handle(GetBlogPostsByAgeQuery request, CancellationToken cancellationToken)
    {
        return await _blogPostRepository.GetBlogPostByAge(request.Age);
    }
}