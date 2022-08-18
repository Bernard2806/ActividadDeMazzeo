using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMazzo
{
    class Auto
    {
        private string Marca;
        private int Ruedas;
        private string Color;
        private string Transmision;
        private string Velocidad;
        private double Precio;
        public Auto()
        {
            this.Ruedas = 4;
        }
        public void setmarca(string valor)
        {
            this.Marca = valor;
        }
        public void setcolor(string Color)
        {
            this.Color = Color;
        }
        public void settransmision(string valor)
        {
            this.Transmision = valor;
        }
        public void setvelocidad(string velocidad)
        {
            this.Velocidad = velocidad; 
        }
        public void setprecio(double precio)
        {
            this.Precio = precio;
        }
    }
}
