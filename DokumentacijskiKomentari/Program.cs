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
            Console.WriteLine(Kvadrat(5));
            Console.WriteLine(DuljinaDvijeRiječi("dva", "2"));
        }

        /// <summary>
        ///   Izračunava kvadrat broja.
        /// </summary>
        /// <param name="broj">
        ///   Broj čiji kvadrat treba izračunati.
        /// </param>
        /// <returns>
        ///   Zadani broj na kvadrat, tipa <c>double</c>.
        /// </returns>
        static double Kvadrat(double broj)
        {
            return broj * broj;
        }

        /// <summary>
        /// Funkcija duljinaDvije Rijeci vraca broj karaktera ybroju dviju rijeci
        /// </summary>
        /// <param name="prva"></param>
        /// Prva rijec u funkciji, prvi parametar
        /// <param name="druga"></param>
        /// druga rijec u funkciji drugi parametar
        /// <returns></returns>
        static int DuljinaDvijeRiječi(string prva, string druga)
        {
            return (prva + druga).Length;
        }
    }
}
