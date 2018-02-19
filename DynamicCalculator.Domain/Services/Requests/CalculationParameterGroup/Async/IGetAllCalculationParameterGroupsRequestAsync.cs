namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup;
    

    public interface IGetAllCalculationParameterGroupsRequestAsync
    {
        Task<CalculationParameterGroupListResponseDto> ExecuteAsync();
    }
}
