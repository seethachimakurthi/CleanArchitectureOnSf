
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod.Input;
    public interface ICreateCalculationPeriodRequestAsync
    {
        Task<CalculationPeriodResponseDto> ExecuteAsync(CreateCalculationPeriodInputDto input);
    }
}
