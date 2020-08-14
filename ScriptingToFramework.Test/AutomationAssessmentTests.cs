using NUnit.Framework;
using System.Threading;
using ScriptingToFramework.Pages;
using Framework.Selenium;

namespace ScriptingToFramework.Test
{
    public class AutomationAssessmentTests
    {   
        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
            Driver.Current.Url = "http://www.way2automation.com/angularjs-protractor/banking/#/login";
        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
        }
        
        [Test, Category("bank")]
        public void FirstCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionOne();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }

        [Test, Category("bank")]
        public void SecondCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionTwo();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }



        [Test, Category("bank")]
        public void ThirdCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionThree();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }

        [Test, Category("bank")]
        public void FourthCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionFour();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }

        [Test, Category("bank")]
        public void FifthCustomer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionFive();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("1500");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            bank.ApplicationLogout();
        }

        [Test, Category("bank")]
        public void Customer_XYZBank_AccountTest()
        {
            var yourName = new NameSelection(Driver.Current);
            Thread.Sleep(2000);
            yourName.GoTo();
            Thread.Sleep(2000);
            yourName.SelectNameOptionOne();
            Thread.Sleep(1000);
            var bank = new xyzBank(Driver.Current);
            bank.DepositMoney();
            Thread.Sleep(1000);
            bank.Amount("31459");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();

            var success = bank.Map.PaymentSuccessful.Text;

            Assert.AreEqual("Deposit Successful", success);

            yourName.Transactions();

            Thread.Sleep(2000);

            bank.DateTime();

            Thread.Sleep(5000);

            var Transact = bank.Map.TransactionDeposited.Text;

            Assert.AreEqual("31459", Transact);

            bank.Back();
            bank.Withdrawl();
            bank.Amount("31459");
            bank.FinaliseDeposit();
            bank.DepositSuccessful();
            var withdrawn = bank.Map.PaymentSuccessful.Text;
            Assert.AreEqual("Transaction successful", withdrawn);
        }
    }
}