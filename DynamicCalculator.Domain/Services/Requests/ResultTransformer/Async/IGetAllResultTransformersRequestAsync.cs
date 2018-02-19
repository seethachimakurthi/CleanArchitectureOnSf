namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer;
    

    public interface IGetAllResultTransformersRequestAsync
    {
        Task<ResultTransformerListResponseDto> ExecuteAsync();
    }
}
