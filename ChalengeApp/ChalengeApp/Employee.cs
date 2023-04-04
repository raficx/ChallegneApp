using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChalengeApp
{
    internal class Employee
    //Deklaracja parametrów Pracowników
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        //Lista do której trafi historia pkt pracownika
        private List<int> points = new List<int>();
        //Konstruktor tworzy dla każdego użytkownika parametry wewnętrzne w klasie
        public Employee(string name, string surname, int age)
           
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        //Pole - zmienna Result zwraca na zewnątrz liczbę pkt pracownika z klasy
        public int Result
        {
            get
            {
                return this.points.Sum();
            }
        }
        //Metoda - liczy sumę pkt pracownika
        public void AddScore(int score)
        {
            this.points.Add(score);
        }
    }
}
