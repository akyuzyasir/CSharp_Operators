using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_13_AccessMethodsThroughObjects
{
    internal class Mathematics
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        private double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
