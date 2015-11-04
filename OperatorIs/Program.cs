using System;

namespace CSharp.TipoviOperatori
{
    class Osoba { }

    class Student : Osoba { }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba janko = new Student();
            
            Osoba osoba = new Osoba();
            if (janko is Student)
                Console.WriteLine("janko je tipa Student \n");
            if(janko is Osoba)
                Console.WriteLine("janko je tipa Osoba\n");
            if (osoba is Osoba)
                Console.WriteLine("osoba je tipa Osoba\n");
            if(osoba is Student)
                Console.WriteLine("osoba je tipa Student\n");
                Console.ReadKey();
            
        }
    }
}
