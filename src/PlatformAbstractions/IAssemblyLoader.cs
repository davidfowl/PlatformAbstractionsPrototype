using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Microsoft.Extensions.PlatformAbstractions
{
    /// <summary>
    /// Defines a contract for an assembly loader. This is an extension point that can be used to implement custom assembly loading logic.
    /// </summary>
    public interface IAssemblyLoader
    {
        /// <summary>
        /// Load an assembly by name.
        /// </summary>
        /// <param name="assemblyName">The name of the assembly.</param>
        /// <returns>The loaded assembly.</returns>
        Assembly Load(AssemblyName assemblyName);
    }
}
