using System;

namespace Littlemath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lidt Matematik



            byte a = 1;

            byte b = 2;



            Console.WriteLine(a + b);

            Console.WriteLine(a / b);

            double test1 = Math.Pow(a, 2);
            double test2 = Math.Pow(b, 2);
            
            Console.WriteLine(test1 + " og " + test2);


            // Prevents the program from closing.
            Console.ReadKey();
        }
    }
}
