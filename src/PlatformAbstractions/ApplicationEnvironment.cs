using System;
using System.Runtime.Versioning;

namespace Microsoft.Extensions.PlatformAbstractions
{
    internal class ApplicationEnvironment : IApplicationEnvironment
    {
        public string BasePath
        {
            get
            {
#if NET45
                return (string)AppDomain.CurrentDomain.GetData("APP_CONTEXT_BASE_DIRECTORY") ?? AppDomain.CurrentDomain.BaseDirectory;
#else
                return AppContext.BaseDirectory;
#endif
            }
        }

        public string Name
        {
            get
            {
                return null;
            }
        }

        public string Version
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public FrameworkName TargetFramework
        {
            get
            {
#if NET45
                var frameworkName = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
                if (!string.IsNullOrEmpty(frameworkName))
                {
                    return new FrameworkName(frameworkName);
                }
#endif
                return null;
            }
        }
    }
}