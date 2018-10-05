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
            string menu = "";
            Console.WriteLine("Press 1 to division");
            Console.WriteLine("Press 2 to calculate happy number of ticket");
            Console.WriteLine("Press 3 to change font to upper case");
            Console.WriteLine("Press 4 for task four");
            Console.WriteLine("Press 5 for task five");
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
                }

                Console.WriteLine("Enter B value");
                string stringB = Console.ReadLine();
                result = double.TryParse(stringB, out double intB);
                if (result == false)
                {
                    Console.WriteLine("Value must be numeric!");
                }

                Console.WriteLine("Result of division is " + (d.div(intA, intB))); 
            }

            if (menu == "2")
            {
                int[] array = new int[10];

            }

                Console.ReadLine();
        }
    }
}
