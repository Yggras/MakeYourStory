﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;

namespace BusinessLayer.Interfaces
{
    public interface IStoryService
    {
        Story GetStory(int storyId);
    }
}
