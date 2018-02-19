
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter.Input;
    public interface ICreateCalculationParameterRequest
    {
        CalculationParameterResponseDto Execute(CreateCalculationParameterInputDto input);
    }
}
