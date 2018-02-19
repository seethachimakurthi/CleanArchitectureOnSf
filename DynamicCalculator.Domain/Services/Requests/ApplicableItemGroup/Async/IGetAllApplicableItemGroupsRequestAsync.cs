namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup;
    

    public interface IGetAllApplicableItemGroupsRequestAsync
    {
        Task<ApplicableItemGroupListResponseDto> ExecuteAsync();
    }
}
