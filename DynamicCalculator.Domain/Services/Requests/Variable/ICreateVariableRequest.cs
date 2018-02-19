
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input;
    public interface ICreateVariableRequest
    {
        VariableResponseDto Execute(CreateVariableInputDto input);
    }
}
