using System;

namespace Pizzeo;
    class Program
    {
    static void Main()
    {
        Console.WriteLine("Pizzeo v1.\n");
        int diameter1;
        int diameter2;
        decimal tax1;
        decimal tax2;
        double area1;
        double area2;
        double takePizza1;
        double takePizza2;

        Console.Write("Podaj średnicę pierwszej pizzy: ");
        diameter1 = int.Parse(Console.ReadLine());
        Console.Write("Podaj cene pierwszej pizzy    : ");
        tax1 = int.Parse(Console.ReadLine());
        Console.Write("Podaj średnicę drugiej pizzy  : ");
        diameter2 = int.Parse(Console.ReadLine());
        Console.Write("Podaj cenę drugiej pizzy      : ");
        tax2 = int.Parse(Console.ReadLine());
        area1 = PK(diameter1);
        area2 = PK(diameter2);
        takePizza1 = Resi(area1, tax1);
        takePizza2 = Resi(area2, tax2);
        if (takePizza1 > takePizza2)
        {
            Console.WriteLine("\n Pizza 1 jest bardziej opłacalna!");
            Console.WriteLine($"\n Pizza 1 to {takePizza1} cm^2 za 1 zł ");
            Console.WriteLine($"   Pizza 2 to {takePizza2} cm^2 za 1 zł ");
        }
        else if(takePizza1 < takePizza2) 
                {
                Console.WriteLine("\n Pizza 2 jest bardziej opłacalna!");
                Console.WriteLine($"\nPizza 2 to {takePizza2} cm^2 za 1 zł ");
                Console.WriteLine($"Pizza 1 to {takePizza1} cm^2 za 1 zł \n");
                }
        else    
        {
            Console.WriteLine($"Obie pizze kosztują {takePizza1} cm^2 za 1 zł");
        }
        Console.ReadKey();
    }
    static double AC (double r)
    {
    return 3.14159 * r * r;
    }
    static double PK (int diameter)
    {
        return AC(diameter*0.5d);
    }
    static double Resi (double areaPizza1, decimal taxPizza1)
    {
    return (areaPizza1 / (double)taxPizza1);
    }
}


    
