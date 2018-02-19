namespace Yajat.Digitalizer.DynamicCalculator.Mapping.Variable
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using AutoMapper;
    /// <inheritdoc />
    /// <summary>
    /// Converts a Variable object into a VariableResponseDto.
    /// Only not using the true Auto of Automapper incase other logic wants to be done later.
    /// You can also, unit test your logic this way.
    /// </summary>
    public class VariableToVariableResponseDtoTypeConverter :
        BaseTypeConverter<Domain.Entities.Variable, VariableResponseDto>,
        ITypeConverter<Domain.Entities.Variable, VariableResponseDto>
    {
        #region Implementation of ITypeConverter<in Variable,VariableToVariableResponseDto>

        public VariableResponseDto Convert(Domain.Entities.Variable source, VariableResponseDto destination, ResolutionContext context)
        {
            Guard(source, ref destination);

            destination.Id = source.Id;
            destination.Name = source.Name;
            //destination.Genre = source.Genre;
            //destination.Price = source.Price;
            //destination.ReleaseDate = source.ReleaseDate;

            return destination;
        }

        #endregion
    }
}
