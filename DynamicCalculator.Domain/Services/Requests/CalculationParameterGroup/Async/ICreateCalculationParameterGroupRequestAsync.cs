
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup.Input;
    public interface ICreateCalculationParameterGroupRequestAsync
    {
        Task<CalculationParameterGroupResponseDto> ExecuteAsync(CreateCalculationParameterGroupInputDto input);
    }
}
