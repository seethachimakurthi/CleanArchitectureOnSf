
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod;
    public interface IDeleteCalculationPeriodByIdRequest
    {
        CalculationPeriodResponseDto Execute(Guid id);
    }
}
