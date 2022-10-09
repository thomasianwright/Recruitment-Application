using Recruitment.Shared.Core.Enum;

namespace Recruitment.Shared.Core.Models;

public class SearchEntryDto
{
    public string Title { get; set; }
    public SearchEntryType SearchEntryType { get; set; }

    public Guid Id { get; set; }
}