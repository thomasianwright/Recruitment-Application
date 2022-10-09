namespace Recruitment.Api.Core.Entities;

public class Tag
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public ICollection<JobPost> JobPosts { get; set; }
}