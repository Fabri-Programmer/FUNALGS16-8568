using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet
{
    public class Servicio
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public override string ToString()
        {
            return "Descripcion: " + Descripcion + "Precio: " + Precio;
        }
    }
}
