using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Persistence.Adapter
{
    /// <summary>
    /// memory storage mapper
    /// </summary>
    internal class MemoryDataSourceMapping: IDataSourceMapper
    {
        private static byte[] Mapping { get; set; }

        static MemoryDataSourceMapping()
        {
            Mapping = new byte[] { 15, 14, 13, 12, 11, 10, 9, 8, 6, 7, 4, 5, 0, 1, 2, 3 };
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
