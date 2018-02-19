namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    public interface ICalculationParameterGroupRequestAggregate
    {
        ICreateCalculationParameterGroupRequest CreateCalculationParameterGroupRequest { get; }
        IDeleteCalculationParameterGroupByIdRequest DeleteCalculationParameterGroupRequest { get; }
        IGetAllCalculationParameterGroupsRequest GetAllCalculationParameterGroupRequest { get; }
        IGetCalculationParameterGroupByIdRequest GetCalculationParameterGroupByIdRequest { get; }
        ICalculationParameterGroupRequestAggregate ICalculationParameterGroupRequestAggregate{ get; }
    }
}
