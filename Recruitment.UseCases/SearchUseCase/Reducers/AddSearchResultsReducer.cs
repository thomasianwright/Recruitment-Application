using Fluxor;
using Recruitment.UseCases.SearchUseCase.Actions;

namespace Recruitment.UseCases.SearchUseCase.Reducers;

public class AddSearchResultsReducer : Reducer<SearchState, AddSearchResultsAction>
{
    public override SearchState Reduce(SearchState state, AddSearchResultsAction action)
    {
        state.SlimResults = action.ResultDtos;

        return state;
    }
}