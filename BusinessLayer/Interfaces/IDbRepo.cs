﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer.Interfaces
{
    public interface IDbRepo
    {
        StoryContext Context { get; }
    }
}
