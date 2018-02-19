namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationTemplate
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate;
    public interface IGetCalculationTemplateByIdRequest
    {
        CalculationTemplateResponseDto Execute(Guid Id);
    }
}
