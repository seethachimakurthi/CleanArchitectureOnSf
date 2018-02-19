namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.CalculationPeriod.Input
{
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.BaseEntity.Input;
    public class CreateCalculationPeriodInputDto : CreateBaseEntityInputDto
    {
        #region Implementation of ICalculationPeriod
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        #endregion
    }
}
