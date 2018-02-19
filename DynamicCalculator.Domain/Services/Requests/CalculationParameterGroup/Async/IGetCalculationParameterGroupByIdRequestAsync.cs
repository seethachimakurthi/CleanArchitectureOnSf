namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup;
    public interface IGetCalculationParameterGroupByIdRequestAsync
    {
        Task<CalculationParameterGroupResponseDto> ExecuteAsync(Guid Id);
    }
}
