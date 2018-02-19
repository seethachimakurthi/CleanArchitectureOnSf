namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationPeriod
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod;
    public interface IGetCalculationPeriodByIdRequestAsync
    {
        Task<CalculationPeriodResponseDto> ExecuteAsync(Guid Id);
    }
}
