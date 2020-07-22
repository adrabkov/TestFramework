using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects.PageElements;
using OpenQA.Selenium;
using System.Threading;

namespace CAD.CD.Search.TestFramework.PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage(WebDriver driver) : base(driver) { }

        private WebElement userNameInput => new WebElement(driver, SearchStrategies.Id, "index_email");

        private WebElement passwordInput => new WebElement(driver, SearchStrategies.Id, "index_pass");

        private WebElement signInButton => new WebElement(driver, SearchStrategies.Id, "index_login_button");

        public void TypeInUsernameInput(string userName)
        {
            userNameInput.SendKeys(userName);
            //logger.Info("User has entered login in user input at login page");
        }

        public void TypeInPasswordInput(string pass)
        {
            passwordInput.SendKeys(pass);
            
            //logger.Info("User has entered password in password input at login page");
        }

        public void ClickSignInButton()
        {
            signInButton.Click();
            Thread.Sleep(5000);
            //logger.Info("User has clicked sign in button at login page");
        }
    }
}
