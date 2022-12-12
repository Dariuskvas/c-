using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzzTests
{
    [TestClass]
    public class ZIzzBuzzTests15
    {

        [TestMethod]
        public void GetOutput_numberDivideFrom5_Buzz()
        {
            //Arrange
            FizzBuzz fizzBuzz = new FizzBuzz();
            int x = 5;

            //Act
            var result = fizzBuzz.GetOutput(x);

            //Assert
            Assert.AreEqual(result, "Buzz");

        }
    }

}


