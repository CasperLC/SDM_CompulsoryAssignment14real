using System.Collections.Generic;

namespace MovieRatingLibrary
{
    public class MovieRating: IMovieRating
    {
        public List<object> AllReviewsFromReviewer(int reviewerId)
        {
            throw new System.NotImplementedException();
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