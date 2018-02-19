namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    public interface IVariableRequestAggregateAsync
    {
        ICreateVariableRequestAsync CreateVariableRequestAsync { get; }
        IDeleteVariableByIdRequestAsync DeleteVariableRequestAsync { get; }
        IGetAllVariablesRequestAsync GetAllVariableRequestAsync { get; }
        IGetVariableByIdRequestAsync GetVariableByIdRequestAsync { get; }
        IVariableRequestAggregateAsync VariableRequestAggregateAsync { get; }
    }
}
