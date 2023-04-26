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
        public string ApellPaterno { get; set; }
        public string ApellMaterno { get; set; }
        public char Genero { get; set; }
        public int Telefono { get; set; }             
        public string Email { get; set; }
        public string Direccion { get; set; }
        public DateTime Nacimiento { get; set; }

        public Contacto(string nombre, string paterno, string materno, char genero, int telefono, string email, string direccion, DateTime nacimiento)
        {            
            Nombre = nombre;
            ApellPaterno = paterno;
            ApellMaterno = materno;
            Genero = genero;
            Telefono = telefono;
            Email = email;
            Direccion = direccion;
            Nacimiento = nacimiento;
        }
    }
}
