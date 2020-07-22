using TechTalk.SpecFlow;
using Vk.TestFramework.Driver;
using Vk.TestFramework.PageObjects;
using Vk.TestFramework.Utils;

namespace Vk.TestFramework.StepDefinitions
{
    [Binding]
    public class BaseStepDefenition
    {
        protected LoginPage loginPage;

        protected HomePage homePage;

        protected TestDataGenerator testDataGenerator;

        public BaseStepDefenition(ScenarioContext scenarioContext)
        {
            WebDriver driver = scenarioContext.Get<WebDriver>();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            testDataGenerator = new TestDataGenerator();
        }
    }
}
