namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationTemplate.Input
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateCalculationTemplateInputDto: CreateBaseEntityInputDto
    {
        #region Implementation of ICalculationTemplate
        public string Name { get; set; }
        #endregion
    }
}
