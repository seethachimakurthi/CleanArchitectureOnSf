namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.CalculationParameterGroup
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup;
    public interface IGetCalculationParameterGroupByIdRequest
    {
        CalculationParameterGroupResponseDto Execute(Guid Id);
    }
}
