using System;
using practica_abstracta.clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_abstracta.clases
{
    abstract class animales
    {
        public void respirar()
        {
            Console.WriteLine("soy capaz de respirar");
        }

        public abstract void getNombre();

    }
}
