using System.Net;
using CQRSDEMO.CQRS.Commands.CreatePost;
using CQRSDEMO.CQRS.Queries.GetAllPosts;
using CQRSDEMO.CQRS.Queries.GetBlogPostsByAge;
using CQRSDEMO.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDEMO.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private readonly IMediator _mediator;

    public BlogController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BlogPost>>> GetAll()
    {
        var posts = await _mediator.Send(new GetAllPostsQuery());
        return Ok(new
        {
            Message = "Success",
            IsSuccessful = true,
            StatusCode = HttpStatusCode.OK,
            Data = posts
        });
    }
    
    [HttpPost]
    public async Task<ActionResult<BlogPost>> Create([FromBody] CreatePostCommand command)
    {
        var post = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetAll), new { id = post.Id }, post);
    }

    [HttpGet("{age:int}")]
    public async Task<ActionResult<IEnumerable<BlogPost>>> Get(int age)
    {
        var posts = await _mediator.Send(new GetBlogPostsByAgeQuery(age));
        return Ok(new
        {
            Message = "Success",
            IsSuccessful = true,
            StatusCode = HttpStatusCode.OK,
            Data = posts
        });
    }
}