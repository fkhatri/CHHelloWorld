using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace API.Test
{
    [TestClass]
    public class ApplicationServiceTest
    {

        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void DisplayHelloWorld_Should_Return_Message()
        {
            var mock = new Mock<IRepository>();
            mock.Setup(x => x.Display()).Returns("Test1");
            IApplicationService obj= new ApplicationService(mock.Object);
            var result = obj.DisplayHelloWorld();

            Assert.IsTrue(result.Length>0);
        }
        [TestMethod]
        public void WriteHelloWorld_Message_Should_Not_Be_Empty()
        {
            // Arrange
            var repository = new ConsoleRepository();
            IApplicationService obj = new ApplicationService(repository);
            
            //Act
            repository.Write("Test1");
            var result = obj.DisplayHelloWorld();

            //ASSERT

            Assert.AreEqual("Console Application: Test1",result);
        }
    }
}
