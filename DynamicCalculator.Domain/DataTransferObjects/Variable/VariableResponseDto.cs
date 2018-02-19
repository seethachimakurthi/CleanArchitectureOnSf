

namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    public class VariableResponseDto : BaseEntityResponseDto, IVariable
    {
        public string Name { get; set; }

       
        public string DefaultValue { get; set; }

        public string Definition { get; set; }

        public int Priority { get; set; }
        public string RangeStart { get; set; }
        public string RangeEnd { get; set; }
    }
}
