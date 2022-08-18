using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMazzo
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            auto1.setmarca("bmw");
            auto1.setcolor("Rojo");
            auto1.settransmision("Automatico");
            auto1.setvelocidad("360000000");
            auto1.setprecio(2);
        }
    }
}
