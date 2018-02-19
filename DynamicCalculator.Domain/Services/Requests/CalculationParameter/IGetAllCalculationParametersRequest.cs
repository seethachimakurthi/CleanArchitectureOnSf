namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter;
    

    public interface IGetAllCalculationParametersRequest
    {
        CalculationParameterListResponseDto Execute();
    }
}
