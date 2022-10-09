using Recruitment.Api.Core.Enum;

namespace Recruitment.Shared.Core.Dto;

public class UserApplicationDto
{
    public Guid Id { get; set; }
    public ApplicationStatus CurrentStatus { get; set; }
    public Guid? ResumeId { get; set; }

    public UserDto User { get; set; }

    public DateTime CreatedAt { get; set; }
}