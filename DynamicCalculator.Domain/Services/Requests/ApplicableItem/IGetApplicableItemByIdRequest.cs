namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem;
    public interface IGetApplicableItemByIdRequest
    {
        ApplicableItemResponseDto Execute(Guid Id);
    }
}
