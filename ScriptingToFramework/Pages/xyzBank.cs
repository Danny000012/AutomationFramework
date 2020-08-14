using System;
using OpenQA.Selenium;

namespace ScriptingToFramework.Pages
{
    public class xyzBank : PageBase
    {
        public readonly xyzBankMap Map;

        public xyzBank(IWebDriver driver) : base(driver)
        {
            Map = new xyzBankMap(driver);
        }

        public void DepositMoney()
        {
            Map.MoneyToDeposit.Click();
        }

        public void Amount(string amount)
        {
            Map.ExactAmount.SendKeys(amount);
        }

        public void FinaliseDeposit()
        {
            Map.FinalisePayment.Click();
        }

        public void DepositSuccessful()
        {
            Map.PaymentSuccessful.ToString();
        }

        public void ApplicationLogout()
        {
            Map.Logout.Click();
        }

        public void DateTime()
        {
            Map.Date();
        }

        public void Back()
        {
            Map.GoBack.Click();
        }

        public void Withdrawl()
        {
            Map.ClickWithDrawl.Click();
        }
    }

    public class xyzBankMap
    {
       IWebDriver _driver;

       public xyzBankMap(IWebDriver driver)
       {
           _driver = driver;
       }
       
       public IWebElement MoneyToDeposit => _driver.FindElement(By.XPath("//button[contains(text(),'Deposit')]"));

       public IWebElement ExactAmount => _driver.FindElement(By.XPath("//input[@placeholder='amount']"));

       public IWebElement FinalisePayment => _driver.FindElement(By.XPath("//button[@class='btn btn-default']"));

       public IWebElement PaymentSuccessful => _driver.FindElement(By.XPath("//span[@class='error ng-binding']"));

       public IWebElement TransactionDeposited => _driver.FindElement(By.XPath("//td[contains(text(),'31459')]"));

       public IWebElement Logout => _driver.FindElement(By.XPath("//button[contains(text(),'Logout')]"));

       public IWebElement GoBack => _driver.FindElement(By.XPath("//button[contains(text(),'Back')]"));

       public IWebElement ClickWithDrawl => _driver.FindElement(By.XPath("//button[contains(text(),'Withdrawl')]"));

        public void Date()
        {
           var query = _driver.FindElement(By.XPath("//input[@id='start']"));
           DateTime x = DateTime.Today;
           query.SendKeys(x.ToString());
           query.Click();
        }
    }
}