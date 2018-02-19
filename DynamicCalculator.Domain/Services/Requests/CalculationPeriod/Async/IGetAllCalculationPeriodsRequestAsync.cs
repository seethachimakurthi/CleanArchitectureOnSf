namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod;
    

    public interface IGetAllCalculationPeriodsRequestAsync
    {
        Task<CalculationPeriodListResponseDto> ExecuteAsync();
    }
}
