namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    public interface IApplicableItemRequestAggregate
    {
        ICreateApplicableItemRequest CreateApplicableItemRequest { get; }
        IDeleteApplicableItemByIdRequest DeleteApplicableItemRequest { get; }
        IGetAllApplicableItemsRequest GetAllApplicableItemRequest { get; }
        IGetApplicableItemByIdRequest GetApplicableItemByIdRequest { get; }
        IApplicableItemRequestAggregate IApplicableItemRequestAggregate{ get; }
    }
}
