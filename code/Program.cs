using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Get_UTC_Zone
{
    class Program
    {
        static void Pause()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            int offset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours;
            string sign = "";
            if (offset > 0)
            {
                sign = " + ";
            }
            else
            {
                sign = " - ";
            }
            string zone = "UTC(GMT)" + sign + offset;
            Console.WriteLine(zone);
            Pause();
        }
    }
}
