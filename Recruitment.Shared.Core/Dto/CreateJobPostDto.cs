namespace Recruitment.Shared.Core.Dto;

public class CreateJobPostDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DeadLine { get; set; }
    public Guid JobDescriptionId { get; set; }
    public IList<Guid> FileIds { get; set; }
    public IList<Guid> AgentIds { get; set; }
    public IList<Guid> Tags { get; set; }
    public Guid CompanyId { get; set; }
    public Guid AccountManagerId { get; set; }
}