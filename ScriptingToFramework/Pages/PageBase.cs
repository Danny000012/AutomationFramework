using OpenQA.Selenium;

namespace ScriptingToFramework.Pages
{
    public abstract class PageBase
    {
        public readonly HeaderNav HeaderNav;

        public PageBase(IWebDriver driver)
        {
            HeaderNav = new HeaderNav(driver);
        }
    }
}