namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItemGroup
{
    public interface IApplicableItemGroupRequestAggregateAsync
    {
        ICreateApplicableItemGroupRequestAsync CreateApplicableItemGroupRequestAsync { get; }
        IDeleteApplicableItemGroupByIdRequestAsync DeleteApplicableItemGroupRequestAsync { get; }
        IGetAllApplicableItemGroupsRequestAsync GetAllApplicableItemGroupRequestAsync { get; }
        IGetApplicableItemGroupByIdRequestAsync GetApplicableItemGroupByIdRequestAsync { get; }
        IApplicableItemGroupRequestAggregateAsync ApplicableItemGroupRequestAggregateAsync { get; }
    }
}
