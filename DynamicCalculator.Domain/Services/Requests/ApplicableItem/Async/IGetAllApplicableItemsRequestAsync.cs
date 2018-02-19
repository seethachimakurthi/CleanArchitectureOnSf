namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem;
    

    public interface IGetAllApplicableItemsRequestAsync
    {
        Task<ApplicableItemListResponseDto> ExecuteAsync();
    }
}
