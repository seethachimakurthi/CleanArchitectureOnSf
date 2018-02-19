

namespace Common.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// unit of work management
    /// </summary>
    public interface IUnitOfWorkManagedItem
    {
        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="commands"></param>
        void Init(System.Collections.Concurrent.ConcurrentQueue<Adapter.ICommand> commands);

        /// <summary>
        /// create entity
        /// </summary>
        void ModelCreating();
    }

    /// <summary>
    /// Unit of work that can be passed initialization parameters
    /// </summary>
    /// < typeparam  name = " TInit " > Initialization parameter type </ typeparam >
    public interface IUnitOfWorkManagedItem<TInit> : IUnitOfWorkManagedItem
    {
        /// <summary>
        /// create entity
        /// </summary>
        /// < param  name = " parameter " > Initialization parameters </ param >
        void ModelCreating(TInit parameter);
    }
}
