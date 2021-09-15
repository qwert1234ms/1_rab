using System;
using System.Linq;

namespace pole_chudes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string a = Console.ReadLine();
            Console.Clear();

            string word = String.Join("", a.Select(v => '*')), wordsym = a;
            do
            {
                Console.Write($"Загаданное слово: {word}\nИгрок 1 введи букву: ");
                char letter;
                if (char.TryParse(Console.ReadLine(), out letter))
                {
                    if (a.Contains(letter))
                        word = String.Join("", word.Select((v, i) => wordsym[i] == letter ? letter : word[i]));
                    else
                        Console.WriteLine("Такой буквы нет...");
                }
                else
                    Console.WriteLine("Можно ввести только один символ!");
                Console.Write($"Загаданное слово: {word}\nИгрок 2 введи букву: ");
                if (char.TryParse(Console.ReadLine(), out letter))
                {
                    if (a.Contains(letter))
                        word = String.Join("", word.Select((v, i) => wordsym[i] == letter ? letter : word[i]));
                    else
                        Console.WriteLine("Такой буквы нет...");
                }
                else
                    Console.WriteLine("Можно ввести только один символ!");
                Console.Write($"Загаданное слово: {word}\nИгрок 3 введи букву: ");
                if (char.TryParse(Console.ReadLine(), out letter))
                {
                    if (a.Contains(letter))
                        word = String.Join("", word.Select((v, i) => wordsym[i] == letter ? letter : word[i]));
                    else
                        Console.WriteLine("Такой буквы нет...");
                }
                else
                    Console.WriteLine("Можно ввести только один символ!");
            }
            while (word.Where(v => v == '*').Count() != 0);
            Console.WriteLine("Поздравляю! Ты угадал слово!");
            Console.ReadKey();
        }
    }
}