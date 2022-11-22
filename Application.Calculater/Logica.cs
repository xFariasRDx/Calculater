using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationFirst.Calculater
{
    public class Logica
    {
        public double Sumar (double num1, double num2)
        {
            double Resultado;
            Resultado = num1 + num2;
            return Resultado;
        }

        public double Restar (double num1, double num2)
        {
            double Resultado;
            Resultado = num1 - num2;
            return Resultado;
        }

        public double Multiplicar (double num1, double num2)
        {
            double Resultado;
            Resultado = num1 * num2;
            return Resultado;
        }

        public double Dividir(double num1, double num2)
        {
            double Resultado;
            Resultado = num1 / num2;
            return Resultado;
        }

    }
}
