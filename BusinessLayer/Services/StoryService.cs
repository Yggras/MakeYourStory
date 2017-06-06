using System;
using System.Linq;
using BusinessLayer.DbRepository;
using BusinessLayer.Interfaces;
using BusinessLayer.Ninjas;
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

        
    }
}
