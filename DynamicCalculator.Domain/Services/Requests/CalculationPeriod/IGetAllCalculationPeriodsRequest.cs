namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod;
    

    public interface IGetAllCalculationPeriodsRequest
    {
        CalculationPeriodListResponseDto Execute();
    }
}
