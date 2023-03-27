using System.ComponentModel.Design;
string imie = "Piotr";
string sex = "Mężczyzna";
bool pl = false;
var wiek = 16;
//sprawdzenie płci
if (sex == "Kobieta")
{
    pl = true;
    //sprawdzenie wieku
    if (wiek < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        if (imie == "Ewa" && wiek == 33)
        {
            Console.WriteLine("Ewa, lat 33");
        }
        else
        {
            Console.WriteLine("Kobieta, powyżej 29 lat");
        }
    }

}
else
{
    pl = false;
    if (wiek < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else
    {
        Console.WriteLine("Mężczyzna, powyżej 17 lat");
    }
}

