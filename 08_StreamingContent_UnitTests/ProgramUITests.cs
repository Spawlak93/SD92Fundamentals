using _08_StreamingContent_UI;
using _08_StreamingContent_UI.Consoles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_StreamingContent_UnitTests
{
    [TestClass]
    public class ProgramUITests
    {
        [TestMethod]
        //What we are testing    //What we are expecting
        public void GetAll_OutputShouldContainListOfContent()
        {
            //Arrange
            List<string> commandList = new List<string> { "1", "6" };
            MockConsole console = new MockConsole(commandList);

            ProgramUI ui = new ProgramUI(console);
            //Act
            ui.Run();

            Console.WriteLine(console.Output);
            //Assert

            Assert.IsTrue(console.Output.Contains("Magical Kid causes trouble for aunt and uncle"));
        }

        [TestMethod]
        public void AddToRepo_ShouldSeeItemInList()
        {
            //Arrange
            string customDesc = "This is a description";

            List<string> commandList = new List<string> { "3", "Title", customDesc, "7", "SciFi", "2", "1", "6" };
            MockConsole banana = new MockConsole(commandList);
            ProgramUI ui = new ProgramUI(banana);

            //Act
            ui.Run();

            Console.WriteLine(banana.Output);

            //Assert
            Assert.IsTrue(banana.Output.Contains(customDesc));
        }

        [TestMethod]
        public void RemoveFromRepo_ShouldNotSeeItemInList()
        {
            //Arrange
            var commandList = new List<string> { "4", "1","1",  "6" };
            var deleteConsole = new MockConsole(commandList);
            var ui = new ProgramUI(deleteConsole);
            //Act
            ui.Run();
            Console.WriteLine(deleteConsole.Output);
            //Assert
            
            Assert.IsFalse(deleteConsole.Output.Contains("Magical Kid causes trouble for aunt and uncle"));
        }

    }

}
