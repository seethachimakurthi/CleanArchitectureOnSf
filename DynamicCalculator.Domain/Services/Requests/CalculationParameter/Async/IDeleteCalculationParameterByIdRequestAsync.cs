
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter;
    public interface IDeleteCalculationParameterByIdRequestAsync
    {
        Task<CalculationParameterResponseDto> ExecuteAsync(Guid id);
    }
}
