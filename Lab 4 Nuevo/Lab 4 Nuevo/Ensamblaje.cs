using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Nuevo
{
    class Ensamblaje : Maquina
    {
        private int MemorieMax = 10;
        private int MemorieUse = 0;

        public override void OFF()
        {
            Console.WriteLine("WATCH OUT!  APAGANDO ENSAMBLAJE");
        }
        public override void ON()
        {
            MemorieUse = 0;
            Console.WriteLine("HELLO! ENCENDIENDO ENSAMBLAJE ");
        }
        public override bool RESTART()
        {
            if (MemorieUse >= MemorieMax)
            {
                Console.WriteLine("SAD NEWS! ENSAMBLAJE NECESITA REINICIAR");
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void PROCESS(int Weight)
        {
            MemorieUse += Weight;
        }
    }
}

