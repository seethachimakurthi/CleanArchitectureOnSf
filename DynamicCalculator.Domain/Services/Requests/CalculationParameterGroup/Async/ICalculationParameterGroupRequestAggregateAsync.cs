namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    public interface ICalculationParameterGroupRequestAggregateAsync
    {
        ICreateCalculationParameterGroupRequestAsync CreateCalculationParameterGroupRequestAsync { get; }
        IDeleteCalculationParameterGroupByIdRequestAsync DeleteCalculationParameterGroupRequestAsync { get; }
        IGetAllCalculationParameterGroupsRequestAsync GetAllCalculationParameterGroupRequestAsync { get; }
        IGetCalculationParameterGroupByIdRequestAsync GetCalculationParameterGroupByIdRequestAsync { get; }
        ICalculationParameterGroupRequestAggregateAsync CalculationParameterGroupRequestAggregateAsync { get; }
    }
}
