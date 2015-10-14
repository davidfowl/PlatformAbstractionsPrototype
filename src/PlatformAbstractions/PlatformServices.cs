using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace Microsoft.Extensions.PlatformAbstractions
{
    public abstract class PlatformServices
    {
        public static PlatformServices Default = new DefaultEnvironmentServices();

        public abstract IApplicationEnvironment Application { get; }

        public abstract IRuntimeEnvironment Runtime { get; }

        public abstract IAssemblyLoaderContainer LoaderContainer { get; }

        public static void SetDefault(PlatformServices @default)
        {
            // TODO: Thread safety
            Default = @default;
        }

        private class DefaultEnvironmentServices : PlatformServices
        {
            public DefaultEnvironmentServices()
            {
                Application = new ApplicationEnvironment();
                Runtime = new RuntimeEnvironment();
            }

            public override IApplicationEnvironment Application { get; }

            public override IAssemblyLoaderContainer LoaderContainer { get; }

            public override IRuntimeEnvironment Runtime { get; }
        }
    }
}
