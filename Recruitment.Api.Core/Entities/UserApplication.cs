using Recruitment.Shared.Core.Enum;

namespace Recruitment.Api.Core.Entities;

public class UserApplication
{
    public Guid Id { get; set; }
    public ApplicationStatus CurrentStatus { get; set; }
    public Guid? ResumeId { get; set; }

    public Guid UserId { get; set; }
    public virtual User User { get; set; }

    public DateTime CreatedAt { get; set; }
}