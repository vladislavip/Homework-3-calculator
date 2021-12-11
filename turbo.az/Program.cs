using System;

namespace turbo.az
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type the number of cars you wish to add");

            int numofcars = Convert.ToInt32(Console.ReadLine());

            Cars[] carlist = new Cars[numofcars];

            for (int i = 0; i < numofcars; i++)
            {

                Cars car1 = new Cars();

                Console.WriteLine("Input  marka");
                car1.marka = Console.ReadLine();
                Console.WriteLine($"marka = {car1.marka}");


                Console.WriteLine("Input model");
                car1.model = Console.ReadLine();
                Console.WriteLine($"marka = {car1.model}");

                Console.WriteLine("Input year");
                car1.year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"year = {car1.marka}");

                Console.WriteLine("Input price");
                car1.price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"marka = {car1.marka}");

                carlist[i] = car1;



            }

            foreach (var Cars in carlist)


            {
                string name = Cars.GetFullName();
                Console.WriteLine(name);


            }





            







        }
    }
}
