namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup;
    

    public interface IGetAllCalculationParameterGroupsRequest
    {
        CalculationParameterGroupListResponseDto Execute();
    }
}
