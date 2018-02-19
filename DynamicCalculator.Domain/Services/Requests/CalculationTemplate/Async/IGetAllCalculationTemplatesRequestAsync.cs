namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationTemplate
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate;
    

    public interface IGetAllCalculationTemplatesRequestAsync
    {
        Task<CalculationTemplateListResponseDto> ExecuteAsync();
    }
}
