using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace Microsoft.Extensions.PlatformAbstractions
{
    public interface IApplicationEnvironment
    {
        string Name { get; }

        string Version { get; }

        string BasePath { get; }

        FrameworkName RuntimeFramework { get; }
    }
}
