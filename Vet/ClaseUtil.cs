
namespace Veterinaria
{
    internal class ClaseUtil
    {
        Mascota masc1 = new Mascota();

        public void Opcion1()

        {

            int resp1;

            do

            {

                Console.WriteLine("\n**MENU**");

                Console.WriteLine("CREAR [1]: ");

                Console.WriteLine("ELIMINAR [2]: ");

                Console.WriteLine("LISTAR SERVICIOS  [3]: ");

                Console.WriteLine("VOLVER [0]: ");

                Console.Write("\nElegir opcion: ");

                resp1 = int.Parse(Console.ReadLine());

                switch (resp1)

                {

                    case 1:
                        masc1.Masc();

                        break;

                    case 2: 

                        break;

                    case 3: break;

                }

            } while (resp1 < 0);

        }

        public void Opcion2()

        {

            int resp2;

            do

            {

                Console.WriteLine("\n**MENU**");

                Console.WriteLine("CREAR 1 [1]: ");

                Console.WriteLine("ELIMINAR 2 [2]: ");

                Console.WriteLine("LISTAR SERVICIOS 3 [3]: ");

                Console.WriteLine("VOLVER [0]: ");

                Console.Write("\nElegir opcion: ");

                resp2 = int.Parse(Console.ReadLine());

                switch (resp2)

                {

                    case 1: break;

                    case 2: break;

                    case 3: break;

                }

            } while (resp2 < 0);

        }

        public void Opcion3()

        {

            int resp3;

            do

            {

                Console.WriteLine("\n**MENU**");

                Console.WriteLine("CREAR [1]: ");

                Console.WriteLine("LISTAR BOLETAS [2]: ");

                Console.WriteLine("VOLVER [0]: ");

                Console.Write("\nElegir opcion: ");

                resp3 = int.Parse(Console.ReadLine());

                switch (resp3)

                {

                    case 1: break;

                    case 2: break;

                }

            } while (resp3 < 0);

        }
    }
}
