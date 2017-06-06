using BusinessLayer;
using BusinessLayer.Interfaces;
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
        public void GetStoryById()
        {
            //var storyService = _kernel.Get<IStoryService>();

            //var mock = new Mock<Story>();
            //mock.Object.Id = 1;
            //mock.Object.StoryContent = "Ein Text";

            //var result = storyService.GetStory(1);

            //Assert.AreEqual(result.StoryContent, mock.Object.StoryContent);
        }
    }
}
