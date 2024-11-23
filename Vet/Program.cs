/*
cree una aplicativo de veterinaria
clases con propiedades: 
   Mascota: nombre, edad, especie
   Servicio: descripcion, precio
   Boleta: codigo, mascota, servicio1, servicio2, total

Use arreglos estáticos de las clases
Debe tener un menu con estas opciones:
- crear, eliminar, listar Servicios
- crear, eliminar, listar Mascotas
- crear, listar Boletas

Para crear boletas debe seleccionar la Mascota y el Servicio de 
sus respectivos arreglos

Divida entre sus integrantes, el lider consolida y los integrantes uno hace lo de servicios y el otro el de mascotas
Debe tener una rama por integrante, el lider debe tener por lo menos 2 ramas: main y dev. debe trabajar y consolidar en dev
*/
using Veterinaria;


Boleta boleta = new Boleta();
Mascota mascota1 = new Mascota();    
Servicio servicio = new Servicio();


//designar variables//
int respS;

int resp;

int posicion = 0;

Mascota masc = new Mascota();

Boleta boleta = new Boleta();

Servicio serv = new Servicio();

ClaseUtil util = new ClaseUtil();



do
{
    Console.Write("Cuantos datos ingresar: ");
    respS = int.Parse(Console.ReadLine());

} while (respS <= 0);

//Mascota

string[] arregloNombre = new string[respS];

int[] arregloEdad = new int[respS];

string[] arregloEspecie = new string[respS];

//Boleta

int[] arregloCodigo = new int[respS];

string[] arregloMascota = new string[respS];

string[] arregloServicio1 = new string[respS];

string[] arregloServicio2 = new string[respS];

double[] arregloTotal = new double[respS];

//servicio

string[] arregloDescripcion = new string[respS];

double[] aregloPrecio = new double[respS];


do

{

    Console.WriteLine("");

    Console.WriteLine("\n**MENU**");

    Console.WriteLine("OPCION 1 [1]: ");

    Console.WriteLine("OPCION 2 [2]: ");

    Console.WriteLine("OPCION 3 [3]: ");

    Console.WriteLine("FIN [0]: ");

    Console.Write("\n¿Que opcion quieres ingresar?: ");

    resp = int.Parse(Console.ReadLine());







    switch (resp)

    {

        case 1:

            util.Opcion1();

            break;

        case 2:

            util.Opcion2();

            break;

        case 3:

            {

                util.Opcion3();

            }

            break;

        case 4:

            {



            }

            break;



    }



} while (resp != 4);


/*





do
{

    
        case 1: for (int i = 0; i < respuesta; i++)
            
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
                Console.Clear();
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
            Console.Write("\nEl dato es numerico o letra: ");
            string usuario = Console.ReadLine().ToLower();
            
            if(usuario == "letra")
            {
                Console.WriteLine("Ingresa el dato que desees modificar en la boleta: ");
                string CambioBoleta = Console.ReadLine().ToLower();


                foreach (string R in Mascota)
                {
                    if (R == CambioBoleta)
                    {
                        Console.WriteLine("Encontrado con exito.");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara el nombre antiguo ");
                        Console.Write("\nEscriba Nuevo: ");
                        string cambio = Console.ReadLine();
                        for (int i = 0; i < respuesta; i++)
                        {
                            if (Mascota[i] == CambioBoleta)
                            {
                                Mascota[i] = cambio;
                                Console.WriteLine("\nCambio realizado");
                            }
                        }
                    }
                }
                foreach (string R in Nombre)
                {
                    if (R == CambioBoleta)
                    {
                        Console.WriteLine("Encontrado con exito.");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara el nombre antiguo ");
                        Console.Write("\nEscriba Nuevo: ");
                        string cambio = Console.ReadLine();
                        for (int i = 0; i < respuesta; i++)
                        {
                            if (Nombre[i] == CambioBoleta)
                            {
                                Nombre[i] = cambio;
                                Console.WriteLine("\nCambio realizado");
                            }
                        }
                    }
                }

            }
            if (usuario == "numerico") 
            {
                Console.Write("ingresa el numero de deseas cambiar: ");
                int num = int.Parse(Console.ReadLine());
                foreach (int R in Codigo)
                {
                    if (R == num)
                    {
                        Console.WriteLine("Encontrado con exito.");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara el nombre antiguo ");
                        Console.Write("\nEscriba Nuevo: ");
                        int cambioh = int.Parse(Console.ReadLine());
                        for (int i = 0; i < respuesta; i++)
                        {
                            if (Codigo[i] == num)
                            {
                                Codigo[i] = cambioh;
                                Console.WriteLine("\nCambio realizado");
                            }
                        }
                    }
                }
                foreach (int R in Edad)
                {
                    if (R == num)
                    {
                        Console.WriteLine("Encontrado con exito.");
                        Console.WriteLine("*");
                        Console.WriteLine("Se eliminara el nombre antiguo ");
                        Console.Write("\nEscriba Nuevo: ");
                        int cambioh = int.Parse(Console.ReadLine());
                        for (int i = 0; i < respuesta; i++)
                        {
                            if (Edad[i] == num)
                            {
                                Edad[i] = cambioh;
                                Console.WriteLine("\nCambio realizado");
                            }
                        }
                    }
                }



            }
   
            break;
        case 4:

            break;
    }

} while (respuesta != 4);



/*Console.Write("ingresa el numero de deseas cambiar: ");
int num = int.Parse(Console.ReadLine());
foreach (int R in Codigo)
{
    if (R == num)
    {
        Console.Write("Encontrado con exito.");
        Console.Write("*");
        Console.WriteLine("Se eliminara el nombre antiguo , escriba el actual: ");
        string cambio = Console.ReadLine();
        for (int i = 0; i < respuesta; i++)
        {
            if (Codigo[i] == num)
            {
                Codigo[i] = num;
                Console.WriteLine("\nCambio realizado");
            }
        }
    }*/