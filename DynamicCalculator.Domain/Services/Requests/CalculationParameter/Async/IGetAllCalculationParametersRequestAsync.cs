namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter;
    

    public interface IGetAllCalculationParametersRequestAsync
    {
        Task<CalculationParameterListResponseDto> ExecuteAsync();
    }
}
