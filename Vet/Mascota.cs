using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascota
    {
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public string Especie {get; set;}

        public override string ToString()
        {
            return "Nombre: " + Nombre + "Edad: " + Edad + "Especie: " + Especie;
        }
        public void Masc()
        {
            Console.WriteLine("Nombre: " );
            Nombre=Console.ReadLine();
            Console.WriteLine("Edad: ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Especie: ");
            Especie = Console.ReadLine();
        }
    }
    
}
