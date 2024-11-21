
using Vet;

int respuesta=1;
int r2;

Boleta boleta = new Boleta();
Mascota mascota1 = new Mascota();    
Servicio servicio = new Servicio();


//designar variables//


do
{
    Console.Write("Cuantos datos ingresar: ");
    respuesta = int.Parse(Console.ReadLine());

} while (respuesta <= 0);



int[] Codigo = new int[respuesta];
string[] Mascota = new string[respuesta];
string[] Servicio1 = new string[respuesta];
string[] Servicio2 = new string[respuesta];
double[] Total = new double[respuesta];
//////////////////////

string[] Nombre = new string[respuesta];
int[] Edad = new int[respuesta];
string[] Especie = new string[respuesta];
///////////////////////

string[] Descripcion = new string[respuesta];
double[] Precio = new double[respuesta];
int posicion = 0;



do
{
    Console.WriteLine("");
    Console.WriteLine("\n**MENU**");
    Console.WriteLine("CREAR [1]: ");
    Console.WriteLine("MOSTRAR [2]: ");
    Console.WriteLine("LISTAR [3]: ");
    Console.WriteLine("FIN [4]: ");
    Console.Write("\n¿Que opcion quieres ingresar?: ");
    r2 = int.Parse(Console.ReadLine());

    switch (r2)
    {
        case 1: for (int i = 0; i < respuesta; i++)
            {
                Console.WriteLine("\n*********DATOS DE BOLETA*********");
                Console.Write("INGRESA EDAD: ");
                mascota1.Edad = int.Parse(Console.ReadLine());
                Edad[posicion] = mascota1.Edad; 
                Console.Write("INGRESA TU MASCOTA: ");
                boleta.Mascota2 = Console.ReadLine();
                Mascota[posicion] = boleta.Mascota2;
                Console.Write("INGRESA NOMBRE: ");
                mascota1.Nombre = Console.ReadLine();
                Nombre[posicion] = mascota1.Nombre;
                Console.Write("INGRESA ESPECIE: ");
                mascota1.Especie = Console.ReadLine();
                Especie[posicion] = mascota1.Especie;
                Console.Write("INGRESA TU CODIGO: ");
                boleta.Codigo = int.Parse(Console.ReadLine());
                Codigo[posicion] = boleta.Codigo;
                Console.Write("INGRESA TU SERVICIO 1: ");
                boleta.Servicio1 = Console.ReadLine();
                Servicio1[posicion] = boleta.Servicio1;
                Console.Write("INGRESA TU SERVICIO 2: ");
                boleta.Servicio2 = Console.ReadLine();
                Servicio2[posicion] = boleta.Servicio2;
                Console.Write("INGRESA DESCRIPCION 1: ");
                servicio.Descripcion = Console.ReadLine();
                Descripcion[posicion] = servicio.Descripcion; 
                Console.Write("INGRESA DESCRIPCION (numero) 2: ");
                servicio.Precio = double.Parse(Console.ReadLine());
                Precio[posicion] = servicio.Precio;
                Console.Write("INGRESA EL TOTAL: ");
                boleta.Total = double.Parse(Console.ReadLine());
                Total[posicion] = boleta.Total;
                posicion++;
            }

            break;
        case 2:
            for(int i = 0; i<posicion; i++)
            {
                Console.Write("\n\n*DATOS*" + "\nMascota: " + Mascota[i] + "\nNombre: " + Nombre[i] + "\nEspecie: " + Especie[i] +
                    "\nCodigo: " + Codigo[i] + "\nServicio1: " + Servicio1[i] + "\nServicio2: " + Servicio2[i] +
                   
                    " ");
            }
           
            break;
        case 3:
           
            break;
        case 4:

            break;
    }

} while (respuesta != 4);