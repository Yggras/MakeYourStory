using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DbRepository;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Ninject;
using Ninject.Modules;

namespace BusinessLayer
{
    public class Ninjection : NinjectModule
    {
        public override void Load()
        {
            Bind<IStoryService>().To<StoryService>();
            Bind<IDbRepo>().To<DbRepo>();
        }

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }
    }
}
