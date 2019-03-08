using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_diary
{
    class diary
    {
        // stock (var's = cells)
        List<float> ratings; // float - liczby zmiennoprzecinkowe


        // actions
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
