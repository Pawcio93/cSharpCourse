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

            Diary diary2 = new Diary();
            diary2.AddRating(8);

            Diary diary3 = new Diary();
            diary3.AddRating(8);

            
            int liczba = 2;
        }
    }
}
