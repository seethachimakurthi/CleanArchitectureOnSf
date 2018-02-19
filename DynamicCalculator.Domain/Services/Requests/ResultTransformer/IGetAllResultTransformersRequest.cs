namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer;
    

    public interface IGetAllResultTransformersRequest
    {
        ResultTransformerListResponseDto Execute();
    }
}
