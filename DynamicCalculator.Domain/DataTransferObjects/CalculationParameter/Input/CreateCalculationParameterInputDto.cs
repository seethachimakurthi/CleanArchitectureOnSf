namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationParameter.Input
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateCalculationParameterInputDto : CreateBaseEntityInputDto
    {
        #region Implementation of ICalculationParameter
        public string Name { get; set; }
        public string EquiavalentValue { get; set; }
        #endregion
    }
}
