using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_diary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); // Diary() - constructor domyślny (tworzy obiekt)
            diary.AddRating(5);
            diary.AddRating(8.5f); // f żeby kompilator wiedział, że przekazujemy float
            diary.AddRating(4.7f);

            float avg = diary.CalculateAverage();
            float max = diary.GiveMaxRating();
            float min = diary.GiveMinRating();

            for (; ;)
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 do 10");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating); // float.TryParse - sprawdza czy parsowana wartość to liczba
                // out rating jeśli sparsuje to wysyłą do rating ???
                if (rating == 11)
                {
                    break;
                }
                if (result)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba");
                    }
                    
                }
            }
            Console.WriteLine("Średnia Twoich ocen to : " + diary.CalculateAverage());
            Console.WriteLine("Maksymalna ocena to : " + diary.GiveMaxRating());
            Console.WriteLine("Minimalna ocena to : " + diary.GiveMinRating());
            Console.ReadKey();

            Diary diary2 = new Diary();
        }
    }
}
