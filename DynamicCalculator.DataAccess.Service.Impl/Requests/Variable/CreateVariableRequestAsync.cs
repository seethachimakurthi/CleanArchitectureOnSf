

namespace DynamicCalculator.DataAccess.Service.Requests.Variable
{
    using AutoMapper;
    using Serilog;
    using System;
    using System.Threading.Tasks;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable;
    public class CreateVariableRequestAsync : BaseServiceRequestAsync<Variable>, ICreateVariableRequestAsync
    {
        public CreateVariableRequestAsync(IRepositoryAsync<Variable> repository, IRepositoryAsyncAggregate repositoryAggregate)
            : base(repository, repositoryAggregate) { }

        #region Implementation of ICreateVariableRequestAsync

        public async Task<VariableResponseDto> ExecuteAsync(CreateVariableInputDto input)
        {
            var VariableResponse = new VariableResponseDto();
            try
            {
                Log.Information("Creating Variable Entry for [{NewName}]...", input?.Name);
                var variableEntity = Mapper.Map<CreateVariableInputDto, Variable>(input);
                VariableResponse = Mapper.Map(await Repository.CreateAsync(variableEntity), VariableResponse);
                VariableResponse.StatusCode = 200;
                Log.Information("Created Variable Entry for [{NewName}] with Id: [{Id}]", VariableResponse.Name, VariableResponse.Id);
            }
            catch (Exception exception)
            {
                Log.Error(exception, "Failed to Create Variable: [{NewName}].", input?.Name);
                HandleErrors(VariableResponse, exception);
            }
            return VariableResponse;
        }

        

        #endregion
    }
}
