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
        

        public static  Action<dynamic> Begrüßung = Eingabeparam =>
        {
            var grüßung = $"Hello {Convert.ToString(Eingabeparam)}!";
            Console.WriteLine(grüßung);
        };
        
       

    }

   
}
