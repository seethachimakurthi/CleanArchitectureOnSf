namespace Common.Persistence.Adapter
{
    /// <summary>
    /// MSSQL storage mapper
    /// </summary>
    internal class MssqlDataSourceMapping : IDataSourceMapper
    {
        private static byte[] Mapping { get; set; }

        static MssqlDataSourceMapping()
        {
            Mapping = new byte[] { 3, 2, 1, 0, 5, 4, 7, 6, 9, 8, 15, 14, 13, 12, 11, 10 };
        }

        /// <summary>
        /// Get mapper
        /// </summary>
        /// <returns></returns>
        public byte[] GetMapping()
        {
            return Mapping;
        }
    }
}
