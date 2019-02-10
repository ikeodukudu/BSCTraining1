using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using Training2.PageObjects;
using Training2.Utilities;

namespace Training2.StepDefinitions
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registrationPage;

        public RegistrationsSteps()
        {
            registrationPage = new RegistrationPage();
        }

        [When(@"I click on register link")]
        public void WhenIClickOnRegisterLink()
        {
            registrationPage.ClickRegister();
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I enter lastname")]
        public void WhenIEnterLastName()
        {
            registrationPage.EnterLastName("Odukudu");
        }
        
        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registrationPage.EnterEmailAddress(email);
            //takes email parameter as an argument
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registrationPage.EnterMobileNumber("07345678989");
        }

        [When(@"I input password")]
        public void WhenIInputPassword()
        {
            registrationPage.EnterPassword("Myveryeducatedmother");
        }

        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registrationPage.EnterConfirmPassword("Myveryeducatedmother");
        }
        
        [When(@"I click on signUp")]
        public void WhenIClickOnSignUp()
        {
            registrationPage.ClickSignUp();
        }
        
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Thread.Sleep(30000);

            //using NUnit assertions
            Assert.AreEqual(registrationPage.SuccessMessageIsDisplayed(), true);
            Assert.IsTrue(registrationPage.SuccessMessageIsDisplayed(), "Error Message: Registration failed");

            //rewriting above code in fluent assertion
            registrationPage.SuccessMessageIsDisplayed().Should().BeTrue("Error Message: Registration failed");
        }
        
        [Then(@"the registration page is not displayed")]
        public void ThenTheRegistrationPageIsNotDisplayed()
        {
            registrationPage.RegisterPageIsDisplayed();
        }

        [Then(@"the registration page should be displayed")]
        public void ThenTheRegistrationPageShouldBeDisplayed()
        {
            registrationPage.RegisterPageIsDisplayed();
        }

        [When(@"I input password ""(.*)""")]
        public void WhenIInputPassword(string passwordEntered)
        {
            registrationPage.EnterPassword(passwordEntered);
        }

        [When(@"I confirm password ""(.*)""")]
        public void WhenIConfirmPassword(string confirmPasswordEntered)
        {
            registrationPage.EnterConfirmPassword(confirmPasswordEntered); ;
        }

        [Then(@"the password is too short error is displayed")]
        public void ThenThePasswordIsTooShortErrorIsDisplayed()
        {
            registrationPage.PasswordTooShortMessageIsDisplayed().Should().BeTrue("Password is not too short");
        }

        [Then(@"the error message ""(.*)"" is displayed for ""(.*)""")]
        public void ThenTheErrorMessageIsDisplayedFor(string message, string test)
        {
            if (test == "PasswordTooShort")
                registrationPage.GetTextForPasswordTooShort().Should().Be(message);
            else if (test == "Invalidemail")
                registrationPage.GetTextForInvalidEMail().Should().Be(message);
            else if (test == "MobileTooShort")
                registrationPage.GetTextForMobileTooShort().Should().Be(message);

        }




    }
}
