namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    public class CalculationParameterGroupResponseDto : BaseEntityResponseDto, ICalculationParameterGroup
    {
        #region Implementation of ICalculationParameterGroup
        public string Name { get; set; }
        #endregion
    }
}
