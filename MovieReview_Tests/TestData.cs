using System;
using System.Collections.Generic;
using MovieRatingLibrary.Entities;

namespace MovieReview_Tests
{
    public class TestData
    {
        public static List<MovieReview> MovieReviews { get; set; }


        public static void InitializeTestData()
        {
            List<MovieReview> temp = new List<MovieReview>();

            MovieReview review_1 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 1,
                MovieId = 1,
                ReviewerId = 1
            };
            temp.Add(review_1);

            MovieReview review_2 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 2,
                MovieId = 2,
                ReviewerId = 1
            };
            temp.Add(review_2);

            MovieReview review_3 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 3,
                MovieId = 3,
                ReviewerId = 1
            };
            temp.Add(review_3);

            MovieReview review_4 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 4,
                MovieId = 4,
                ReviewerId = 1
            };
            temp.Add(review_4);

            MovieReview review_5 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                MovieId = 5,
                ReviewerId = 1
            };
            temp.Add(review_5);

            MovieReview review_6 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                MovieId = 1,
                ReviewerId = 2
            };
            temp.Add(review_6);

            MovieReview review_7 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 4,
                MovieId = 2,
                ReviewerId = 2
            };
            temp.Add(review_7);

            MovieReview review_8 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 3,
                MovieId = 3,
                ReviewerId = 2
            };
            temp.Add(review_8);

            MovieReview review_9 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 2,
                MovieId = 4,
                ReviewerId = 2
            };
            temp.Add(review_9);

            MovieReview review_10 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 1,
                MovieId = 5,
                ReviewerId = 2
            };
            temp.Add(review_10);

            MovieReview review_11 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 3,
                MovieId = 1,
                ReviewerId = 3
            };
            temp.Add(review_11);

            MovieReview review_12 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 2,
                MovieId = 2,
                ReviewerId = 3
            };
            temp.Add(review_12);

            MovieReview review_13 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 1,
                MovieId = 3,
                ReviewerId = 3
            };
            temp.Add(review_13);

            MovieReview review_14 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 4,
                MovieId = 4,
                ReviewerId = 3
            };
            temp.Add(review_14);

            MovieReview review_15 = new MovieReview()
            {
                Date = DateTime.Parse("01/10/2019"),
                Grade = 5,
                MovieId = 5,
                ReviewerId = 3
            };
            temp.Add(review_15);



            MovieReviews = temp;
        }


    }
}