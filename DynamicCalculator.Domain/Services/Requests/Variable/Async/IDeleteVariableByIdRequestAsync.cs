
namespace Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable
{
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    public interface IDeleteVariableByIdRequestAsync
    {
        Task<VariableResponseDto> ExecuteAsync(Guid id);
    }
}
