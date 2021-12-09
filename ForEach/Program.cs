using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
/*            var numbers = new List<int>()
            {
                Con var me ahorro algunos caracteres al declarar una lista
                var siempre dentro de metodos
            }

            List<int> numbers = new()
            {
                Se agrego en las ultimas versiones de C#
            }
*/
            List<int> numbers = new List<int>()
            {
                23,3,5,10,22,12
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            List<People> students = new List<People>()
            {
                new People(){ Name = "Vicente", Country = "México" },
                new People(){ Name = "Zoe", Country = "Francia" },
                new People(){ Name = "Brais", Country = "España"}
            };

            Show(students);

            students.RemoveAt(0);

            Show(students);
        }

        public static void Show(List<People> students)
        {
            foreach (var person in students)
            {
                Console.WriteLine($"Nombre: {person.Name}, País: {person.Country}");
            }
        }
    }

    public class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
