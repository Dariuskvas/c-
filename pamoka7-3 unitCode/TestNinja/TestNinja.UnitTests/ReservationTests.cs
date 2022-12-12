using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //---------------------------------------------------------------------------------------------------------------
    [TestClass]
    public class ReservationTests1
    {//CanBeCancelledBy_Scenario_expectBehaviour
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange - paruosti Objekta kuri norime testuoti
            Reservation reservation = new Reservation();
            var user = new User();
            user.IsAdmin = true;

            //Act - issikvieciam funkcija, kurias testuojam
            var result = reservation.CanBeCancelledBy(user);

            //Assert - kokio tikimasi rezultato
            Assert.IsTrue(result);
        }
    }


    //---------------------------------------------------------------------------------------------------------------
    [TestClass]
    public class ReservationTests2
    {//CanBeCancelledBy_Scenario_expectBehaviour
        [TestMethod]
        public void CanBeCancelledBy_MadeBy_ReturnsTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();
            var user = new User();
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }
    }


    //---------------------------------------------------------------------------------------------------------------
    [TestClass]
    public class ReservationTests3
    {//CanBeCancelledBy_Scenario_expectBehaviour
        [TestMethod]
        public void CanBeCancelledBy_MadeByAndIsAdmin_ReturnsFaulse()
        {
            //Arrange
            Reservation reservation = new Reservation(); //sukuriu instance i Reservation Class
            User user1 = new User();                     //sukuriu instance i User, bet nepriskiriu reiksmes

            //Act
            var result = reservation.CanBeCancelledBy(user1);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
