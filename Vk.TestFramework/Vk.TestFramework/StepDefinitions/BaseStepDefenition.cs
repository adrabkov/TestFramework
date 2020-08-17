using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects;
using CAD.CD.Search.TestFramework.Utils;
using TechTalk.SpecFlow;
using Vk.TestFramework.PageObjects.Pages;

namespace CAD.CD.Search.TestFramework.StepDefinitions
{
    [Binding]
    public class BaseStepDefenition
    {
        protected LoginPage loginPage;

        protected FeedPage startPage;

        protected TestDataGenerator testDataGenerator;

        public BaseStepDefenition(ScenarioContext scenarioContext)
        {
            WebDriver driver = scenarioContext.Get<WebDriver>();
            loginPage = new LoginPage(driver);
            startPage = new FeedPage(driver);
            testDataGenerator = new TestDataGenerator();
        }
    }
}
