namespace Recruitment.Shared.Core.Models;

public class SlimSearchResultDto
{
    public Guid JobId { get; set; }
    public string JobTitle { get; set; }
    public string Subtitle { get; set; }
    public string ShortDescription { get; set; }
    public string CompanyName { get; set; }
}