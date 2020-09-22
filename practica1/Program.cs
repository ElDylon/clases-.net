using System;

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "c:\\windows\\system";
            Console.WriteLine(st);
            Console.WriteLine("100".Length);
            Ejercicio7();
            Console.ReadKey();
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ingresar un nombre a evaluar");
            string something = Console.ReadLine();
            if (something == "") 
            {
                Console.WriteLine("Hola mundo");
            }
            else 
            {
                Console.WriteLine("Que onda, como va "+something);
            }
        }

        static void Ejercicio5a()
        {
            Console.WriteLine("Ingrese el nombre de una persona");
            string someone = Console.ReadLine();
            if (someone == "juan")
            {
                Console.WriteLine("Hola amigo!");
            }
            else if (someone =="maria")
            {
                Console.WriteLine("Buen día señora");
            }
            else if (someone == "alberto")
            {
                Console.WriteLine("la concha de tu madre alberto");
            }
            else if (someone == "")
            {
                Console.WriteLine("Buen dia Mundo");
            }
        }

        static void Ejercicio5b()
        {
            Console.WriteLine("Ingrese el nombre de una persona");
            string someone = Console.ReadLine();
            switch (someone)
            {
                case "juan":
                    Console.WriteLine("Hola amigo!");
                    break;

                case "maria":
                    Console.WriteLine("Buen día señora");
                    break;

                case "alberto":
                    Console.WriteLine("La concha de tu madre alberto");
                    break;

                default:
                    Console.WriteLine("Buen día mundo");
                    break;
            }
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Ingresar cadenas de caracteres");
            string st = Console.ReadLine();
            while (st != "")
            {
                Console.WriteLine(st.Length);
                st = Console.ReadLine();
            }
        }

        static void Ejercicio7()
        {
            string st1, st2, cm;
            Console.WriteLine("Escriba 2 cadenas de caracteres separadas por un espacio");
            st1 = Console.ReadLine();
            string[] myArr = st1.Split(' ');
            //esto es un comentario trolo
            cm = new string(myArr);
            if (st1 == cm)
            {
                Console.WriteLine("La palabra es simétrica");
            }
            else
            {
                Console.WriteLine("la palabra no es simétrica");
            }
        }
    }
}
