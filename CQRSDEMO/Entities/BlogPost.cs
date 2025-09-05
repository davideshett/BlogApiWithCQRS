namespace CQRSDEMO.Entities;

public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set; } 
    public string Content { get; set; }
    public int Age { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}