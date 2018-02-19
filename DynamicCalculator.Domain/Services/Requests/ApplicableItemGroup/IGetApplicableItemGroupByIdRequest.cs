namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup;
    public interface IGetApplicableItemGroupByIdRequest
    {
        ApplicableItemGroupResponseDto Execute(Guid Id);
    }
}
