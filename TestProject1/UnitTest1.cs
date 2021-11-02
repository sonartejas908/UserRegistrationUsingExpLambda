using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
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
        //Using Expression Lambda
        [Test]
        public void CorrectNameShouldReturnValidationLambdaExp()
        {

            Methods methods = new Methods();
            string result = methods.LambdaExpressionFirstnameCheck();
            string expected = "FirstName is Validated";
            Assert.AreEqual(expected, result);

        }
        [Test]
        public void CorrectMobileShouldReturnValidationLambdaExp()
        {

            Methods methods = new Methods();
            string result = methods.LambdaExpressionMobileCheck();
            string expected = "Mobile Number is Validated";
            Assert.AreEqual(expected, result);

        }
        [Test]
        public void CorrectEmailShouldReturnValidationLambdaExp()
        {

            Methods methods = new Methods();
            string result = methods.LambdaExpressionEmailCheck();
            string expected = "Email is Validated";
            Assert.AreEqual(expected, result);

        }
        [Test]
        public void CorrectPasswordShouldReturnValidationLambdaExp()
        {

            Methods methods = new Methods();
            string result = methods.LambdaExpressionPasswordCheck();
            string expected = "Password is Validated";
            Assert.AreEqual(expected, result);

        }
    }
}