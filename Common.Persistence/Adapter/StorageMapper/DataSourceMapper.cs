

namespace Common.Persistence.Adapter
{
    using System;
    /// <summary>
    /// storage map
    /// </summary>
    public class DataSourceMapper: IDataSourceMapper
    {
        /// <summary>
        /// memory
        /// </summary>
        public static readonly IDataSourceMapper MemoryMapping = new MemoryDataSourceMapping();

        /// <summary>
        /// Mssql
        /// </summary>
        public static readonly IDataSourceMapper MssqlMapping = new MssqlDataSourceMapping();

        /// <summary>
        /// Mongo
        /// </summary>
        public static readonly IDataSourceMapper MongoMapping = new MongoDataSourceMapping();

        /// <summary>
        /// formatting
        /// </summary>
        /// <param name="input"></param>
        /// <param name="mapping"></param>
        /// <returns></returns>
        public static byte[] Format(byte[] input, IDataSourceMapper mapping)
        {
            if (input == null) throw new ArgumentNullException("input");
            if (mapping == null) throw new ArgumentNullException("mapping");
            if (input.Length != 16) throw new ArgumentOutOfRangeException("input");

            var context = mapping.GetMapping();
            var result = new byte[16];
            for (var i = 0; i < result.Length; i++)
            {
                result[context[i]] = input[i];
            }
            return result;
        }
    }
}
