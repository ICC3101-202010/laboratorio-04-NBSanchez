using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Nuevo
{
    abstract class Maquina
    {
        abstract public void OFF();
        abstract public void ON();
        abstract public bool RESTART();
        abstract public void PROCESS(int Weight);

    }

}

