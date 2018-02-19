namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ApplicableItemGroup;
    public interface IGetApplicableItemGroupByIdRequestAsync
    {
        Task<ApplicableItemGroupResponseDto> ExecuteAsync(Guid Id);
    }
}
