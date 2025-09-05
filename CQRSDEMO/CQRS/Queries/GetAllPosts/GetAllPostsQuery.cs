using CQRSDEMO.Entities;
using MediatR;

namespace CQRSDEMO.CQRS.Queries.GetAllPosts;

public record GetAllPostsQuery() : IRequest<IEnumerable<BlogPost>>;