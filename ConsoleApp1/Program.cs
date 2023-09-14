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
            string confirm = "yes";
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

            }while(confirm=="yes");
        }
    }
}
