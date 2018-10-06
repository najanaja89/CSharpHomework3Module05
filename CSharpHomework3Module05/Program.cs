using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework3Module05
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rand = new Random();
            string menu = "";
            Console.WriteLine("Press 1 to division");
            Console.WriteLine("Press 2 to task2");
    
            menu = Console.ReadLine();


            if (menu == "1")
            {
                division d = new division();
                Console.WriteLine("Enter A value");
                string stringA = Console.ReadLine();
                var result = double.TryParse(stringA, out double intA);
                if (result == false)
                {
                    Console.WriteLine("Value must be numeric!");
                    intA = 0;
                }

                Console.WriteLine("Enter B value");
                string stringB = Console.ReadLine();
                result = double.TryParse(stringB, out double intB);
                if (result == false)
                {
                    Console.WriteLine("Value must be numeric!");
                    intB = 1;
                }

                Console.WriteLine("Result of division is " + (d.div(intA, intB))); 
            }

            if (menu == "2")
            {
                int[] array = new int[10];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(1,100);
                }


                try
                {
                    for (int i = 0; i < array.Length+1; i++)
                    {
                        Console.Write(array[i] + "\t");
                    }
                    
                }
         
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error " + ex);
                }
                finally 
                {
                    Console.WriteLine("Job is Done! ");
                }
            }

                Console.ReadLine();
        }
    }
}
