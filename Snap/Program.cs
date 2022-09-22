using System;

namespace Snap
{
    class Program
    {
        public static bool Snap(string p1, string p2, string p3)
        {
            if ((p1.Equals(p2)) & (p1.Equals(p3)))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
