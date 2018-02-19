

namespace Yajat.Digitalizer.DynamicCalculator.Bootstrap.Configuration
{
    using AutoMapper;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    using Yajat.Digitalizer.DynamicCalculator.Mapping.Variable;
    
    public static class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(configs =>
            {
                ConfigureVariableMappings(configs);
               
            });
            Mapper.AssertConfigurationIsValid();
        }

        private static void ConfigureVariableMappings(IProfileExpression configs)
        {
            configs.CreateMap<Variable, VariableResponseDto>().ConvertUsing<VariableToVariableResponseDtoTypeConverter>();
            configs.CreateMap<CreateVariableInputDto, Variable>().ConvertUsing<CreateVariableDtoToVariableTypeConverter>();
        }

        
    }
}
