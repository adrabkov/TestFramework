using CAD.CD.Search.TestFramework.Config;
using CAD.CD.Search.TestFramework.Driver;
using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using NLog;
using CAD.CD.Search.TestFramework.Api;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(3)]
namespace CAD.CD.Search.TestFramework.Hooks
{
    [Binding]
    public sealed class BeforeAfter : ListingApi
    {
        public int ImplicitWaitTimeout => ConfigLoader.LoadJson("testConfig").implicitWaitTimeout;

        //private readonly Logger logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

        string currentEnvironment = ConfigLoader.LoadJson("testConfig")["Current_Environment"];

        public string SearchWebURL => ConfigLoader.LoadJson("testConfig")[currentEnvironment]["Search_Web"]["URL"];

        private readonly ScenarioContext scenarioContext;

        private readonly ListingApi listingApi = new ListingApi();

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
