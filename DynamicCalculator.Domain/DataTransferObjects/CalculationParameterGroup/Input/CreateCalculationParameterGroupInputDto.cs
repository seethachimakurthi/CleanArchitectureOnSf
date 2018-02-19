namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameterGroup.Input
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateCalculationParameterGroupInputDto : CreateBaseEntityInputDto
    {
        #region Implementation of ICalculationParameterGroup
        public string Name { get; set; }
        #endregion
    }
}
