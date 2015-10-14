using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.PlatformAbstractions
{
    /// <summary>
    /// Provides access to assembly loaders used for runtime assembly resolution.
    /// </summary>
    public interface IAssemblyLoaderContainer
    {
        /// <summary>
        /// Adds an <see cref="IAssemblyLoader"/> to the runtime.
        /// </summary>
        /// <param name="loader">The loader to add.</param>
        /// <returns>A disposable object representing the registration of the loader. Disposing it removes the loader from the runtime.</returns>
        IDisposable AddLoader(IAssemblyLoader loader);
    }
}
