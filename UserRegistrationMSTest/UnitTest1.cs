using DAY_19_UserRegistration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegistration userRegistration;
        public UnitTest1()
        {
            userRegistration = new UserRegistration();
        }

        #region UC-1
        [TestMethod]
        public void UserFirstName()
        {
            var result = userRegistration.ValidateFirstName("Shantanu");
            Assert.AreEqual(true, result);
        }
        #endregion UC-1

        #region UC-2
        [TestMethod]
        public void UserLastName()
        {
            var result = userRegistration.ValidateLastName("Borkar");
            Assert.AreEqual(true, result);
        }
        #endregion UC-2

        #region UC-3
        [TestMethod]
        public void UserEmail()
        {
            var result = userRegistration.validateEmail("shantanu18@gmail.com");
            Assert.AreEqual(true, result);
        }
        #endregion UC-3

        #region UC-4
        [TestMethod]
        public void UserPhoneNumber()
        {
            var result = userRegistration.validatenumber("91 9234567890");
            Assert.AreEqual(true, result);
        }
        #endregion UC-4

        #region UC-5
        [TestMethod]
        public void UserPassword()
        {
            var result = userRegistration.validatePassword("Qwerty@123");
            Assert.AreEqual(true, result);
        }
        #endregion UC-5
    }
}
