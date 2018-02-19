namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer;
    public interface IGetResultTransformerByIdRequest
    {
        ResultTransformerResponseDto Execute(Guid Id);
    }
}
