namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    public interface ICalculationParameterRequestAggregate
    {
        ICreateCalculationParameterRequest CreateCalculationParameterRequest { get; }
        IDeleteCalculationParameterByIdRequest DeleteCalculationParameterRequest { get; }
        IGetAllCalculationParametersRequest GetAllCalculationParameterRequest { get; }
        IGetCalculationParameterByIdRequest GetCalculationParameterByIdRequest { get; }
        ICalculationParameterRequestAggregate ICalculationParameterRequestAggregate{ get; }
    }
}
