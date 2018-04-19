using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            Console.Write("Enter the integer part of the first complex number: ");
            c1.i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the imaginary part of the first complex number: ");
            c1.i2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the integer part of the second complex number: ");
            c2.i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the imaginary part of the second complex number: ");
            c2.i2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Complex numbers: ");
            c1.PrintLine(c1);
            c2.PrintLine(c2);

            Console.WriteLine("Sum:         {0} + {1}i", (c1 + c2).i1, (c1 + c2).i2);
            Console.WriteLine("Multiply:    {0} + {1}i", (c1 * c2).i1, (c1 * c2).i2);
            Console.WriteLine("Subtract:    {0} + {1}i", (c1 - c2).i1, (c1 - c2).i2);
            Console.ReadKey();
        }
    }
}
