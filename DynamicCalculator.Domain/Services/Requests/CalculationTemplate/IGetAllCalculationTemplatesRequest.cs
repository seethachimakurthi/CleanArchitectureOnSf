namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationTemplate
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate;
    

    public interface IGetAllCalculationTemplatesRequest
    {
        CalculationTemplateListResponseDto Execute();
    }
}
