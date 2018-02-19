
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem.Input;
    public interface ICreateApplicableItemRequestAsync
    {
        Task<ApplicableItemResponseDto> ExecuteAsync(CreateApplicableItemInputDto input);
    }
}
