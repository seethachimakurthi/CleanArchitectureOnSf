
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup.Input;
    public interface ICreateCalculationParameterGroupRequest
    {
        CalculationParameterGroupResponseDto Execute(CreateCalculationParameterGroupInputDto input);
    }
}
