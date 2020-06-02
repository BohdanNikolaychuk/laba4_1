using System;

namespace ConsoleApp2
{
   public class Program
    {
        static void Main(string[] args)
        {
            var p = new Student();

            Console.WriteLine("Введіть інформацію про себе");
            Console.Write($"Name: \t ");
            p.Name = Console.ReadLine();
            Console.Write($"Lastname: \t ");
            p.LastName = Console.ReadLine();
            Console.Write($"Group: \t \t ");
            p.Group = Console.ReadLine();
            Console.Write($"Year: \t ");
            p.Year =int.Parse(Console.ReadLine());
            Console.Write($"Adress: \t ");
            p.Adress = Console.ReadLine();
            Console.Write($"Passport: \t ");
            p.Passport = Console.ReadLine();
            Console.Write($"Age: \t ");
            p.Age =int.Parse(Console.ReadLine());
            Console.Write($"Telephone: \t ");
            p.Telephone = int.Parse(Console.ReadLine());
            Console.Write($"Rating: \t ");
            p.Rating =int.Parse(Console.ReadLine());
            StudentsRating(p.Rating);
        }
        public static int StudentsRating(int R)
        {
            if (R >= 90)
            {
                Console.WriteLine("Вітаємо відмінника");
                return 1;
            }

            else if (R >= 75 && R < 90)
            {
                Console.WriteLine("Можна вчитися краще");
                return 2;
            }
            else
            {
                Console.WriteLine("більше уваги приділяти навчанню");
                return 3;
            }
            
        }
    }
}
