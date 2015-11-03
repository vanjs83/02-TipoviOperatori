using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.TipoviOperatori
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Nullable<double>nulabilnaVarijabla=Math.PI;
            Console.WriteLine(nulabilnaVarijabla);

            double? nulabilniDuplić = Math.PI;
            Console.WriteLine(nulabilniDuplić);

            double običniDuplic = Math.PI;


            Console.ReadKey();
            
        }
    }
}
