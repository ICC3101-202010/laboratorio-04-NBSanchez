using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Nuevo
{
    class Empaque : Maquina
    {
        private int MemorieMax = 7;
        private int MemorieUse = 0;

        public override void OFF()
        {
            Console.WriteLine("WATCH OUT!  APAGANDO EMPAQUE");
        }
        public override void ON()
        {
            MemorieUse = 0;
            Console.WriteLine("HELLO! ENCENDIENDO EMPAQUE ");
        }
        public override bool RESTART()
        {
            if (MemorieUse >= MemorieMax)
            {
                Console.WriteLine("SAD NEWS! EMPAQUE NECESITA REINICIAR");
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
