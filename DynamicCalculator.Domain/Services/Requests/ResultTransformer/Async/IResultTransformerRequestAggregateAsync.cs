namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ResultTransformer
{
    public interface IResultTransformerRequestAggregateAsync
    {
        ICreateResultTransformerRequestAsync CreateResultTransformerRequestAsync { get; }
        IDeleteResultTransformerByIdRequestAsync DeleteResultTransformerRequestAsync { get; }
        IGetAllResultTransformersRequestAsync GetAllResultTransformerRequestAsync { get; }
        IGetResultTransformerByIdRequestAsync GetResultTransformerByIdRequestAsync { get; }
        IResultTransformerRequestAggregateAsync ResultTransformerRequestAggregateAsync { get; }
    }
}
