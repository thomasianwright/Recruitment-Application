namespace Recruitment.Api.Core.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string JobTitle { get; set; }

    public virtual ICollection<Tag> PreferedTags { get; set; }
}