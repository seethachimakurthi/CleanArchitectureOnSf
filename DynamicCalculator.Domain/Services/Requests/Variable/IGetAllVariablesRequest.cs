namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    

    public interface IGetAllVariablesRequest
    {
        VariableListResponseDto Execute();
    }
}
