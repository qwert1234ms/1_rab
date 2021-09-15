using System;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Z;
            int P = 0; int L = 0;
            string word, EX;
            bool Выход = false;
            Console.WriteLine("Камень - Ножницы - Бумага!");

            while (!Выход)
            {
                Console.WriteLine("Выберите (Камень / Ножницы / Бумага) ? Для выхода наберите(выход).");
                word = Console.ReadLine();
                word = word.ToLower().Trim();
                if (word == "Выход" || P == 20 || L == 20) goto FINISH;

                Random random = new Random();
                Z = random.Next(3);
                switch (Z)
                {
                    case 0: Console.WriteLine("ПК выбрал — Камень!"); break;
                    case 1: Console.WriteLine("ПК выбрал — Ножницы!"); break;
                    default: Console.WriteLine("ПК выбрал — Бумага!"); break;
                }
                if (word == "Камень")
                {
                    Console.WriteLine("Ваш выбор — " + word);
                    if (Z == 0) { Console.WriteLine("Ничья"); }
                    else if (Z == 1) { Console.WriteLine("Вы победили"); P++; }
                    else { Console.WriteLine("Вы проиграли"); L++; }
                }
                else if (word == "Ножницы")
                {
                    Console.WriteLine("Ваш выбор — " + word);
                    if (Z == 1) { Console.WriteLine("Ничья"); }
                    else if (Z == 2) { Console.WriteLine("Вы победили"); P++; }
                    else { Console.WriteLine("Вы проиграли"); L++; }
                }
                else if (word == "Бумага")
                {
                    Console.WriteLine("Ваш выбор — " + word);
                    if (Z == 2) { Console.WriteLine("Ничья"); }
                    else if (Z == 0) { Console.WriteLine("Вы победили"); P++; }
                    else { Console.WriteLine("Вы проиграли"); L++; }
                }
                else
                {
                    Console.WriteLine("Ваш выбор — неизвестен программе.Хотите выйти(да/нет) ?");
                    EX = Console.ReadLine();
                    EX = EX.ToLower().Trim();
                    if (EX == "Да") Выход = true;
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }

        FINISH:
            Console.WriteLine("Вы победили " + P + " раз!");
            Console.WriteLine("Вы проиграли " + L + " раз!");
            Console.WriteLine("Осуществляется выход, нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}