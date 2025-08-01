using System;
using System.Runtime.CompilerServices;
namespace api
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele DOUBLE Werte möchten Sie eingeben?");
            Console.WriteLine("Die Quadratwurzel wird für jeden Wert berechnet."); 
            int y = int.Parse(Console.ReadLine());
            int[] ints = new int[y];
            for (int i = 0; i < y; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double z = Math.Sqrt(x);
                Console.WriteLine("Die Wurzel aus   " + x);
                Console.WriteLine("Ist   " + z);
                List<double> list = new List<double>();
                list.Add(z);


                if (i == y)
                {
                    Console.WriteLine("Möchten Sie noch einen Wert eingeben? (j/n)");
                    string input = Console.ReadLine();
                    if (input == "j")
                    {
                        i--; // Decrement i to allow another input  
                        Console.WriteLine("Nächster Wert:  ");
                    }

                    else return;
                }
                
            }
        }
    }
}