namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable
{
    using System.Collections.Generic;
    using System.Linq;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class VariableListResponseDto : ErrorDetail, IListResponseDto
    {
        public IEnumerable<IVariable> Variables { get; set; } = new List<IVariable>();

        #region Implementation of IListResponseDto

        public int Count => Variables.Count();

        #endregion
    }
}
