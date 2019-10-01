using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MovieRatingLibrary;
using MovieRatingLibrary.Entities;

namespace MovieReview_Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestIfNoReviews()
        {
            IMovieRating mr = new MovieRating();
            List<MovieReview> list = mr.AllReviewsFromReviewer(-1);
            Assert.AreEqual(0,list.Count);
        }

    }
}
