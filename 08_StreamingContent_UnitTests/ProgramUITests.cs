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
    }
}
