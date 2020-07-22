using CAD.CD.Search.TestFramework.Driver;
using CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces;

namespace CAD.CD.Search.TestFramework.PageObjects.PageElements.ElementResources
{
    public class ElementWaiter : IWaitableElement
    {
        private DriverWaiters driverWaiters;

        private WebElement webElement;

        public ElementWaiter(WebElement webElement)
        {
            this.webElement = webElement;
            driverWaiters = new DriverWaiters();
        }

        public void WaitElementIsVisible()
        {
            webElement.GetDriver().Wait.Until(driverWaiters.ElementIsVisible(webElement.GetElement()));
        }

        public void WaitElementIsEnabled()
        {
            webElement.GetDriver().Wait.Until(driverWaiters.ElementIsEnabled(webElement.GetElement()));
        }

        public void WaitElementIsNotVisible()
        {
            webElement.GetDriver().Wait.Until(driverWaiters.ElementIsNotVisible(webElement.GetElement()));
        }

        public void WaitElementIsNotEnabled()
        {
            webElement.GetDriver().Wait.Until(driverWaiters.ElementIsNotEnabled(webElement.GetElement()));
        }
    }
}
