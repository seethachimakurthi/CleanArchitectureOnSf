
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer.Input;
    public interface ICreateResultTransformerRequestAsync
    {
        Task<ResultTransformerResponseDto> ExecuteAsync(CreateResultTransformerInputDto input);
    }
}
