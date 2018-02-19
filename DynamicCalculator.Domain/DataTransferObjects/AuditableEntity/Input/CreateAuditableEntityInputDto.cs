using System;
using System.Collections.Generic;
using System.Text;

namespace Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.AuditableEntity.Input
{
    public class CreateAuditableEntityInputDto
    {
        #region Implementation of IAuditableEntity
        public String CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public String UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }
        #endregion
    }
}
