using System;
using practica_abstracta.clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_abstracta.clases
{
    internal class mamiferos : animales
    {
        private string nombreSerVivo;

        public mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("el nombre del mamifero es: " + nombreSerVivo);
        }
    }
}
