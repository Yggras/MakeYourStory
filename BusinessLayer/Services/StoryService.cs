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
        
        public Story GetStory(int storyId)
        {
            return Repository.Context.Stories.Find(storyId);
        }


        public ResponseObject<Story> AddLineToStory(Story story)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<Line> GetLastAppendedLine(Story story)
        {
            throw new NotImplementedException();
        }
    }
}
