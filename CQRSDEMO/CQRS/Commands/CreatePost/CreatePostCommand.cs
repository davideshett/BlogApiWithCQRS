using CQRSDEMO.Entities;
using MediatR;

namespace CQRSDEMO.CQRS.Commands.CreatePost;

public record CreatePostCommand(string Title, string Content) : IRequest<BlogPost>;