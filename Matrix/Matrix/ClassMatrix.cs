using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class ClassMatrix
    {
        int width, height;
        int[,] matrix;

        public ClassMatrix(int height, int width)
        {
            this.height = height;
            this.width = width;  
            matrix = new int[height, width];
        }

        public void Create()
        {
            Random rnd = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
        }

        public static void Check(ClassMatrix a, ClassMatrix b)
        {
            if(a.height != b.width || a.width != b.height)
            {
                throw new ArithmeticException();
            }
        }

        public static ClassMatrix operator -(ClassMatrix a, ClassMatrix b)
        {
            ClassMatrix res = new ClassMatrix(a.height, a.width);
            for (int i = 0; i < a.height; i++)
            {
                for (int j = 0; j < a.width; j++)
                {
                        res.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                }
            }
            return res;
        } 

        public static ClassMatrix operator +(ClassMatrix a, ClassMatrix b)
        {
            ClassMatrix res = new ClassMatrix(a.height, a.width);
            for (int i = 0; i < a.height; i++)
            {
                for (int j = 0; j < a.width; j++)
                {
                    res.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                }
            }
            return res;
        }

        public static ClassMatrix operator *(ClassMatrix a, ClassMatrix b)
        { 
                ClassMatrix res = new ClassMatrix(a.height, b.width);
                for (int i = 0; i < a.height; i++)
                {
                    for (int j = 0; j < b.width; j++)
                    {
                        res.matrix[i, j] = 0;
                        for (int k = 0; k < b.width; k++)
                        {
                            res.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                        }
                    }
                }
                return res;
        }

        public void Show()
        {
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
            }
        }
    }
}
