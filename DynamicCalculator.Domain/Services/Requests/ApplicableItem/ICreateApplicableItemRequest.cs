
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem.Input;
    public interface ICreateApplicableItemRequest
    {
        ApplicableItemResponseDto Execute(CreateApplicableItemInputDto input);
    }
}
