using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Boleta
    {
        public int Codigo {get; set; }    
        public string Mascota2 {get;set;}    
        public string Servicio1 {get; set; }    
        public string Servicio2 {get; set; }    
        public double Total {get; set; }

        public override string ToString()
        {
            return "Codigo: " + Codigo + "Mascota2: " + Mascota2 + "Servicio1: " + Servicio1 + "Servicio1: " + Servicio2 + "total:" + Total;
        }

        public void Bol()
        {
            Console.WriteLine("\n*********DATOS DE BOLETA*********");
            Console.WriteLine("Codigo: ");
            Codigo=int.Parse(Console.ReadLine());
            Console.WriteLine("Mascota ");
            Mascota2 = Console.ReadLine();
            Console.WriteLine("Servicio 1 ");
            Servicio1 = Console.ReadLine();
            Console.WriteLine("Servicio 2 ");
            Servicio2 = Console.ReadLine();
        }

    }

}
