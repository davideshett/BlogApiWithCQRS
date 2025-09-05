using CQRSDEMO.Entities;
using CQRSDEMO.Interfaces;
using MediatR;

namespace CQRSDEMO.CQRS.Commands.CreatePost;

public class CreatePostHandler: IRequestHandler<CreatePostCommand, BlogPost>
{
    private readonly IRepository<BlogPost> _repository;

    public CreatePostHandler(IRepository<BlogPost> repository)
    {
        _repository = repository;
    }
    public async Task<BlogPost> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        var post = new BlogPost { Title = request.Title, Content = request.Content };
        await _repository.AddAsync(post);
        await _repository.SaveChangesAsync();
        return post;
    }
}