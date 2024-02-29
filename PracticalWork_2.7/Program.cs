using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            string fullName = "Иванов Иван Иванович";
            string email = "ivanov@mail.ru";
            float programmingScores = 3.5f;
            float mathScores = 4.5f;
            float physicsScores = 4.3f;
            int age = 18;

            Console.WriteLine("Задание 1");
            Console.WriteLine();
            Console.WriteLine($"Имя: {fullName} \nВозраст: {age} \n" +
                $"Почта: {email} \nБаллы по программированию: {programmingScores} \nБаллы по математике: {mathScores} \n" +
                $"Баллы по физике: {physicsScores}");

            Console.WriteLine();
            Console.WriteLine("Для вывода задания 2. Нажмите любую клавишу.");
            Console.ReadKey();

            // Задание 2
            float amountOfPoints;
            float averageScore;

            amountOfPoints = programmingScores + mathScores + physicsScores;
            averageScore = amountOfPoints / mathScores;

            Console.WriteLine("Задание 2");
            Console.WriteLine();
            Console.WriteLine($"Сумма баллов: {amountOfPoints} \nСредний балл: {averageScore:#.##}");
            Console.ReadLine();
        }
    }
}
