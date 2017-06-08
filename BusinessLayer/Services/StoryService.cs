using System;
using System.Linq;
using BusinessLayer.DbRepository;
using BusinessLayer.Interfaces;
using BusinessLayer.Ninjas;
using BusinessLayer.ResponseObject;
using DataLayer.Model;
using Ninject;

namespace BusinessLayer.Services
{
    public class StoryService :Ninja,  IStoryService
    {
        /// <summary>
        /// TEST-METHOD
        /// </summary>
        /// <param name="storyId"></param>
        /// <returns></returns>
        public Story GetStory(int storyId)
        {
            return Repository.Context.Stories.Find(storyId);
        }

        /// <summary>
        /// Adds a line to a given Story
        /// </summary>
        /// <param name="story">Entity of the Story</param>
        /// <param name="line">Content of the Line</param>
        /// <returns>The New Story</returns>
        public ResponseObject<Story> AddLineToStory(Story story, string line)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the Last appended Line to the given Story
        /// </summary>
        /// <param name="story">Entity of the Story</param>
        /// <returns>ResponseObject with Line-data</returns>
        public ResponseObject<Line> GetLastAppendedLine(Story story)
        {
            throw new NotImplementedException();
        }
    }
}
