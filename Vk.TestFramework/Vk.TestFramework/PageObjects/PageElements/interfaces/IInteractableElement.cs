namespace CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces
{
    public interface IInteractableElement
    {
        void Click();
        void SendKeys(string text);
        void ClickUsingJS();
        void ScrollTo(int value);
    }
}
