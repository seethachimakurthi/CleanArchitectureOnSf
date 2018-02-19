namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    public interface ICalculationPeriodRequestAggregateAsync
    {
        ICreateCalculationPeriodRequestAsync CreateCalculationPeriodRequestAsync { get; }
        IDeleteCalculationPeriodByIdRequestAsync DeleteCalculationPeriodRequestAsync { get; }
        IGetAllCalculationPeriodsRequestAsync GetAllCalculationPeriodRequestAsync { get; }
        IGetCalculationPeriodByIdRequestAsync GetCalculationPeriodByIdRequestAsync { get; }
        ICalculationPeriodRequestAggregateAsync CalculationPeriodRequestAggregateAsync { get; }
    }
}
