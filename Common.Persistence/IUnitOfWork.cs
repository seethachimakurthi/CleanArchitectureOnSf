namespace Yajat.Digitalizers.Common.Persistence
{
    /// <summary>
    /// Unit of Work
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// submit
        /// </summary>
        /// <returns>Update Count</returns>
        int Commit();
    }
}
