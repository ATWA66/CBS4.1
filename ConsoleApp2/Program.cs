using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово из каталога которое хотите перевести на англ:\n");
            string[] words = { "солнечно", "дождливо", "облачно", "тепло", "холодно", "метелица", "снег", "температура","влажность","заморозки"};
            string[] wordsTranslation = { "sunny", "rainy", "cloudy", "warm", "cold", "blizzard", "snowy", "temprature","wet","freezing"};
            int i = 0;
            for(; i<10; i++)
                Console.Write(words[i] + "; ");
            i = 0;
            Console.WriteLine("");
            string userWord = Console.ReadLine();
            Console.WriteLine("Перевод:");
            while (i < 10)
            {
                if (words[i] == userWord)
                {
                    Console.WriteLine(wordsTranslation[i]);
                    i = 12;
                    break;

                }
                i++;
            }
            if (i != 12)
            {
                Console.WriteLine("Ошибка, такого слова нет");
            }
        }
    }
}
