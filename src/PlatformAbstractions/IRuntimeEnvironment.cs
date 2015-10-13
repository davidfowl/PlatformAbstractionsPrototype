using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.PlatformAbstractions
{
    public interface IRuntimeEnvironment
    {
        string OperatingSystem { get; }

        string OperatingSystemVersion { get; }

        string RuntimeType { get; }

        string RuntimeArchitecture { get; }

        string Version { get; }
    }
}
