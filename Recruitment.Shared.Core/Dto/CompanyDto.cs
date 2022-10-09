namespace Recruitment.Shared.Core.Dto;

public class CompanyDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public IList<JobPostDto> Posts { get; set; }
}