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
            Console.ReadLine();
        }
    }
}
