namespace Recruitment.Shared.Core.Dto;

public class AgentDto
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public UserDto User { get; set; }

    public IList<JobPostDto> AgentOf { get; set; }
    public IList<JobPostDto> AccountManagerOf { get; set; }
}