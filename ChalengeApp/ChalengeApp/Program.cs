// 1.Stwórz klasę Employee, w której przechowasz Imię, Nazwisko,
// wiek, oraz punkty pracownika w postaci liczb całkowitych.
//2. Stwórz 3 pracowników i każdemu przypisz po 5 ocen z zakresu 1 do 10.
//3.  Napisz program ,który wyszuka pracownika z najwyższą liczbą ocen ,
// a następnie wyświetli jego dane oraz wynik.

using ChalengeApp;

//ZADANIE DZIEŃ 6
internal class Program
{
    private static void Main(string[] args)
    {
        Employee user1 = new Employee("Michał", "Durkiewicz", 33);
        Employee user2 = new Employee("Ewelina", "Kobińska", 45);
        Employee user3 = new Employee("Marcin", "Robakiewicz", 29);

        List<Employee> users = new List<Employee>()
        {
            user1, user2, user3
        };

        user1.AddScore(9);
        user1.AddScore(9);
        user1.AddScore(3);
        user1.AddScore(5);
        user1.AddScore(6);

        user2.AddScore(3);
        user2.AddScore(10);
        user2.AddScore(3);
        user2.AddScore(2);
        user2.AddScore(7);

        user3.AddScore(10);
        user3.AddScore(4);
        user3.AddScore(4);
        user3.AddScore(5);
        user3.AddScore(6);

        int maxRes = -1;
        Employee userMaxPoint = null;
        foreach (var user in users)
        {
            if (user.Result > maxRes)
                userMaxPoint = user;
        }

        Console.WriteLine($"Pracownik z maksymalną liczbą punktów to:  {userMaxPoint.Name} {userMaxPoint.Surname}. Ma {userMaxPoint.Age} lat.");
        Console.WriteLine($"{userMaxPoint.Name} zdobył liczbę punktów: {userMaxPoint.Result}");
        Console.WriteLine("GRATULACJE!!!");
        Console.WriteLine($"{ user1.Name} zdobył: {user1.Result}");
        Console.WriteLine($"{ user2.Name} zdobył: {user2.Result}");
        Console.WriteLine($"{ user3.Name} zdobył: {user3.Result}");
    }
}