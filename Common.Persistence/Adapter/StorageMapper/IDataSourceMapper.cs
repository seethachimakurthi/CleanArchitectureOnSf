namespace Common.Persistence.Adapter
{
    /// <summary>
    /// data source mapper
    /// </summary>
    public interface IDataSourceMapper
    {
        /// <summary>
        /// Get the mapping
        /// </summary>
        /// <returns></returns>
        byte[] GetMapping();
    }
}
