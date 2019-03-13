using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_diary
{
    class Diary
    {

        public Diary()
            {
            ratings = new List<float>();
            }               

        // stock (var's = cells)
        List<float> ratings;
       // actions
       /// <summary>
       /// Add rating between 1 - 10
       /// </summary>
       /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Calculate ratings average
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Return highest rating
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();
        }
        /// <summary>
        /// Return lowest rating
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
