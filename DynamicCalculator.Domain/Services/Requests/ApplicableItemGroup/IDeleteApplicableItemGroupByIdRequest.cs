
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup;
    public interface IDeleteApplicableItemGroupByIdRequest
    {
        ApplicableItemGroupResponseDto Execute(Guid id);
    }
}
