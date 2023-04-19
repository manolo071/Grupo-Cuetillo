using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCuetillo
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }

        public Contacto(string nombre, int telefono)
        {            
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
