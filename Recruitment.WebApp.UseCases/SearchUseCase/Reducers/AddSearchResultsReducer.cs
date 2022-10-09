using Fluxor;
using Recruitment.WebApp.UseCases.SearchUseCase.Actions;

namespace Recruitment.WebApp.UseCases.SearchUseCase.Reducers;

public class AddSearchResultsReducer : Reducer<SearchState, AddSearchResultsAction>
{
    public override SearchState Reduce(SearchState state, AddSearchResultsAction action)
    {
        state.SlimResults = action.ResultDtos;

        return state;
    }
}