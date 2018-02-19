namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.ResultTransformer
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class ResultTransformerListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<IResultTransformer> ResultTransformers { get; set; } = new List<IResultTransformer>();

        #region Implementation of IListResponseDto

        public int Count => ResultTransformers.Count();

        #endregion
    }
}
