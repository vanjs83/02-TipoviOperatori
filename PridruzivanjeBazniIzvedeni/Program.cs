
namespace CSharp.TipoviOperatori
{
    class Osoba
    {
        public string DajOib()
        {
            return "0123456789";
        }
    }

    class Student : Osoba
    {
        public int PoložiIspit(string predmet)
        {
            return 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.ToString();
            osoba.DajOib();
            osoba.GetHashCode();
            osoba.GetType();
            osoba.Equals( "545451454");



            
            Osoba osobaStudent = new Student();
            osobaStudent.DajOib();
            osobaStudent.Equals(5);
            osobaStudent.GetHashCode();
            osobaStudent.GetType();
            osobaStudent.ToString();

            //Student studos = new Osoba(); moramo izvesti eksplicitni cast

        }
    }
}
