
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup.Input;
    public interface ICreateApplicableItemGroupRequestAsync
    {
        Task<ApplicableItemGroupResponseDto> ExecuteAsync(CreateApplicableItemGroupInputDto input);
    }
}
