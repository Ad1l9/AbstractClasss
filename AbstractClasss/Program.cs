using AbstractClasss.Models;
using AbstractClasss.Models;

namespace AbstractClasss
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle car1 = new Car("Volkswagen", "Golf", 200, 160000, 4, false);
            Vehicle bicycle1 = new Bicylce("Honda", "H", 10, 100, "Mountain bike");


            Vehicle[] vehicles = new Vehicle[]
            { car1, bicycle1};
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine();
                v.GetInfo();
            }


            bicycle1.DefineNatureHarmness();
        }
    }
}