using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class Calculadora
    {
        public double Soma(double a, double b)
        {
            return a + b;
        }
        public double Divisao(double a, double b)
        {
            double c = 0.0;
            c =  a / b;
            return c;
        }
    }
}
