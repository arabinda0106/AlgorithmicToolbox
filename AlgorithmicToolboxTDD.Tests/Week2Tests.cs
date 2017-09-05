using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using AlgorithmicToolbox;
using System.Numerics;

namespace AlgorithmicToolboxTDD.Tests
{
    [TestFixture]
    public class Week2Tests
    {
        Week2 wk2;
        
        //[OneTimeSetUp]
        //void TestSetup()
        //{
        //    wk2 = new Week2();
        //}

        //[OneTimeTearDown]
        //void TestTearDown()
        //{
        //    wk2 = null;
        //}

        [Test]
        public void calc_fibTest()
        {
            //Arrange
            int n = 10;
            Week2 wk3 = new Week2();
            //Act
            long result = wk3.calc_fib(n);

            //Assert//
            Assert.AreEqual(result, 120);

        }

        [Test]
        public void getFibonacciLastDigitNaiveTest()
        {
            //Arrange
            long n = 239;
            Week2 wk3 = new Week2();
            //Act
            long result = wk3.getFibonacciLastDigitNaive(n);

            //Assert//
            Assert.AreEqual(result, 120);

        }

        [Test]
        public void greatest_common_divisorTest()
        {
            //Arrange
            //int a = 18, b = 35;
            int a = 14159572, b = 63967072;
            Week2 wk2 = new Week2();

            //Act
            int result = wk2.greatest_common_divisor(a, b);

            //Assert
            Assert.AreEqual(result, 7);
        }

        [Test]
        public void Least_Common_MultipleTest()
        {
            //Arrange
            int a = 14159572, b = 63967072;
            //long a = 2000000000, b = 1999999999;
            //long a = 18, b = 24;
            //long a = 18, b = 35;
            Week2 wk2 = new Week2();

            //Act
            long result = wk2.Least_Common_Multiple(a, b);

            //Assert
            Assert.AreEqual(result, 226436590403296);
        }

        [Test]
        public void Huge_Fibonacci_Number_Modulo_m_Test()
        {
            //Arrange
            long n = 14, m = 3;
            Week2 wk2 = new Week2();

            //Act
            long result = wk2.Huge_Fibonacci_Number_Modulo_m(n, m);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Last_Digit_Of_Sum_Of_Fibonacci_Numbers_Test()
        {
            //Arrange
            long n = 832564823476;

            //n = 1000000;

            Week2 wk2 = new Week2();

            //Act
            long result = wk2.Last_Digit_Of_Sum_Of_Fibonacci_Numbers(n);

            //Assert
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void Last_Digit_Of_Partial_Sum_Of_Fibonacci_Numbers_Test()
        {
            //Arrange
            long m= 10, n = 200;

            Week2 wk2 = new Week2();

            //Act
            long result = wk2.Last_Digit_Of_Partial_Sum_Of_Fibonacci_Numbers(m, n);

            //Assert
            Assert.AreEqual(result, 1);

        }
    }
}
