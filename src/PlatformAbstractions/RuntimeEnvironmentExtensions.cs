using System;
using System.Collections.Generic;

namespace Microsoft.Extensions.PlatformAbstractions
{
    public static class RuntimeEnvironmentExtensions
    {
        public static bool IsMono(this IRuntimeEnvironment env)
        {
            return env.RuntimeType == "Mono";
        }
    }
}
