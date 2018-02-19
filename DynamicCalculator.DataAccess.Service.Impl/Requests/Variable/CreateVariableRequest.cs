namespace DynamicCalculator.DataAccess.Service.Requests.Variable
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Yajat.Digitalizer.DynamicCalculator.DataAccess.Service;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Services.Requests.Variable;
    using Serilog;
    using AutoMapper;
    public class CreateVariableRequest : BaseServiceRequest<Variable>, ICreateVariableRequest
    {
        public CreateVariableRequest(IRepository<Variable> repository, IRepositoryAggregate repositoryAggregate)
            : base(repository, repositoryAggregate) { }

        #region Implementation of ICreateVariableRequest

        public VariableResponseDto Execute(CreateVariableInputDto Variable)
        {
            var VariableResponse = new VariableResponseDto();
            try
            {
                Log.Information("Creating Variable Entry for [{NewName}].", Variable?.Name);
                var VariableEntity = Mapper.Map<CreateVariableInputDto, Variable>(Variable);
                VariableResponse = Mapper.Map(Repository.Create(VariableEntity), VariableResponse);
                VariableResponse.StatusCode = 200;
            }
            catch (Exception exception)
            {
                Log.Error(exception, "Failed to Create Variable: [{NewName}].", Variable?.Name);
                HandleErrors(VariableResponse, exception);
            }
            return VariableResponse;
        }

        #endregion
    }
}
