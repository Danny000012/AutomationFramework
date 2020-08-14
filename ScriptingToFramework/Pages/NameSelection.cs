using System;
using OpenQA.Selenium;

namespace ScriptingToFramework.Pages
{
    public class NameSelection : PageBase
    {
        public readonly NameSelectionMap Map;

        public NameSelection(IWebDriver driver) : base(driver)
        {
            Map = new NameSelectionMap(driver);   
        }

        public NameSelection GoTo()
        {
            HeaderNav.GoToCustomerNameSelection();
            return this;
        }

        public IWebElement SelectYourName(string yourName)
        {
            if (yourName.Contains(" "))
            {
                yourName = yourName.Replace(" ", "+");
            }

            return Map.SelectName(yourName);
        }

        public void SelectNameOptionOne()
        {
            Map.NameOptions.Click();
            Map.FirstName.Click();
            Map.LoginButton.Click();
        }

        public void SelectNameOptionTwo()
        {
            Map.NameOptions.Click();
            Map.SecondName.Click();
            Map.LoginButton.Click();
        }
        
        public void SelectNameOptionThree()
        {
            Map.NameOptions.Click();
            Map.ThirdName.Click();
            Map.LoginButton.Click();
        }

        public void SelectNameOptionFour()
        {
            Map.NameOptions.Click();
            Map.ForthName.Click();
            Map.LoginButton.Click();
        }

        public void SelectNameOptionFive()
        {
            Map.NameOptions.Click();
            Map.FifthName.Click();
            Map.LoginButton.Click();
        }

        public void Transactions()
        {
            Map.Transaction.Click();
        }
    }

    public class NameSelectionMap
    {
        IWebDriver _driver;
        public NameSelectionMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SelectName(string name) => _driver.FindElement(By.XPath($"//option[contains(text(),'{name}')]"));
        public IWebElement NameOptions => _driver.FindElement(By.Id("userSelect"));
        public IWebElement FirstName => _driver.FindElement(By.XPath("//option[contains(text(),'Hermoine Granger')]"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//button[@class='btn btn-default']"));
        public IWebElement SecondName => _driver.FindElement(By.XPath("//option[contains(text(),'Harry Potter')]"));
        public IWebElement ThirdName => _driver.FindElement(By.XPath("//option[contains(text(),'Ron Weasly')]"));
        public IWebElement ForthName => _driver.FindElement(By.XPath("//option[contains(text(),'Albus Dumbledore')]"));
        public IWebElement FifthName => _driver.FindElement(By.XPath("//option[contains(text(),'Neville Longbottom')]"));
        public IWebElement Transaction => _driver.FindElement(By.XPath("//button[contains(text(),'Transactions')]"));
        
    }
}