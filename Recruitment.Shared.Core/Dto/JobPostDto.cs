namespace Recruitment.Shared.Core.Dto;

public class JobPostDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime DeadLine { get; set; }
    
    public Guid JobDescriptionId { get; set; }
    public IList<Guid> Files { get; set; }
    public IList<AgentDto> Agents { get; set; }
    public int Applicants { get; set; }
    public IList<TagDto> Tags { get; set; }
    public CompanyDto Company { get; set; }
    public virtual AgentDto AccountManager { get; set; }
}