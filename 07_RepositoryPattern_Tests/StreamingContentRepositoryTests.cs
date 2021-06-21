using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //Arrange
            StreamingContent newContent = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
            //Act
            bool addResult = repository.AddContentToDirectory(newContent);
            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent testContent = new StreamingContent("Mr.Right", "Hitman falls in love. You know how that goes", 9001, "Romantic Comedy", MaturityRating.R);
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(testContent);
            //Act
            List<StreamingContent> contents = repo.GetContents();
            bool directoryHasContent = contents.Contains(testContent);
            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContent _content;
        private StreamingContentRepository _repo;
        [TestInitialize]
        public void Arrange()
        {
            _content = new StreamingContent("Mr.Right", "Hitman falls in love. You know how that goes", 9001, "Romantic Comedy", MaturityRating.R);
            _repo = new StreamingContentRepository();
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //Handled in Test Initialize
            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Mr.Right");
            //Assert
            Assert.AreEqual(_content, searchResult);

        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange 
            StreamingContent updatedInfo = new StreamingContent("Mr.Right", "Hitman falls in love. Neat", 5, "Romantic Comedy", MaturityRating.R);
            //Act
            bool updateResult = _repo.UpdateExistingContent("Mr.Right", updatedInfo);
            Assert.IsTrue(updateResult);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange!
            StreamingContent foundContent = _repo.GetContentByTitle("Mr.Right");
            //Act!
            bool removeResult = _repo.DeleteExistingContent(foundContent);
            //Assert!
            Assert.IsTrue(removeResult);
        }
    }
}
