
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter.Input;
    public interface ICreateCalculationParameterRequestAsync
    {
        Task<CalculationParameterResponseDto> ExecuteAsync(CreateCalculationParameterInputDto input);
    }
}
