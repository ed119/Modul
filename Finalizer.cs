using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Modul
{
    [SetUpFixture]
    //класс с таким атрибутом может быть только один!
    public class Finalizer
        //запускается в самом конце, видно по методу
    {
        [TearDown]
        public void RunInTheEndOfAll()
        {
            WebDriverFactory.DismissAll();
        }
    }
}
