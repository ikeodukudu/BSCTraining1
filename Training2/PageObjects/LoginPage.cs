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
    class LoginPage 
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login { get; set; }

        public void ClickLogin()
        {
            login.Click();
        }


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement { get; set; }

        public void TypeEmail()
        {
            emailElement.SendKeys("test@test.com");
        }


        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement { get; set; }

        public void TypePassword()
        {
            passwordElement.SendKeys("MyPasswordissecure");
        }


        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin { get; set; }

        public void ClickSignIn()
        {
            signin.Click();
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='login - form']/div[1]")]
        private IWebElement loginErrorMsg { get; set; }

        public bool IsLoginErrorMsgDisplayed()
        {
            try
            {
                return loginErrorMsg.Displayed;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
