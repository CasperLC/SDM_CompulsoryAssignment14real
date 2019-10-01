using System.Collections.Generic;
using MovieRatingLibrary.Entities;

namespace MovieRatingLibrary
{
    public class MovieRating: IMovieRating
    {
        public List<MovieReview> AllMovieReviews { get; set; }

        public MovieRating()
        {
            var data = new TestData();
            AllMovieReviews = data.MovieReviews;
        }

        public List<MovieReview> AllReviewsFromReviewer(int reviewerId)
        {
            List<MovieReview> reviewList = new List<MovieReview>();

            foreach (var review in AllMovieReviews)
            {
                if (review.Reviewer == reviewerId)
                {
                    reviewList.Add(review);
                }
            }

            return reviewList;
        }

        public double AverageRatingFromReviewer(int reviewerId)
        {
            throw new System.NotImplementedException();
        }

        public int TimesReviewerHasGivenGrade(int reviewerId, int grade)
        {
            throw new System.NotImplementedException();
        }

        public int HowManyReviewsOfMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public int AverageRatingMovieReceived(int movieId)
        {
            throw new System.NotImplementedException();
        }

        public int TimesMovieReceivedGrade(int movieId, int grade)
        {
            throw new System.NotImplementedException();
        }

        public int MovieWithMostTopRates()
        {
            throw new System.NotImplementedException();
        }

        public int ReviewerWithMostReviews()
        {
            throw new System.NotImplementedException();
        }

        public List<int> TopNofMovies(int grade)
        {
            throw new System.NotImplementedException();
        }

        public List<int> MoviesReviewedByN(int reviewerId)
        {
            throw new System.NotImplementedException();
        }

        public List<int> ReviewersThatReviewedMovie(int movieId)
        {
            throw new System.NotImplementedException();
        }
    }
}