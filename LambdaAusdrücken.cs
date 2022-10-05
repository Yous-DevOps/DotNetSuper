using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SuperDevOps
{
    internal class LambdaAusdrücken
    {

        readonly static Func<String, int> func = (eingeben) => int.Parse(eingeben) * 2;
        public static  Action<dynamic> Begrüßung = Eingabeparam =>
        {
            var grüßung = $"Hello {Convert.ToString(Eingabeparam)}!";
            int b = func("2");
            Console.WriteLine(grüßung);
            Console.WriteLine(b);
            
        };
        
        
        
       

    }

   
}
