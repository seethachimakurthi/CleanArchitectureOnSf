
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    public interface IDeleteVariableByIdRequest
    {
        VariableResponseDto Execute(Guid id);
    }
}
