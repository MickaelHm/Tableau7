using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        enum week
        {
            lundi,
            mardi,
            mercredi,
            jeudi,
            vendredi,
            saemdi,
            dimanche
        }
        static void Main(string[] args)
        {
            // foreach (int i in Enum.GetValues(typeof(week)))
            foreach (string i in Enum.GetNames(typeof(week)))
                Console.WriteLine(i);
            Console.WriteLine(Enum.GetNames(typeof(week)).GetValue(4));
            // ou bien Console.WriteLine(Enum.GetNames(typeof(week),4));

            /* correction
             * Console.WriteLine(week.lundi);
             * Console.WriteLine(week.mardi);
             * Console.WriteLine(week.mercredi);
             * Console.WriteLine(week.jeudi);
             * Console.WriteLine(week.vendredi);
             * Console.WriteLine(week.samedi);
             * Console.WriteLine(week.dimanche);
             * 
             * Console.Writeline((week)4);
        }
    }
}
