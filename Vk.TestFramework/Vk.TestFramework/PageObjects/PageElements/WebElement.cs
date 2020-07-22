using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects.PageElements.ElementResources;
using CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces;
using OpenQA.Selenium;

namespace CAD.CD.Search.TestFramework.PageObjects.PageElements
{
    public class WebElement : ElementContext, ICustomElement
    {
        public WebElement(WebDriver driver, SearchStrategies strategy, string strategyValue) : base(driver, strategy, strategyValue)
        {
            elementWaiter = new ElementWaiter(this);
            elementValidator = new ElementValidator(this);
            elementInteracting = new ElementInteracting(this);
        }

        public WebDriver GetDriver()
        {
            return driver;
        }

        public IWebElement GetElement()
        {
            if (webElement == null)
            {
                initElement();
            }
            return webElement;
        }

        public SearchStrategies GetSearchStrategy()
        {
            return strategy;
        }

        public string GetStrategyValue()
        {
            return strategyValue;
        }

        public void Refresh()
        {
            initElement();
        }
    }
}
