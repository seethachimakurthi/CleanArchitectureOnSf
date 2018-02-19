namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    public interface IResultTransformerRequestAggregate
    {
        ICreateResultTransformerRequest CreateResultTransformerRequest { get; }
        IDeleteResultTransformerByIdRequest DeleteResultTransformerRequest { get; }
        IGetAllResultTransformersRequest GetAllResultTransformerRequest { get; }
        IGetResultTransformerByIdRequest GetResultTransformerByIdRequest { get; }
        IResultTransformerRequestAggregate IResultTransformerRequestAggregate{ get; }
    }
}
