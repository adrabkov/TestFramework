using CAD.CD.Search.TestFramework.Driver;
using OpenQA.Selenium;

namespace CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces
{
    public interface ICustomElement
    {
        IWebElement GetElement();
        SearchStrategies GetSearchStrategy();
        WebDriver GetDriver();
        string GetStrategyValue();
        void Refresh();
    }
}
