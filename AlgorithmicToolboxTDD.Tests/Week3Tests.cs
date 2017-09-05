using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using AlgorithmicToolbox;

namespace AlgorithmicToolboxTDD.Tests
{
    [TestFixture]
    public class Week3Tests
    {
        [Test]
        public void GetChangeTest()
        {
            //Arrange
            Week3 wk3 = new Week3();
            int n = 16;

            //Act
            int result = wk3.GetChange(n);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void GetOptimalValueTest()
        {
            //arraneg
            Week3 wk3 = new Week3();
            int numItems = 3, totCapacity = 50;
            int[,] valueWeights = new int[,] { { 60, 20 }, { 100, 50 }, { 120, 30 } };

            numItems = 1;
            totCapacity = 100;
            valueWeights = new int[,] { { 500, 30 } };
            //act
            decimal result = wk3.GetOptimalValue(numItems, totCapacity, valueWeights);

            //assert
            Assert.AreEqual(result, 180);
        }

        [Test]
        public void MaximizeRevenueAdPlacementTest()
        {
            //arrange
            Week3 wk3 = new Week3();
            int n = 3;
            int[] proffitPerClick = new int[] { 1, 3, -5};
            int[] avgNumClickPerday = new int[] { -2, 4, 1};

            //act
            int result = wk3.MaximizeRevenueAdPlacement(n, proffitPerClick, avgNumClickPerday);

            //assert
            Assert.AreEqual(result, 23);
        }
    }
}
