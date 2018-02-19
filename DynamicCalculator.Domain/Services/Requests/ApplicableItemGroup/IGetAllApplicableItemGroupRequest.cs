namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup;
    

    public interface IGetAllApplicableItemGroupsRequest
    {
        ApplicableItemGroupListResponseDto Execute();
    }
}
