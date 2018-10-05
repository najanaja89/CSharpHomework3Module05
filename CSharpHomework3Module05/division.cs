using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework3Module05
{
    class division
    {
        public double div(double a = 0, double b = 0)
        {
            try
            {
                if (a == 0 && b == 0)
                {
                    throw new ArgumentNullException();
                }
                else if (b == 0)
                {
                    throw new ArgumentNullException();
                }
                double c = a / b;
                return c;
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Ошибка" + ex);
                return 0;
            }
          
        }


    }
}
