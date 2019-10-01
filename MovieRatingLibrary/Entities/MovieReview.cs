using System;

namespace MovieRatingLibrary.Entities
{
    public class MovieReview
    {
        public int ReviewerId { get; set; }
        public int MovieId { get; set; }
        public int Grade { get; set; }
        public DateTime Date { get; set; }
    }
}