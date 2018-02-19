namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    

    public interface IGetAllVariablesRequestAsync
    {
        Task <VariableListResponseDto> ExecuteAsync();
    }
}
