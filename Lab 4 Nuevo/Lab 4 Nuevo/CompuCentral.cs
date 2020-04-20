using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Nuevo
{
     class CompuCentral
    {
        private Recepcion RECEP = new Recepcion();
        private Almacenamiento ALMA = new Almacenamiento();
        private Ensamblaje ENSAM = new Ensamblaje();
        private Verificacion VERI = new Verificacion();
        private Empaque EMPA = new Empaque();

        public void FabricOn()
        {
            RECEP.ON();
            ALMA.ON();
            ENSAM.ON();
            VERI.ON();
            EMPA.ON();
        }
        public void FabricOff()
        {
            RECEP.OFF();
            ALMA.OFF();
            ENSAM.OFF();
            VERI.OFF();
            EMPA.OFF();
        }
        public void Work(List<int> Weight)
        {
            RECEP.PROCESS(Weight[0]);
            ALMA.PROCESS(Weight[1]);
            ENSAM.PROCESS(Weight[2]);
            VERI.PROCESS(Weight[3]);
            EMPA.PROCESS(Weight[4]);
        }

        public void CheckReset()
        {
            List<Maquina> allMaquinas = new List<Maquina>() { RECEP, ALMA, ENSAM, VERI, EMPA };
            for (int i = 0; i < allMaquinas.Count(); i++)
            {
                bool compReset = allMaquinas[i].RESTART();
                if (compReset == true)
                {
                    allMaquinas[i].OFF();
                    allMaquinas[i].ON();
                }
                else
                {
                    Console.WriteLine("Con viento en popa vamos con nuestra produccion"); // Aparece esto cuando no hay que reiniciar la maquina que se esta testeando//
                    
                }
            }
        }

    }
}
