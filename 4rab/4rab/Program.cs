using System;
using System.IO;
using System.Linq;

namespace _4rab
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\input.txt");
            StreamReader sr1 = new StreamReader(@"C:\dictionary.txt");
            string text1 = sr.ReadToEnd();
            string text2 = sr1.ReadToEnd();
            string[] words = SplitWords(text1).Intersect(SplitWords(text2), StringComparer.CurrentCultureIgnoreCase).ToArray();
            Console.WriteLine("Количество совпадающих слов: {0}", words.Length);
            Console.ReadKey();
        }
        static string[] SplitWords(string input)
        {
            return input.Split(new[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
