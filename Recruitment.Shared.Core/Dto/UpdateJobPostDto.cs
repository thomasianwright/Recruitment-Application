namespace Recruitment.Shared.Core.Dto;

public class UpdateJobPostDto
{
    public List<Guid> TagIds { get; set; }
    public List<Guid> Agents { get; set; }
    public Guid AccountManagerId { get; set; }
    public List<Guid> Files { get; set; }
    public Guid JobDescriptionId { get; set; }
}