
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem;
    public interface IDeleteApplicableItemByIdRequest
    {
        ApplicableItemResponseDto Execute(Guid id);
    }
}
