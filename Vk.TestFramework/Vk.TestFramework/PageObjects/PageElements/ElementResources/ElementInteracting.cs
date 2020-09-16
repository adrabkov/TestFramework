using System;
using CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace CAD.CD.Search.TestFramework.PageObjects.PageElements.ElementResources
{
    public class ElementInteracting : IInteractableElement
    {
        private WebElement webElement;

        private Actions actions;

        public ElementInteracting(WebElement webElement)
        {
            this.webElement = webElement;
            actions = new Actions(webElement.GetDriver().Current);
        }

        public void Click()
        {
            webElement.GetElement().Click();
        }

        public void ClickUsingJS()
        {
            ((IJavaScriptExecutor)webElement.GetDriver().Current).ExecuteScript("arguments[0].click();", webElement.GetElement());
        }

        public void ScrollTo(int scrollValue)
        {
            actions
                .MoveToElement(webElement.GetElement())
                .MoveByOffset(Convert.ToInt32((webElement.GetElement().Size.Width * (0.01 * scrollValue)) - (webElement.GetElement().Size.Width / 2)),
                Convert.ToInt32(webElement.GetElement().Size.Height * 0.5))
                .Click()
                .Build()
                .Perform();
        }

        public void SendKeys(string text)
        {
            webElement.GetElement().SendKeys(text);
        }

        public void HoverToElement()
        {
            actions.MoveToElement(webElement.GetElement());
        }

    }
}
