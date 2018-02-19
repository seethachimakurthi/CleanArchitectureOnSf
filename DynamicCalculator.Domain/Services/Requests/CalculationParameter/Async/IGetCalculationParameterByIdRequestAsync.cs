namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter;
    public interface IGetCalculationParameterByIdRequestAsync
    {
        Task<CalculationParameterResponseDto> ExecuteAsync(Guid Id);
    }
}
