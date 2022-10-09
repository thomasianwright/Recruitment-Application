namespace Recruitment.Api.Core.Entities;

public class Agent
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public virtual User User { get; set; }

    public ICollection<JobPost> AgentOf { get; set; }
    public ICollection<JobPost> AccountManagerOf { get; set; }
}