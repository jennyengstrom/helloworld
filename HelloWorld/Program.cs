using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv ett tal med decimaler här:");
            string read = Console.ReadLine();
            double decimalNbr = double.Parse(read);

            Console.WriteLine("Hur många decimaler vill du ha?:");
            read = Console.ReadLine();
            int paces = int.Parse(read);

            var roundedNbr = Math.Round(decimalNbr, paces);
            Console.WriteLine($"Avrundat: {roundedNbr}");

            Console.Read();
        }
    }
}
