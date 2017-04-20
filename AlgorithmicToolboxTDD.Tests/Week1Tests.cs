using AlgorithmicToolbox;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolboxTDD.Tests
{
    [TestFixture]
    class Week1Tests
    {
        Week1 w1;

        [OneTimeSetUp]
        public void TestSetup()
        {
            //Arrange
            Week1 w1 = new Week1();
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            w1 = null;
        }
        //[TestCase]
        //public void FirstProblemTest()
        //{
        //    //Act

        //    //Assert//

        //}


        [Test]
        public void FirstProblemTest()
        {
            //Act


            //Assert//

        }

    }
}
