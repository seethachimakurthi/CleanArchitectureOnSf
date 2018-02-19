namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    public class ResultTransformerResponseDto : BaseEntityResponseDto, IResultTransformer
    {
        #region Implementation of IResultTransformer
        public double StartValue { get; set; }
        public double EndValue { get; set; }
        public double EquiavalentValue { get; set; }
        #endregion
    }
}
