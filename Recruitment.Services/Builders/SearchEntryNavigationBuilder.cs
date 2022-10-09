using Recruitment.Shared.Core.Enum;
using Recruitment.Shared.Core.Models;

namespace Recruitment.Services.Builders;

public class SearchEntryNavigationBuilder
{
    private readonly SearchEntryDto _searchEntry;

    private SearchEntryNavigationBuilder(SearchEntryDto searchEntry)
    {
        _searchEntry = searchEntry;
    }

    public static SearchEntryNavigationBuilder CreateInstance(SearchEntryDto searchEntry)
    {
        return new SearchEntryNavigationBuilder(searchEntry);
    }

    public string GetSlug()
    {
        return _searchEntry.SearchEntryType switch
        {
            SearchEntryType.Job => "",
            SearchEntryType.Company => "expr",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}