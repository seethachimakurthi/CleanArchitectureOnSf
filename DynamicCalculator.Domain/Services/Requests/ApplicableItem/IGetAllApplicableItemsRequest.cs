namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem;
    

    public interface IGetAllApplicableItemsRequest
    {
        ApplicableItemListResponseDto Execute();
    }
}
