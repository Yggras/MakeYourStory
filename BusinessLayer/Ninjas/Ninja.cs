using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataLayer;
using Ninject;

namespace BusinessLayer.Ninjas
{
    public abstract class Ninja
    {
        
        [Inject]
        public IDbRepo Repository { get; set; }

        
    }
}
