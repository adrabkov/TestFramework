using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects.PageElements.ElementResources;
using CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces;

namespace CAD.CD.Search.TestFramework.PageObjects.PageElements
{
    public abstract class ElementContext : RootElement, IWaitableElement, IInteractableElement, IValidatableElement
    {
        protected ElementWaiter elementWaiter;

        protected ElementInteracting elementInteracting;

        protected ElementValidator elementValidator;

        public ElementContext(WebDriver driver, SearchStrategies strategy, string strategyValue) : base(driver, strategy, strategyValue) { }

        public void WaitElementIsVisible()
        {
            elementWaiter.WaitElementIsVisible();
        }

        public void WaitElementIsEnabled()
        {
            elementWaiter.WaitElementIsEnabled();
        }

        public void WaitElementIsNotVisible()
        {
            elementWaiter.WaitElementIsNotVisible();
        }

        public void WaitElementIsNotEnabled()
        {
            elementWaiter.WaitElementIsNotEnabled();
        }

        public void Click()
        {
            elementInteracting.Click();
        }

        public void SendKeys(string text)
        {
            elementInteracting.SendKeys(text);
        }

        public void HoverToElement()
        {
            elementInteracting.HoverToElement();
        }

        public void ClickUsingJS()
        {
            elementInteracting.ClickUsingJS();
        }

        public bool IsElementInDOM()
        {
            return elementValidator.IsElementInDOM();
        }

        public void ScrollTo(int scrollValue)
        {
            elementInteracting.ScrollTo(scrollValue);
        }

        public bool IsElementInDomViaJsCss()
        {
            return elementValidator.IsElementInDomViaJsCss();
        }
    }
}
