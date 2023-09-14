using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string confirm = "yes";
            int contador = 0,number=0;
            Console.Clear();
            Console.WriteLine("Digite el número que será multiplo: ");
    
            int answer = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Digite un número: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number % answer == 0)
                {
                    Console.WriteLine("\nEs multiplo de " + answer);

                }
                else
                {
                    Console.WriteLine("\nNo es multiplo de " + answer);

                }

                Console.WriteLine("QUIERE SEGUIR CON LOS MULTPLOS? yes/no");
                confirm = Console.ReadLine();
                contador++;

            }while(confirm=="yes");*/


            Class1 operaciones = new Class1();
            double x, y;
            string bandera = "yes";

            do
            {


                Console.WriteLine("Digitar un número");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Digitar otro número");
                y = double.Parse(Console.ReadLine());
                operaciones.suma(x, y);
                operaciones.multiplicacion(x, y);
                operaciones.resta(x, y);
                while (y == 0) 
                   
                {
                    operaciones.division(x, y);
                    Console.WriteLine("Digitar otra vez el denomidador");
                    y = double.Parse(Console.ReadLine());

                } ;                                                                                                      
                operaciones.division(x, y);
                Console.WriteLine("Quieres realizar las operaciones con otros números? yes/no");
                bandera = Console.ReadLine();


            } while (bandera == "yes");

           
        }
    }
}
