using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Veterinaria
{
    public class Servicio
    {
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public override string ToString()
        {
            return "Descripcion: " + Descripcion + "Precio: " + Precio;
        }
        public void Masc()
        {
            Console.WriteLine("Nombre: ");
            Descripcion = Console.ReadLine();
            Console.WriteLine("Edad: ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Especie: ");
            Especie = Console.ReadLine();
        }
    }
}
