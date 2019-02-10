using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training2.Utilities;

namespace Training2.PageObjects
{
    class RegistrationPage
    {
        //inspect your elements in the Browser

        //create page object element

        //also create method of action for each objects/elements

        //In step definition: Call the method

        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        public void ClickRegister()
        {
            register.Click();
        }


        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }
        
        public void EnterFirstName()
        {
            firstName.SendKeys("Ike");
        }


        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        public void EnterLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }


        [FindsBy(How = How.Id, Using = "mobile")]
        private IWebElement mobileNumber { get; set; }
        
        public void EnterMobileNumber(string mobile)
        {
            mobileNumber.SendKeys(mobile);
        }


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        public void EnterEmailAddress(string email)
        {
            emailAddress.SendKeys(email);
        }


        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password { get; set; }

        public void EnterPassword(string passwordText)
        {
            password.SendKeys(passwordText);
        }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmPassword { get; set; }

        public void EnterConfirmPassword(string confirmPasswordText)
        {
            confirmPassword.SendKeys(confirmPasswordText);
        }


        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        public void ClickSignUp()
        {
            signUp.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-success")]
        private IWebElement successMessage { get; set; }

        public bool SuccessMessageIsDisplayed()
        { //one method
            try
            {
                return successMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [FindsBy(How = How.CssSelector, Using = "#focus > div.col-md-12 > section > h2")]
        private IWebElement registerPage { get; set; }

        public bool RegisterPageIsDisplayed()
        { //one method
            try
            {
                return registerPage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='signup-form']/div[5]/label[2]")]
        private IWebElement passwordTooShortMessage { get; set; }

        public bool PasswordTooShortMessageIsDisplayed()
        { //one method
            try
            {
                return passwordTooShortMessage.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string GetTextForPasswordTooShort()
        {
            string text = passwordTooShortMessage.Text;
            return text;
            //or return passwordTooShortMessage.Text;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='signup-form']/div[2]/label[2]")]
        private IWebElement InvalidEmailMessage { get; set; }

        public string GetTextForInvalidEMail()
        {
            /*string text = InvalidEmailMessage.Text;
            return text;*/
            return InvalidEmailMessage.Text;
        }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div:nth-child(4) > label.error")]
        private IWebElement MobileTooShortMessage { get; set; }

        public string GetTextForMobileTooShort()
        {
            /*string text = InvalidEmailMessage.Text;
            return text;*/
            return MobileTooShortMessage.Text;
        }
    }
    /*
     * 
     * //kle method
                try
                {
                    return successMessage.Displayed;
                }
                catch (Exception ex)
                {
                    return false;
                }
     * 
     */
}

