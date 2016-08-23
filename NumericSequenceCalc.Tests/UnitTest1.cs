using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumericSequenceCalc.Models;
namespace NumericSequenceCalc.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalcType1()
        {
            //arrange
            int calcType = 1;
            int number = 5;
            string expected = "1,2,3,4,5";

            CalculateNumber calcNumber = new CalculateNumber();

            //act
            string actual = calcNumber.CalculateSequence(calcType, number);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestCalcType2()
        {
            //arrange
            int calcType = 2;
            int number = 5;
            string expected = "1,3,5";

            CalculateNumber calcNumber = new CalculateNumber();

            //act
            string actual = calcNumber.CalculateSequence(calcType, number);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestCalcType3()
        {
            //arrange
            int calcType = 3;
            int number = 5;
            string expected = "2,4";

            CalculateNumber calcNumber = new CalculateNumber();

            //act
            string actual = calcNumber.CalculateSequence(calcType, number);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestCalcType4()
        {
            //arrange
            int calcType = 4;
            int number = 15;
            string expected = "1,2,C,4,E,C,7,8,C,E,11,C,13,14,Z";
                                

            CalculateNumber calcNumber = new CalculateNumber();

            //act
            string actual = calcNumber.CalculateSequence(calcType, number);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestCalcType5()
        {
            //arrange
            int calcType = 5;
            int number = 5;
            string expected = "1,1,2,3,5";

            CalculateNumber calcNumber = new CalculateNumber();

            //act
            string actual = calcNumber.CalculateSequence(calcType, number);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
