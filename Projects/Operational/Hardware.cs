using System;
using System.Management;

namespace Operational
{
    public sealed class Hardware
    {
        public static string Label()
        {
            return Environment.MachineName;
        }
    }
}
