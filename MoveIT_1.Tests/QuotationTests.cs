using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoveIT_1.Utils;

namespace MoveIT_1.Tests
{
    [TestClass]
    public class QuotationTests
    {
        [TestMethod]
        public void Distance_SmallerThan50Km_GivesCorrectPrice()
        {
            // arrange
            int distance = 49;
            int expected = 1490;

            // act
            var actual = Calculations.GetDistancePrice(distance);

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Distance_BiggerThan50AndSmallerThan100_GivesCorrectPrice()
        {
            // arrange
            var distance = 51;
            var expected = 5408;

            // act
            var actual = Calculations.GetDistancePrice(distance);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Distance_EqualsTo100_GivesCorrectPrice()
        {
            // arrange
            var distance = 100;
            var expected = 10700;

            // act
            var actual = Calculations.GetDistancePrice(distance);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuatationPrice_WithoutExtraStorage_GivesCorrectNumberOfCars()
        {
            // arrange
            var area = 50;
            var extraStorage = 0;
            var expected = 2;

            // act
            var actual = Calculations.GetNumberOfCars(area, extraStorage);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void QuatationPrice_WitExtraStorage_GivesCorrectNumberOfCars()
        {
            // arrange
            var area = 10;
            var extraStorage = 25;
            var expected = 2;

            // act
            var actual = Calculations.GetNumberOfCars(area, extraStorage);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_Correct_QuatationPrice()
        {
            // arrange
            var area = 100;
            var distance = 10;
            var extraStorage = 0;
            var expected = 3300;

            // act
            var actual = Calculations.GetPrice(area, extraStorage, distance);

            // assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
