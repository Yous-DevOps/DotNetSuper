using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDevOps
{
    internal class DelegatenKlasse
    {
        public delegate decimal GivDecimal(decimal value);
        public delegate void Output(String x); // es wird als Stellvertreter von "OutUsage" Methode definiert.

        public static GivDecimal givDecimal = (decimal num) =>
        {
            return num;
        };
      
        static void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }

       
        public static void OutUsage(String msg)
        {

            Divide(10, 3, out int res, out int rem);
            Console.WriteLine($"{res} {rem} mit delegaten {msg}");  // "3 1"
        }
        public static void CallDelegate(Output output) // Output delegate is als übergabeparameter aufgerufen worden.
        {
            output("von main methode");
        }
        public static void WeiterleitenAnProgramklasse()
        {
            CallDelegate(OutUsage);
            decimal Giv = givDecimal(213213);
            Console.WriteLine($" Hi Yousef, {Giv} ist von GivDecimal Delegate !");

        }
    }
}
