namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    public interface IApplicableItemGroupRequestAggregate
    {
        ICreateApplicableItemGroupRequest CreateApplicableItemGroupRequest { get; }
        IDeleteApplicableItemGroupByIdRequest DeleteApplicableItemGroupRequest { get; }
        IGetAllApplicableItemGroupsRequest GetAllApplicableItemGroupRequest { get; }
        IGetApplicableItemGroupByIdRequest GetApplicableItemGroupByIdRequest { get; }
        IApplicableItemGroupRequestAggregate IApplicableItemGroupRequestAggregate{ get; }
    }
}
