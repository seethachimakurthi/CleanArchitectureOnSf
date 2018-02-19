
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItem;
    public interface IDeleteApplicableItemByIdRequestAsync
    {
        Task<ApplicableItemResponseDto> ExecuteAsync(Guid id);
    }
}
