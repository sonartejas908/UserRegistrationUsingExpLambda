using NUnit.Framework;
using System;
using UserRegistrationUsingExpLambda;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectFirstNameShouldReturnHappy()
        {
            object name = Methods.FirstNameInput("Tejas");
            string expected = "Happy";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void WrongFirstNameShouldReturnSad()
        {
            object name = Methods.FirstNameInput("Tejas12");
            string expected = "Sad";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void CorrectLastNameShouldReturnHappy()
        {
            object name = Methods.FirstNameInput("Sonar");
            string expected = "Happy";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void CorrectEmailNameShouldReturnHappy()
        {
            object name = Methods.EmailInput("sonartejas908@gmail.com");
            string expected = "Happy";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void CorrectMobNoShouldReturnHappy()
        {
            object name = Methods.MobileNumInput("8668454516");
            string expected = "Happy";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void CorrectPasswordShouldReturnHappy()
        {
            object name = Methods.PasswordInput("Tejas@123");
            string expected = "Happy";
            Assert.AreEqual(name, expected);
        }
    }
}