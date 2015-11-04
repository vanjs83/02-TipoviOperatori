using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pretvorba
{
    class Osoba
    {
        public string DajSvojOib()
        {
            return "1234567890";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 5;
        }
    }

    class Radnik : Osoba
    {
        public bool Napravi(string proizvod)
        {
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // dodati sve moguće pozive metoda za student
            student.DajSvojOib();
            student.Equals(5);
            student.GetHashCode();
            student.GetType();
            student.PoložiIspit("fizika");
            student.ToString();


            Osoba osobaS = student;
            // dodati sve moguće pozive metoda za osobaS
            osobaS.DajSvojOib();
            osobaS.Equals(6);
            osobaS.GetHashCode();
            osobaS.GetType();
            osobaS.ToString();

            Student sos = (Student)osobaS;
            // dodati sve moguće pozive metoda za sos
            sos.DajSvojOib();
            sos.Equals(1);
            sos.GetHashCode();
            sos.GetType();
            sos.PoložiIspit("povijest");
            sos.ToString();
            
            Osoba osobaR = new Radnik();
            // dodati sve moguće pozive metoda za osobaR
            osobaR.DajSvojOib();
            osobaR.Equals(2);
            osobaR.GetHashCode();
            osobaR.GetType();
            osobaR.ToString();
            
            Radnik sor = (Radnik)osobaR;
            // dodati sve moguće pozive metoda za sor
            sor.DajSvojOib();
            sor.Equals(9);
            sor.GetHashCode();
            sor.GetHashCode();
            sor.GetType();
            sor.Napravi("kolac");
            sor.ToString();
            
            
        }
    }
}
