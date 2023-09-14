using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1

    {
        public void suma(double a, double b) {
            mostrarResultado(a, b, a + b, "+");
        }
        public void resta(double a, double b)
        {
            mostrarResultado(a, b, a - b, "-");
        }
        public void multiplicacion(double a, double b){

            mostrarResultado(a, b, a * b, "*");

        }
        public void division(double a, double b)
        {
            if (b == 0)
                Console.WriteLine("No se puede realizar la operacion");
            else
            {
                mostrarResultado(a,b,a/b,"/");

            }

        }
   public void mostrarResultado(double a, double b, double resultado ,string operador)
        {
            Console.WriteLine("El resultado de " + a + operador + b + " = " + resultado);
        }


    }
}
