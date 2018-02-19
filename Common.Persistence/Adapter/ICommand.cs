using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Persistence.Adapter
{
    /// <summary>
    /// command
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// type
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// implementation
        /// </summary>
        /// <returns></returns>
        bool Execute();
    }
}
