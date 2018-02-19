namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    public interface ICalculationPeriodRequestAggregate
    {
        ICreateCalculationPeriodRequest CreateCalculationPeriodRequest { get; }
        IDeleteCalculationPeriodByIdRequest DeleteCalculationPeriodRequest { get; }
        IGetAllCalculationPeriodsRequest GetAllCalculationPeriodRequest { get; }
        IGetCalculationPeriodByIdRequest GetCalculationPeriodByIdRequest { get; }
        ICalculationPeriodRequestAggregate ICalculationPeriodRequestAggregate{ get; }
    }
}
