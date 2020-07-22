using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using Vk.TestFramework.Driver;

namespace Vk.TestFramework.PageObjects
{
    public class BasePage
    {
        //protected Logger logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

        protected WebDriver driver;

        protected DriverWaiters driverWaiters;

        protected Actions driverActions;

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
            driverWaiters = new DriverWaiters();
            driverActions = new Actions(driver.Current);
        }
    }
}
