using CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace CAD.CD.Search.TestFramework.PageObjects.PageElements.ElementResources
{
    public class ElementValidator : IValidatableElement
    {
        private WebElement webElement;

        public ElementValidator(WebElement webElement)
        {
            this.webElement = webElement;
        }

        public bool IsElementInDOM()
        {
            try
            {
                return webElement.GetElement().Enabled && webElement.GetElement().Displayed;
            }
            catch
            {
                return false;
            }
        }

        public bool IsElementInDomViaJsCss()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)webElement.GetDriver().Current;
            RemoteWebElement foundElement = (RemoteWebElement)js.ExecuteScript($"return document.querySelector(\"{webElement.GetStrategyValue()}\")");
            if (foundElement == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
