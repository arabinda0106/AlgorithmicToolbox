using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmicToolboxTDD.Tests
{
    [TestFixture]
    public class APlusBTests
    {
        [Test]
        public void MainTest()
        {
            //Arrange
            APlusB.Program p = new APlusB.Program();

            //Act
            p.Main(new string[] { "3", "2" });
            //Assert
        }
    }
}
