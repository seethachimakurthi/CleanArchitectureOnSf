namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    public class CalculationParameterResponseDto : BaseEntityResponseDto, ICalculationParameter
    {
        #region Implementation of ICalculationParameter
        public string Name { get; set; }
        public string EquiavalentValue { get; set; }
        #endregion
    }
}
