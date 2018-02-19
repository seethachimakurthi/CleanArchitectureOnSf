namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer;
    public interface IGetResultTransformerByIdRequestAsync
    {
        Task<ResultTransformerResponseDto> ExecuteAsync(Guid Id);
    }
}
