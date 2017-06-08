using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ResponseObject;
using DataLayer;
using DataLayer.Model;

namespace BusinessLayer.Interfaces
{
    public interface IStoryService
    {
        ResponseObject<Story> AddLineToStory(Story story, string line);
        ResponseObject<Line> GetLastAppendedLine(Story story, string line);
        
    }
}
