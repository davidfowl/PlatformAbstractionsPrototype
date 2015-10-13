using System;

namespace Microsoft.Extensions.PlatformAbstractions
{
    internal class RuntimeEnvironment : IRuntimeEnvironment
    {
        public string OperatingSystem
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string OperatingSystemVersion
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string RuntimeArchitecture
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string RuntimeType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Version
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}