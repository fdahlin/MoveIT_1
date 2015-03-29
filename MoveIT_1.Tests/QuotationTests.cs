using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoveIT_1.Models;
using MoveIT_1.Utils;

namespace MoveIT_1.Tests
{
    [TestClass]
    public class QuotationTests
    {
        private Quotation _quotation;

        [TestInitialize]
        public void Setup()
        {
            _quotation = new Quotation
            {
                DistanceInKm = 0,
                LivingArea = 0,
                EstimatedPrice = 0,

            };
        }

        [TestMethod]
        public void Distance_SmallerThan50Km_GivesCorrectPrice()
        {
            // arrange
            _quotation.DistanceInKm = 49;
            int expected = 1490;

            // act
            var actual = _quotation.GetDistancePrice();

            // assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Distance_BiggerThan50AndSmallerThan100_GivesCorrectPrice()
        {
            // arrange
            _quotation.DistanceInKm = 51;
            var expected = 5408;

            // act
            var actual = _quotation.GetDistancePrice();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Distance_EqualsTo100_GivesCorrectPrice()
        {
            // arrange
            _quotation.DistanceInKm = 100;
            var expected = 10700;

            // act
            var actual = _quotation.GetDistancePrice();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuatationPrice_WithoutExtraStorage_GivesCorrectNumberOfCars()
        {
            // arrange
            _quotation.LivingArea = 50;
            _quotation.ExtraStorageArea = 0;
            var expected = 2;

            // act
            var actual = _quotation.GetNumberOfCars();

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void QuatationPrice_WitExtraStorage_GivesCorrectNumberOfCars()
        {
            // arrange
            _quotation.LivingArea = 10;
            _quotation.ExtraStorageArea = 25;
            var expected = 2;

            // act
            var actual = _quotation.GetNumberOfCars();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Get_Correct_QuatationPrice()
        {
            // arrange
            _quotation.LivingArea = 100;
            _quotation.DistanceInKm = 10;
            _quotation.ExtraStorageArea = 0;
            var expected = 3300;

            // act
            var actual = _quotation.GetPrice();

            // assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
