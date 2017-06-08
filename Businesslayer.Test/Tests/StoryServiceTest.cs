using System;
using System.Linq;
using BusinessLayer;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using DataLayer.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;

namespace Businesslayer.Test.Tests
{
    [TestClass]
    public class StoryServiceTest
    {
        private readonly IKernel _kernel;

        public StoryServiceTest()
        {
            _kernel = Ninjection.CreateKernel();
        }

        

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddLineToStory_NullReference_BothArgs()
        {
            IStoryService service = new StoryService();

            service.AddLineToStory(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddLineToStory_NullReference_Args1()
        {
            var mock = new Mock<Story>();

            IStoryService service = new StoryService();

            service.AddLineToStory(mock.Object, null);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddLineToStory_NullReference_Args2()
        {
            IStoryService service = new StoryService();

            service.AddLineToStory(null, "TestLine");
        }

        [TestMethod]
        public void AddLineToStory_AcceptTest()
        {
            var mock = new Mock<Story>();
            
            IStoryService service = new StoryService();

            var data = service.AddLineToStory(mock.Object, "TestLine");

            var line = mock.Object.Lines.First(x => x.Content == "TestLine");

            Assert.AreEqual(line, data.Data.Lines.First(x => x.Content == "TestLine"));
        }
    }
}
