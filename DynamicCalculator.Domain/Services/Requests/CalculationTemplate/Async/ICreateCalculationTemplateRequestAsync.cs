
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationTemplate
{
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate.Input;
    public interface ICreateCalculationTemplateRequestAsync
    {
        Task<CalculationTemplateResponseDto> ExecuteAsync(CreateCalculationTemplateInputDto input);
    }
}
