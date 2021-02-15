using System.Runtime.InteropServices;

namespace Q3
{
    public class Qmath
    {
        [DllImport("Q_rsqrt_Unity_DLL", EntryPoint = "Q_rsqrt")]
        public static extern float Q_rsqrt(float number);
    }
}
