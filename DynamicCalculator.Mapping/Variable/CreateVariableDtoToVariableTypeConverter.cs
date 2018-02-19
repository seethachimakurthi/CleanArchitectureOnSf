

namespace Yajat.Digitalizer.DynamicCalculator.Mapping.Variable
{
    using AutoMapper;
   
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input;

    public class CreateVariableDtoToVariableTypeConverter :
        BaseTypeConverter<CreateVariableInputDto, Yajat.Digitalizer.DynamicCalculator.Domain.Entities.Variable>,
        ITypeConverter<CreateVariableInputDto, Domain.Entities.Variable>
    {
        #region Implementation of ITypeConverter<in IVariable,Variable>

        public Domain.Entities.Variable Convert(CreateVariableInputDto source, Domain.Entities.Variable destination, ResolutionContext context)
        {
            Guard(source, ref destination);

            destination.Name = source.Name;
            //destination.Genre = source.Genre;
            //destination.Price = source.Price;
            //destination.ReleaseDate = source.ReleaseDate;

            return destination;
        }

        #endregion
    }
}
