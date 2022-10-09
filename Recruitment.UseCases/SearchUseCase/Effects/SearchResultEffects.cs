using Fluxor;
using Recruitment.Shared.Core.Models;
using Recruitment.UseCases.SearchUseCase.Actions;

namespace Recruitment.UseCases.SearchUseCase.Effects;

public class SearchResultEffects
{
    private readonly IState<SearchState> _searchState;

    public SearchResultEffects(IState<SearchState> searchState)
    {
        _searchState = searchState;
    }

    [EffectMethod]
    public Task GetSearchResultsEffect(GetSearchResultsAction _, IDispatcher dispatcher)
    {
        var test = new List<SlimSearchResultDto>()
        {
            new()
            {
                JobId = new Guid(),
                Subtitle = "Test",
                CompanyName = "Caliqon",
                JobTitle = "Software Engineer",
                ShortDescription = "Working with .NET, Go And/Or Rust",
            }
        };
        
        dispatcher.Dispatch(new AddSearchResultsAction(test));
        return Task.CompletedTask;
    }
}