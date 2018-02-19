namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    public interface ICalculationParameterRequestAggregateAsync
    {
        ICreateCalculationParameterRequestAsync CreateCalculationParameterRequestAsync { get; }
        IDeleteCalculationParameterByIdRequestAsync DeleteCalculationParameterRequestAsync { get; }
        IGetAllCalculationParametersRequestAsync GetAllCalculationParameterRequestAsync { get; }
        IGetCalculationParameterByIdRequestAsync GetCalculationParameterByIdRequestAsync { get; }
        ICalculationParameterRequestAggregateAsync CalculationParameterRequestAggregateAsync { get; }
    }
}
