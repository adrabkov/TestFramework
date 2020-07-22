using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Vk.TestFramework.Config;
using Vk.TestFramework.Driver;

namespace Vk.TestFramework.Hooks
{
    public sealed class BeforeAfter
    {
        public int ImplicitWaitTimeout => ConfigLoader.LoadJson("testConfig").implicitWaitTimeout;

        //private readonly Logger logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

        string currentEnvironment = ConfigLoader.LoadJson("testConfig")["Current_Environment"];

        public string SearchWebURL => ConfigLoader.LoadJson("testConfig")[currentEnvironment]["Search_Web"]["URL"];

        private readonly ScenarioContext scenarioContext;

        //private readonly ListingApi listingApi = new ListingApi();

        public BeforeAfter(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            scenarioContext.Set(new WebDriver());
            scenarioContext.Get<WebDriver>().Current.Manage().Window.Maximize();
            scenarioContext.Get<WebDriver>().Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ImplicitWaitTimeout);
            scenarioContext.Get<WebDriver>().Current.Navigate().GoToUrl(SearchWebURL);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            scenarioContext.Get<WebDriver>().Current.Quit();
        }

        //[AfterScenario]
        //public void OnError()
        //{
        //    if (scenarioContext.TestError != null)
        //    {
        //        logger.Error($"message:{scenarioContext.TestError.Message}, stack trace: {scenarioContext.TestError.StackTrace}");
        //    }
        //}
    }
}
