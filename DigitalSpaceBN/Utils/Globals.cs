using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalSpaceBN.Utils
{
    public static class Globals
    {
        public static DateTime GetFechaActual()
        {
            return DateTime.UtcNow.AddHours(-5);
        }
    }
}
