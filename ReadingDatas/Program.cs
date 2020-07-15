using System;
using System.Dynamic;
using System.Globalization;

namespace ReadingDatas {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insert your Full Name:");
            string name = Console.ReadLine();
            Console.WriteLine("How many bedrooms do you have in your house?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price of a product");
            float price = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter your last name, years and height");
            string[] vet = Console.ReadLine().Split(' ');
            int years = int.Parse(vet[1]);
            float height = float.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(name);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(years);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
