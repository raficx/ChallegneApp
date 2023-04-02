using System.ComponentModel.Design;

Console.WriteLine("program weryfikuje sumę kątów w trójkącie.");
Console.WriteLine("podaj pierwszy kąt trójkąta");
int angle1 = int.Parse(Console.ReadLine ());
if (angle1 < 0 || angle1 > 178)
{
    Console.WriteLine("nieprawidłowa wartość kąta");
}
else 
{
    Console.WriteLine("podaj drugi kąt trójkąta");
    int angle2 = int.Parse(Console.ReadLine());
    if (angle2 < 0 || angle2 > 178)
     {
     Console.WriteLine("nieprawidłowa wartość kąta");
     }
     else
     {
      int angle3 = 180 - angle1 - angle2;
      Console.WriteLine($"trzeci kąt trójkąta wynosi: {angle3}");
     }
}
    
