
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input;
    public interface ICreateVariableRequestAsync
    {
        Task<VariableResponseDto> ExecuteAsync(CreateVariableInputDto input);
    }
}
