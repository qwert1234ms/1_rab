using System;

namespace _2rab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов для идентификартора пользователя");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите идентификатор пользователя");
            string x = Console.ReadLine();
            if (x.Length < N)
            {
                Console.WriteLine("Вы должны ввести идентификатор длиной не менее " + N + " символов");
            }
            else if (x.Length > N)
            {
                Console.WriteLine("Вы должны ввести идентификатор длиной не более " + N + " символов");
            }
            else
            {
                Console.WriteLine("Идентификатор пользователя: " + x);
            }

            int M = 10;

            Console.WriteLine("Количество символов пароля: " + M);

            int Q = N % 5;
            Console.WriteLine(Q);

            string abc = "qQwWeErRtTyYuUiIoOpPaAsSdDfFgGhHjJkKlIzZxXcCvVbBnNmM"; //набор символов
            string result = "";

            Random rnd = new Random();
            int lng = abc.Length;
            for (int i = 0; i < M; i++)
                result += abc[rnd.Next(lng)];
            Console.WriteLine(result);
        }
    }
}