using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        //AAA of testing
        //Arrange
        //Act
        //Assert
        [TestMethod]
                   //What functionality we are testing _ result we are expecting
        public void SetTitle_ShouldSetCorrectString()
        {
            //Arrange
            //Using ctrl . to bring in using statement to our class library where we define StreamingContent
            StreamingContent newContent = new StreamingContent();
            //Act
            newContent.Title = "Avatar The Last AirBender";
            //Assert
            string expected = "Avatar The Last AirBender";
            string actual = newContent.Title;

            Assert.AreEqual(expected, actual);

        }

        //Practice ones here

        [DataTestMethod]
        //Data Rows act almost as arguments for our tests parameters. 
        //This test will run four times with differnet values
        [DataRow(MaturityRating.G, MaturityRating.G)]
        [DataRow(MaturityRating.NC_17, MaturityRating.NC_17)]
        [DataRow(MaturityRating.PG, MaturityRating.PG)]
        [DataRow(MaturityRating.R, MaturityRating.R)]
        public void SetMaturityRating_ShouldGetCorrectMaturityRating(MaturityRating rating, MaturityRating expectedOutcome)
        {
            //Arrange
            StreamingContent testingContent = new StreamingContent();
            //Act
            testingContent.TypeOfMaturityRating = rating;
            //Assert
            Assert.AreEqual(expectedOutcome, testingContent.TypeOfMaturityRating);
        }
    }
}
