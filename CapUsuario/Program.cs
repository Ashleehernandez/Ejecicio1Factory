using CapaNegocio;
namespace CapUsuario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elija el animal que desea crear ");

            Console.WriteLine("[1] Cuadrupedo [2] ave [3]pez ");

            int opcion =Convert.ToInt32( Console.ReadLine()!); 

            Animal animal = Factory.GetAnimal(opcion);

            animal.TipoAnimal();
            Console.ReadKey();
            Console.Clear();

        }
    }
}
