using Recruitment.Shared.Core.Enum;
using Recruitment.Shared.Core.Models;

namespace Recruitment.WebApp.Pages.Index;

public partial class Index
{
    private SearchEntryDto SearchValue { get; set; };
    
    private async Task<IEnumerable<SearchEntryDto>> Search(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);
        
    }
}