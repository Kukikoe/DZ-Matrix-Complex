using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            string str1 = string.Empty;

            Console.WriteLine("Enter the height of the matrix A: ", str);
            int height = int.Parse(str = Console.ReadLine());
            Console.WriteLine("Enter the width of the matrix A: ", str1);          
            int width = int.Parse(str1 = Console.ReadLine());
            ClassMatrix a = new ClassMatrix(height, width);
            a.Create();

            Console.WriteLine("Enter the height of the matrix B: ", str);
            height = int.Parse(str = Console.ReadLine());
            Console.WriteLine("Enter the width of the matrix B: ", str1);
            width = int.Parse(str1 = Console.ReadLine());
            ClassMatrix b = new ClassMatrix(height, width);
            b.Create();

            try
            {
                ClassMatrix.Check(a, b);

                Console.Write("Matrix A:");
                a.Show();
                Console.WriteLine("\n");
                Console.Write("Matrix B:");
                b.Show();

                ClassMatrix multiply = a * b;
                Console.WriteLine("\n");
                Console.Write("A*B:");
                multiply.Show();
                Console.WriteLine("\n");
                Console.Write("A+B:");
                ClassMatrix sum = a + b;
                sum.Show();
                Console.WriteLine("\n");
                Console.Write("A-B:");
                ClassMatrix minus = a - b;
                minus.Show();
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Exception Message: height of matrix A doesn't match width of matrix B");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: matrix A and matrix B doesn't have the same size");
            }

            Console.ReadKey();
        }
    }
}
