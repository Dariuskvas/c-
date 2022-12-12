using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pamoka7_4;
using System;

namespace Pamoka7_4Tests
{
    [TestClass]
    public class RotateStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            RotateString rotateString = new RotateString();
     

            string[] arrayforTest = { "123456789", "987654321"};
            string[] arrayforTestRotate = { "987654321", "123456789" };

            //Act
            //string rezult = rotateString.rotateString();

            //Assert
            //Assert.AreEqual(arrayforTestRotate, rezult);

        }
    }
}
