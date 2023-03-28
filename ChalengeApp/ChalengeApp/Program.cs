int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
var c0 = 0;
int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;
int c6 = 0;
int c7 = 0;
int c8 = 0;
int c9 = 0;
foreach (char item in letters)
{
    if (item == '0')
    {
        c0++;
    }
    else if (item == '1')
    {
        c1++;
    }
    else if (item == '2')
    {
        c2++;
    }
    else if (item == '3')
    {
        c3++;
    }
    else if (item == '4')
    {
        c4++;
    }
    else if (item == '5')
    {
        c5++;
    }
    else if (item == '6')
    {
        c6++;
    }
    else if (item == '7')
    {
        c7++;
    }
    else if (item == '8')
    {
        c8++;
    }
    else
    {
        c9++;
    }
}
Console.WriteLine(" Cyfra 0 w zadanej liczbie występuje " +  c0, "razy");
Console.WriteLine(" Cyfra 1 w zadanej liczbie występuje " +  c1, "razy");
Console.WriteLine(" Cyfra 2 w zadanej liczbie występuje " +  c2, "razy");
Console.WriteLine(" Cyfra 3 w zadanej liczbie występuje " +  c3, "razy");
Console.WriteLine(" Cyfra 4 w zadanej liczbie występuje " +  c4, "razy");
Console.WriteLine(" Cyfra 5 w zadanej liczbie występuje " +  c5, "razy");
Console.WriteLine(" Cyfra 6 w zadanej liczbie występuje " +  c6, "razy");
Console.WriteLine(" Cyfra 7 w zadanej liczbie występuje " +  c7, "razy");
Console.WriteLine(" Cyfra 8 w zadanej liczbie występuje " +  c8, "razy");
Console.WriteLine(" Cyfra 9 w zadanej liczbie występuje " +  c9, "razy");
