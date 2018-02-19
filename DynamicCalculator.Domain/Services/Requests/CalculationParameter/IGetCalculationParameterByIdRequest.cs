namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameter
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter;
    public interface IGetCalculationParameterByIdRequest
    {
        CalculationParameterResponseDto Execute(Guid Id);
    }
}
