using System.ComponentModel.DataAnnotations.Schema;

namespace Recruitment.Api.Core.Entities;

public class Company
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual ICollection<JobPost> Posts { get; set; }
}