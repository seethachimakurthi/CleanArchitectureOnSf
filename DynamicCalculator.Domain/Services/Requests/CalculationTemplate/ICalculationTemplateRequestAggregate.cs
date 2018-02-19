namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationTemplate
{
    public interface ICalculationTemplateRequestAggregate
    {
        ICreateCalculationTemplateRequest CreateCalculationTemplateRequest { get; }
        IDeleteCalculationTemplateByIdRequest DeleteCalculationTemplateRequest { get; }
        IGetAllCalculationTemplatesRequest GetAllCalculationTemplateRequest { get; }
        IGetCalculationTemplateByIdRequest GetCalculationTemplateByIdRequest { get; }
        ICalculationTemplateRequestAggregate ICalculationTemplateRequestAggregate{ get; }
    }
}
