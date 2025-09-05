using CQRSDEMO.Entities;
using CQRSDEMO.Interfaces;
using MediatR;

namespace CQRSDEMO.CQRS.Queries.GetAllPosts;

public class GetAllPostsHandler: IRequestHandler<GetAllPostsQuery, IEnumerable<BlogPost>>
{
    private readonly IRepository<BlogPost> _repository;

    public GetAllPostsHandler(IRepository<BlogPost> repository)
    {
        _repository = repository;
    }
    
    public async Task<IEnumerable<BlogPost>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}