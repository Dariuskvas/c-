using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja2
{
    [TestClass]
    public class FizzBuzzTests1
    {
        [TestMethod]
        public void FizzBuzz_numberDivideFrom5_ReturnsBuzz()
        {
            //Arrange
                                                         //jei statine klase nerteikia instance
                                                         //FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var resultatas = FizzBuzz.GetOutput(5);

            //Assert
            Assert.AreEqual("Buzz", resultatas);
        }
    }
    
    
    
    [TestClass]
    public class FizzBuzzTests2
    {
        [TestMethod]
        public void FizzBuzz_numberDivideFrom3_ReturnsFizz()
        {
            //Arrange
                                                            //jei statine klase nerteikia instance
                                                          //FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var resultatas = FizzBuzz.GetOutput(3);

            //Assert
            Assert.AreEqual("Fizz", resultatas);
        }
    }


    [TestClass]
    public class FizzBuzzTests3
    {
        [TestMethod]
        public void FizzBuzz_numberDivideFrom3and5_ReturnsFizzBuzz()
        {
            //Arrange
                                                                                                    //jei statine klase nerteikia instance
                                                                                                   //FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var resultatas = FizzBuzz.GetOutput(15);

            //Assert
            Assert.AreEqual("FizzBuzz", resultatas);
        }
    }

    [TestClass]
    public class FizzBuzzTests4
    {
        [TestMethod]
        public void FizzBuzz_numberDivideFrom3and5_ReturnsFizzBuzz()
        {
            //Arrange
                                                                                                 //jei statine klase nerteikia instance
                                                                                                //FizzBuzz fizzBuzz = new FizzBuzz();
            //Act
            var resultatas = FizzBuzz.GetOutput(11);
            string xanswer = "11";

            //Assert
            Assert.AreEqual(xanswer, resultatas);
        }
    }
    

}
