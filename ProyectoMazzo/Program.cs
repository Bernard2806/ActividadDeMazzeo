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
            Console.WriteLine("// AUTO");
            Console.WriteLine("Marca: " + auto1.getmarca());
            Console.WriteLine("Ruedas " + auto1.getruedas());
            Console.WriteLine("Color: " + auto1.getcolor());
            Console.WriteLine("Transmisión: " + auto1.gettransmision());
            Console.WriteLine("Velocidad: " + auto1.getvelocidad());
            Console.WriteLine("Precio: " + auto1.getprecio());
            Console.ReadKey();
            
        }
    }
}
