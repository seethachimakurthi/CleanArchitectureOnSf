namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod;
    public interface IGetCalculationPeriodByIdRequest
    {
        CalculationPeriodResponseDto Execute(Guid Id);
    }
}
