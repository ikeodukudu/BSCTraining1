using System;
using TechTalk.SpecFlow;
using Training2.PageObjects;
using Training2.Utilities;

namespace Training2.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginPage;
        //RegistrationPage registrationPage;

        public LoginSteps()
        {
            loginPage = new LoginPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("https://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on login link")]
        public void WhenIClickOnLoginLink()
        {
            loginPage.ClickLogin();
        }
        
        [When(@"I enter username")]
        public void WhenIEnterUsername()
        {
            loginPage.TypeEmail();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            loginPage.TypePassword();
            //registrationPage.EnterPassword("Myveryeducatedmother");
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginPage.ClickSignIn();
        }
        
        [Then(@"I am not logged in to the site")]
        public void ThenIAmNotLoggedInToTheSite()
        {
            loginPage.IsLoginErrorMsgDisplayed();
        }
    }
}
