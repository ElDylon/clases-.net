using System;

namespace teoria1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colocar un numero para la sumatoria");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine("La sumatoria es: "+ sum);

            Console.Write("hola\\\\\\\\\\\\trolo");
            Console.ReadKey();
        }

    }
}
