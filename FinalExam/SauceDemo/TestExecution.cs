using FinalExam.SauceDemo.AddProduct;
using FinalExam.SauceDemo.CheckOut;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace FinalExam
{
    [TestClass]
    public class TestExecution : CorePage
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        LoginPage Login = new LoginPage();
        AddProduct Add = new AddProduct();
        Checkout CheckoutPage =  new Checkout();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data1.xml", "LoginTCInvalid_001", DataAccessMethod.Sequential)]
        public void LoginTCInvalid_001()
        {
           CorePage.SeleniumInit();
            
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            Login.Login1(user,pass);
            driver.Close();
       
        }
        [TestMethod]
        public void LoginTCValid_002()
        {
            CorePage.SeleniumInit();
            
            Login.Login1("problem_user", "secret_sauce1");
            

            driver.Close();

        }
        [TestMethod]
        public void AddProductTC_001()
        {
            CorePage.SeleniumInit();
            Login.Login1("problem_user", "secret_sauce");
            Add.AddProduct1();
            driver.Close();

        }
        [TestMethod]
        public void CheckOutTC_001()
        {
            CorePage.SeleniumInit();
            Login.Login1("problem_user", "secret_sauce");
            Add.AddProduct1();
            CheckoutPage.CheckOut();
            driver.Close();

        }
        [TestMethod]
        public void LogoutTC_001()
        {
            CorePage.SeleniumInit();
            Login.Login1("problem_user", "secret_sauce");
            driver.FindElement(By.Id("react-burger-menu-btn")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("logout_sidebar_link")).Click();
            driver.Close();

        }

    }
}
