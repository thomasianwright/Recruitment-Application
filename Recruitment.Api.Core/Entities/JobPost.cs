using Recruitment.Api.Core.Enum;

namespace Recruitment.Api.Core.Entities;

public class JobPost
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    
    public DateTime CreatedAt { get; set; }
    public DateTime DeadLine { get; set; }
    
    
    public Guid JobDescriptionId { get; set; }
    public IList<Guid> Files { get; set; }
    public virtual ICollection<Agent> Agents { get; set; }
    public virtual ICollection<UserApplication> Applicants { get; set; }
    public virtual ICollection<Tag> Tags { get; set; }
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
    public Guid AccountManagerId { get; set; }
    public virtual Agent AccountManager { get; set; }
}