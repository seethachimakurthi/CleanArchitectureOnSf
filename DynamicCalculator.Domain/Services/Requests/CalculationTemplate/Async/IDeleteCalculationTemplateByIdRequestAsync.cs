
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationTemplate
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate;
    public interface IDeleteCalculationTemplateByIdRequestAsync
    {
        Task<CalculationTemplateResponseDto> ExecuteAsync(Guid id);
    }
}
