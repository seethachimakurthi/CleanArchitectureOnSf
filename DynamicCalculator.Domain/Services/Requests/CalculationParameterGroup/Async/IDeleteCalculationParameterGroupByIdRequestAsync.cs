
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup;
    public interface IDeleteCalculationParameterGroupByIdRequestAsync
    {
        Task<CalculationParameterGroupResponseDto> ExecuteAsync(Guid id);
    }
}
