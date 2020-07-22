using CAD.CD.Search.TestFramework.Driver;
using OpenQA.Selenium;

namespace CAD.CD.Search.TestFramework.PageObjects.PageElements
{
    public abstract class RootElement
    {
        protected SearchStrategies strategy;

        protected string strategyValue;

        protected WebDriver driver;

        protected IWebElement webElement;

        public RootElement(WebDriver driver, SearchStrategies strategy, string strategyValue)
        {
            this.driver = driver;
            this.strategy = strategy;
            this.strategyValue = strategyValue;
        }

        protected void initElement()
        {
            switch (strategy)
            {
                case SearchStrategies.ByXPath:
                    webElement = driver.Current.FindElement(By.XPath(strategyValue));
                    break;
                case SearchStrategies.Id:
                    webElement = driver.Current.FindElement(By.Id(strategyValue));
                    break;
                case SearchStrategies.ClassName:
                    webElement = driver.Current.FindElement(By.ClassName(strategyValue));
                    break;
                case SearchStrategies.CssSelector:
                    webElement = driver.Current.FindElement(By.CssSelector(strategyValue));
                    break;
                case SearchStrategies.LinkText:
                    webElement = driver.Current.FindElement(By.LinkText(strategyValue));
                    break;
                case SearchStrategies.Name:
                    webElement = driver.Current.FindElement(By.Name(strategyValue));
                    break;
                case SearchStrategies.PartialLinkText:
                    webElement = driver.Current.FindElement(By.PartialLinkText(strategyValue));
                    break;
                case SearchStrategies.TagName:
                    webElement = driver.Current.FindElement(By.TagName(strategyValue));
                    break;
            }
        }
    }
}
