using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    class Matrix
    {
        int matrix[,];

        public Matrix(int[,] m)
        {
            matrix = m;
        }

        public Matrix ScalarMultiply(int x)
        {
            int retvals = x * 2;
        }
        public Matrix Add(int x)
        {
            int retvals = x * 2;
        }
    }

}
