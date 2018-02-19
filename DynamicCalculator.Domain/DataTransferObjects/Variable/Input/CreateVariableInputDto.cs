namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input
{
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateVariableInputDto: CreateBaseEntityInputDto
    {
        #region Implementation of IVariable
        public string Name { get; set; }


        public string DefaultValue { get; set; }

        public string Definition { get; set; }

        public int Priority { get; set; }

        public string RangeStart { get; set; }

        public string RangeEnd { get; set; }
        #endregion
    }
}
