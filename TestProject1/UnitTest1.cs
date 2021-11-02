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
        public void WhenPassedEmptyFirstNameShouldReturnCustomException()
        {
            object name = Methods.FirstNameInput("");
            string expected = "First Name Could not be null";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void WhenPassedWrongFirstNameShouldReturnCustomException()
        {
            object name = Methods.FirstNameInput("Tejas12");
            string expected = "Name Entered is Invalid";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void WhenCorrectFirstNamePassedShouldReturnValidation()
        {
            object name = Methods.FirstNameInput("Tejas");
            string expected = "First Name Validated";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void CorrectEmailNameShouldReturnValidation()
        {
            object name = Methods.EmailInput("sonartejas908@gmail.com");
            string expected = "Email Validated";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void CorrectMobNoShouldReturnValidation()
        {
            object name = Methods.MobileNumInput("8668454516");
            string expected = "Mobile Number Validated";
            Assert.AreEqual(name, expected);
        }
        [Test]
        public void CorrectPasswordShouldReturnValidation()
        {
            object name = Methods.PasswordInput("Tejas@123");
            string expected = "Password Validated";
            Assert.AreEqual(name, expected);
        }
    }
}