
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod.Input;
    public interface ICreateCalculationPeriodRequest
    {
        CalculationPeriodResponseDto Execute(CreateCalculationPeriodInputDto input);
    }
}
