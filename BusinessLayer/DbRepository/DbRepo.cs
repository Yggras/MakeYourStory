using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using DataLayer;

namespace BusinessLayer.DbRepository
{
    public class DbRepo : IDbRepo
    {

        public DbRepo()
        {
            Context = GetContext();
        }

        private StoryContext GetContext(string conString)
        {
            throw new NotImplementedException();
        }

        private StoryContext GetContext()
        {
            return new StoryContext();
        }


        public StoryContext Context { get; private set; }
    }
}
