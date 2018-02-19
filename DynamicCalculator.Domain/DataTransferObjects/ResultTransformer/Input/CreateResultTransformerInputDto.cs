namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer.Input
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateResultTransformerInputDto: CreateBaseEntityInputDto
    {
        #region Implementation of IResultTransformer
        public double StartValue { get; set; }
        public double EndValue { get; set; }
        public double EquiavalentValue { get; set; }
        #endregion
    }
}
