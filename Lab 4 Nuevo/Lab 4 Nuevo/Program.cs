using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Nuevo
{
    class Program
    {
        static void Main(string[] args)
        {
            CompuCentral cc = new CompuCentral();
            Random random = new Random();
            int Hour = 8;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("HAZ INGRESADO A LA COMPUTADORA CENTRAL: ");
                Console.WriteLine("");
                Console.WriteLine("ESCOJA UNA DE LAS SIGUIENTES OPCIONES POR NUMERO/LETRA: ");
                Console.WriteLine("");
                Console.WriteLine("1. PROGRAMA MANUAL: ");
                Console.WriteLine("2. PROGRAMA AUTOMATICO: ");
                Console.WriteLine("");

                string firstoption = Console.ReadLine();
                if (firstoption == "1")
                {
                    Console.WriteLine("NO LOGRE TERMINAR EL BONUS");
                    continue;
                }
                else if (firstoption != "1" && firstoption != "2" )
                {
                    Console.WriteLine("ESA OPCION NO ES VALIDA, PORFAVOR INGRESELA NUEVAMENTE: ");
                    continue;
                }
                else if (firstoption == "2")
                {
                    Console.WriteLine("Hora de partida: " + Hour + " : 00");
                    Console.WriteLine("");
                    cc.FabricOn();

                    for (int x = 10; x < 20; x++)
                    {
                        Console.WriteLine("Hora actual de trabajo: " + Hour + " :00");
                        Console.WriteLine("");
                        List<int> Piezas = new List<int>() { random.Next(1, 10), random.Next(1, 8), random.Next(1, 6), random.Next(1, 4), random.Next(1, 5) };
                        cc.Work(Piezas);
                        cc.CheckReset();
                        Console.WriteLine("");
                        Hour++;
                    }
                    Console.WriteLine("Hora de cierre: " + Hour + " :00");
                    Console.WriteLine("");
                    cc.FabricOff();
                    Console.WriteLine("Todo apagado y buenas noches nos vemos mañana");
                    break;


                }

            }
        }
    }
}
