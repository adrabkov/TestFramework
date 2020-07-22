namespace CAD.CD.Search.TestFramework.PageObjects.PageElements.Interfaces
{
    public interface IWaitableElement
    {
        void WaitElementIsVisible();
        void WaitElementIsNotVisible();
        void WaitElementIsEnabled();
        void WaitElementIsNotEnabled();
    }
}
