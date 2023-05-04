using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FinalExam
{
    [TestClass]
    public class LoginPage : CorePage
    {
         public By usernameTxt = By.CssSelector("#user-name");
         public By passwordTxt = By.CssSelector("#password");
        public By loginBtn = By.CssSelector("#login-button");

        
        public void Login1(string user, string pass)
        {
            
            driver.FindElement(usernameTxt).SendKeys(user);
            driver.FindElement(passwordTxt).SendKeys(pass);
            driver.FindElement(loginBtn).Click();
            

        }
    }
}
