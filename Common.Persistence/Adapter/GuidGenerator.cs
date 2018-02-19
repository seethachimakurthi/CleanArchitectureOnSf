using Common.Persistence.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Persistence.Adapter
{
    /// <summary>
    /// Guid generator
    /// </summary>
    public class GuidGenerator
    {
        /// <summary>
        /// default instance
        /// </summary>
        public static readonly GuidGenerator Default = new GuidGenerator();

        private byte[] Hash { get; set; }

        private uint Seed { get; set; }

        private byte[] LastTime { get; set; }

        private readonly object Locker = new object();

        /// <summary>
        /// Created for memory sorting
        /// </summary>
        /// <returns></returns>
        public static Guid CreateForMemory()
        {
            return Default.Create(DataSourceMapper.MemoryMapping);
        }

        /// <summary>
        /// Created for the MSSQL database sorting purposes
        /// </summary>
        /// <returns></returns>
        public static Guid CreateForMssql()
        {
            return Default.Create(DataSourceMapper.MssqlMapping);
        }

        /// <summary>
        /// Created for MongoDB database sorting
        /// </summary>
        /// <returns></returns>
        public static Guid CreateForMongo()
        {
            return Default.Create(DataSourceMapper.MongoMapping);
        }

        /// <summary>
        /// Create a generator
        /// </summary>
        public GuidGenerator()
        {
            var machineName = Environment.MachineName;
            var processId = System.Diagnostics.Process.GetCurrentProcess().Id;
            var domainId = AppDomain.CurrentDomain.Id;
            var buffer = new List<byte>();
            buffer.AddRange(Encoding.UTF8.GetBytes(machineName));
            buffer.AddRange(BitConverter.GetBytes(processId));
            buffer.AddRange(BitConverter.GetBytes(domainId));
            Hash = new System.Security.Cryptography.SHA256CryptoServiceProvider().ComputeHash(buffer.ToArray());
            Seed = 0;
            LastTime = new byte[6];
        }

        private uint GetNextSeed(byte[] time)
        {
            lock (Locker)
            {
                if (!IsSame(LastTime, time, 2))
                {
                    Seed = 0;
                    Array.Copy(time, 2, LastTime, 0, 6);
                }
                return Seed++;
            }
        }

        private bool IsSame(byte[] source, byte[] target, int targetOffset)
        {
            for (var i = 0; i < source.Length; i++)
            {
                if (source[i] != target[i + targetOffset]) return false;
            }
            return true;
        }

        /// <summary>
        /// create
        /// </summary>
        /// < param  name = " mapping " > storage mapper </ param >
        /// <returns></returns>
        public Guid Create(IDataSourceMapper mapping)
        {
            var content = new byte[16];
            var time = BitConverter.GetBytes(DateTime.Now.Ticks);
            var seed = BitConverter.GetBytes(GetNextSeed(time));
            Array.Copy(Hash, 0, content, 0, 6);
            Array.Copy(seed, 0, content, 6, 4);
            Array.Copy(time, 2, content, 10, 6);

            if (mapping == null)
            {
                return new Guid(content);
            }
            else
            {
                return new Guid(StorageMapping.Format(content, mapping));
            }
        }
    }
}
