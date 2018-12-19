using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiti
{
    class Program
    {
        static void Main(string[] args)
        {
            int valore = 0;
            Console.WriteLine("inserire il numero in base decimale che si desidera convertire");
            valore = Convert.ToInt32(Console.ReadLine());
            string conversione = Convert.ToString(valore, 2);
            Console.WriteLine($"il numero {valore} diventa {conversione}");
            

            int valore2 = 0;
            Console.WriteLine("inserire il numero in base decimale che si desidera convertire");
            valore2 = Convert.ToInt32(Console.ReadLine());
            string conversione2 = Convert.ToString(valore2, 16);
            Console.WriteLine($"il numero {valore2} diventa {conversione}");

            int valore3 = 0;
            Console.WriteLine("inserire il numero in base decimale che si desidera convertire");
            valore3 = Convert.ToInt32(Console.ReadLine());
            string conversione3 = Convert.ToString(valore3, 8);
            Console.WriteLine($"il numero {valore3} diventa {conversione}");
            Console.ReadLine();

            Console.ReadLine();

            
        }
    }
}
