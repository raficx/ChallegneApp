using ChalengeApp;

namespace Klasy;

class Program
{
    static void Main()
    {
        Latarka latarka = new Latarka();
        Console.WriteLine($"Czy latarka jest włączona? {latarka.Wlaczona}");
        Console.WriteLine($"Jakiego koloru jest latarka? {latarka.Kolor}");
        Console.WriteLine();

        latarka.Wlacz();
        latarka.Kolor = "czerwony";

        Console.WriteLine($"Czy latarka jest włączona? {latarka.Wlaczona}");
        Console.WriteLine($"Jakiego koloru jest latarka? {latarka.Kolor}");
        Console.WriteLine();

        latarka.Wylacz();
        latarka.Kolor = "niebieski";

        Console.WriteLine($"Czy latarka jest włączona? {latarka.Wlaczona}");
        Console.WriteLine($"Jakiego koloru jest latarka? {latarka.Kolor}");
        Console.WriteLine();
    }
}



