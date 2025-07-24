using System.Diagnostics;
using System.Reflection;

namespace Operational
{
    public sealed class Diagnostic
    {
        public static string Class()
        {
            StackTrace Track = new StackTrace();
            StackFrame TrackStructure = Track.GetFrame(1);
            MethodBase TrackBase = TrackStructure.GetMethod();
            return TrackBase.ReflectedType.Name;
        }

        public static string Method(int Position)
        {
            StackTrace Track = new StackTrace();
            return Track.GetFrame(Position).GetMethod().Name;
        }
    }
}
