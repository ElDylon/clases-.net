using System;

namespace ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 11;
            Console.WriteLine(Tuvieja(a,b));
            Console.Write("Hola");
            Console.ReadKey();
            Console.WriteLine(" Mundo");
            Console.ReadKey();
        }
        static int Tuvieja(int a, int b)
        {
            return a + b;
        }
    }
}
