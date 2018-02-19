namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.ApplicableItem
{
    public interface IApplicableItemRequestAggregateAsync
    {
        ICreateApplicableItemRequestAsync CreateApplicableItemRequestAsync { get; }
        IDeleteApplicableItemByIdRequestAsync DeleteApplicableItemRequestAsync { get; }
        IGetAllApplicableItemsRequestAsync GetAllApplicableItemRequestAsync { get; }
        IGetApplicableItemByIdRequestAsync GetApplicableItemByIdRequestAsync { get; }
        IApplicableItemRequestAggregateAsync ApplicableItemRequestAggregateAsync { get; }
    }
}
