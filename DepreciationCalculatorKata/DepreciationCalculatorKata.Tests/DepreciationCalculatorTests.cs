using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationCalculatorKata.Tests
{
    [TestFixture]
    public class DepreciationCalculatorTests
    {
        [TestCase(100,0,1,100)]
        [TestCase(200, 0, 5, 40)]
        [TestCase(2500, 500, 2, 1000)]
        public void CalculateDepreciation_GivenAssetValue100AndUsefulYears1_ShouldReturn100(int assetValue, int salvage, int usefulYears, int expected)
        {
            //Arrange
            DepreciationCalculator sut = new DepreciationCalculator();

            //act
            var actual = sut.CalculateDepreciation(assetValue, salvage, usefulYears);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public void learningTest_GivenAssetValue2500AndUsefulYears2AndSalvage500_ShouldReturn40()
        //{
        //    //Arrange
        //    var assetValue = 2500;
        //    var salvage = 500;
        //    var usefulYears = 2;
        //    var expected = 1000;
        //    DepreciationCalculator sut = new DepreciationCalculator();

        //    //act
        //    var actual = sut.CalculateDepreciation(assetValue, salvage, usefulYears);

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
