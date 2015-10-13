using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace Microsoft.Extensions.PlatformAbstractions
{
    public abstract class EnvironmentServices
    {
        public static readonly EnvironmentServices Default = new DefaultEnvironmentServices();

        public abstract IApplicationEnvironment Application { get; }

        public abstract IRuntimeEnvironment Runtime { get; }

        private class DefaultEnvironmentServices : EnvironmentServices
        {
            public DefaultEnvironmentServices()
            {
                Application = new ApplicationEnvironment();
                Runtime = new RuntimeEnvironment();
            }

            public override IApplicationEnvironment Application { get; }

            public override IRuntimeEnvironment Runtime { get; }
        }
    }
}
