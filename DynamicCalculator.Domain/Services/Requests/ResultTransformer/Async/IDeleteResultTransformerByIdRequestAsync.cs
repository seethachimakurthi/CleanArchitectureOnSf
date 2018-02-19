
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer;
    public interface IDeleteResultTransformerByIdRequestAsync
    {
        Task<ResultTransformerResponseDto> ExecuteAsync(Guid id);
    }
}
