

namespace Yajat.Digitalizer.DynamicCalculator.DataAccess.EfCore
{
    using Microsoft.EntityFrameworkCore;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;
    public interface IApplicationContext
    {
        DbSet<Variable> Variables { get; set; }
       
    }
}
