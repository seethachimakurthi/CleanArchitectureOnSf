namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    public interface IVariableRequestAggregate
    {
        ICreateVariableRequest CreateVariableRequest { get; }
        IDeleteVariableByIdRequest DeleteVariableRequest { get; }
        IGetAllVariablesRequest GetAllVariableRequest { get; }
        IGetVariableByIdRequest GetVariableByIdRequest { get; }
        IVariableRequestAggregate IVariableRequestAggregate{ get; }
    }
}
