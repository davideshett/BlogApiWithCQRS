using CQRSDEMO.Entities;
using MediatR;

namespace CQRSDEMO.CQRS.Queries.GetBlogPostsByAge;

public record GetBlogPostsByAgeQuery(int Age) : IRequest<IEnumerable<BlogPost>>;