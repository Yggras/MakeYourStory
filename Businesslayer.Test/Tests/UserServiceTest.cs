using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace Businesslayer.Test.Tests
{
    [TestClass]
    public class UserServiceTest
    {
        private readonly IKernel _kernel;

        public UserServiceTest()
        {
            _kernel = Ninjection.CreateKernel();
        }

    }
}
