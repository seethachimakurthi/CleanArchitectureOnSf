using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Persistence.Adapter
{
    /// <summary>
    /// Mongo storage mapper
    /// </summary>
    internal class MongoDataSourceMapping: IDataSourceMapper
    {
        private static byte[] Mapping { get; set; }

        static MongoDataSourceMapping()
        {
            Mapping = new byte[] { 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
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
