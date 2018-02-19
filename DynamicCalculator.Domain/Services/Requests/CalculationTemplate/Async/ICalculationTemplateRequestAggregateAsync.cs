namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationTemplate
{
    public interface ICalculationTemplateRequestAggregateAsync
    {
        ICreateCalculationTemplateRequestAsync CreateCalculationTemplateRequestAsync { get; }
        IDeleteCalculationTemplateByIdRequestAsync DeleteCalculationTemplateRequestAsync { get; }
        IGetAllCalculationTemplatesRequestAsync GetAllCalculationTemplateRequestAsync { get; }
        IGetCalculationTemplateByIdRequestAsync GetCalculationTemplateByIdRequestAsync { get; }
        ICalculationTemplateRequestAggregateAsync CalculationTemplateRequestAggregateAsync { get; }
    }
}
