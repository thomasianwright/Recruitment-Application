using Recruitment.Shared.Core.Models;

namespace Recruitment.UseCases.SearchUseCase.Actions;

public class AddSearchResultsAction
{
    public AddSearchResultsAction(IList<SlimSearchResultDto> resultDtos)
    {
        ResultDtos = resultDtos;
    }

    public AddSearchResultsAction()
    {
        
    }

    public IList<SlimSearchResultDto> ResultDtos { get; set; }
}