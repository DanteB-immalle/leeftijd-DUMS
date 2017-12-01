using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bereken_hoe_oud_je_bent_DUMS
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime jeuj = new DateTime(2000, 01, 17, 04, 0, 0);
            TimeSpan oud = DateTime.Now - jeuj;

            Console.WriteLine("{0} dagen, {1} uur, {2} minuten en {3} seconden om precies te zijn...", oud.Days, oud.Hours, oud.Minutes, oud.Seconds);
            Console.WriteLine("Oftewel {0} seconden...", oud.TotalSeconds);
        }
    }
}
