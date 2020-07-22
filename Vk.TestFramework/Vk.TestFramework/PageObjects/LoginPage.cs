using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Vk.TestFramework.Driver;

namespace Vk.TestFramework.PageObjects
{
    public class LoginPage:BasePage
    {
        public LoginPage(WebDriver driver) : base(driver) { }

        public void LogIn(string login)
        {
            driver.Current.FindElement(By.Id("index_email")).SendKeys(login);
            Thread.Sleep(5000);
        }


    }
}
