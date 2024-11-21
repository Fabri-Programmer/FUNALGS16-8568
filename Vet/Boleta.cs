using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet
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


    }
}
