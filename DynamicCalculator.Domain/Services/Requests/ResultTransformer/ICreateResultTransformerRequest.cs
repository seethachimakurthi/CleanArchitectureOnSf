
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer.Input;
    public interface ICreateResultTransformerRequest
    {
        ResultTransformerResponseDto Execute(CreateResultTransformerInputDto input);
    }
}
