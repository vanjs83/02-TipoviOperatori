
namespace CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
        public S(int aS, double bS) {
            a = aS;
            b = bS;
    }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //zadatak1
            var i0 = 5;//prevoditelj sam dodaje tip podatka ovisno kakvu smo vrijednost napisali
            var d0 = 3.2;
            //i0 = d0;nema implicitnog kastanja
            //zadatak2
            int i1 = 5;
            double d1 = 3.2;
            //zadatak3
          var s=new S(2,3.15);
          



            
        }
    }
}
