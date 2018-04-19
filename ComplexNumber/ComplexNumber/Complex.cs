using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class Complex
    {
        public int i1, i2;

        public Complex()
        {
            this.i1 = 0;
            this.i2 = 0;
        }

        public static Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.i1 = a.i1 + b.i1;
            res.i2 = a.i2 + b.i2;
            return res;
        }

        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.i1 = a.i1 * b.i1 - a.i2 * b.i2;
            res.i2 = a.i2 * b.i1 + a.i1 * b.i2;
            return res;
        }

        public static Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.i1 = a.i1 - b.i1;
            res.i2 = a.i2 - b.i2;
            return res;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return Complex.Sum(a, b);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return Complex.Subtract(a, b);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return Complex.Multiplication(a, b);
        }

        public override string ToString()
        {
            return String.Format("{0} + {1}i", i1, i2);
        }

        public void PrintLine(Complex a)
        {
            Console.WriteLine("z = " + a);
        }
    }
}
