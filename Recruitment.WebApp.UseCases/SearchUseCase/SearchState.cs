using Fluxor;
using Recruitment.Shared.Core.Models;

namespace Recruitment.WebApp.UseCases.SearchUseCase;

[FeatureState]
public class SearchState
{
    public string Search { get; set; }
    public IList<SlimSearchResultDto> SlimResults { get; set; }

    public SearchState()
    {
        
    }

    public SearchState(string search, IList<SlimSearchResultDto> slimResults)
    {
        Search = search;
        SlimResults = slimResults;
    }
}