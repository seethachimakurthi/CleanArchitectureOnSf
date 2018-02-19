namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    public interface IGetVariableByIdRequest
    {
        VariableResponseDto Execute(Guid Id);
    }
}
