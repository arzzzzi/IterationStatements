using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR LOOP
            //var name = "Maga Agam";

            //for (var i = 0; i < name.Length; i++) 
            //{
            //    Console.WriteLine(name[i]);
            //}

            //FOREACH LOOP
            //var numbers = new int[4] { 1, 2, 3, 4 };

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //WHILE LOOP
            while (true) 
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input)) 
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break; 
            }
        }
    }
}
 