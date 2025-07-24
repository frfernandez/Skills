using System.IO;
using System.Windows.Forms;

namespace Operational
{
    public sealed class SystemApplication
    {
        public static string PathLetter()
        {
            return Path.GetPathRoot(Application.ExecutablePath).Substring(0, 1);
        }

        public static string CompletePath()
        {
            return Path.GetDirectoryName(Application.ExecutablePath);
        }
    }
}
