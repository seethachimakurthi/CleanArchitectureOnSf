
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup.Input;
    public interface ICreateApplicableItemGroupRequest
    {
        ApplicableItemGroupResponseDto Execute(CreateApplicableItemGroupInputDto input);
    }
}
