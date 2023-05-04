using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalExam.SauceDemo.CheckOut
{
    public class Checkout : CorePage
    {
        //By FirstName = By.Id("first-name");
        //By LastName = By.Id("last-name");
        By PostalCode = By.CssSelector("#postal-code");
        By Continue = By.CssSelector("#continue");
        By Finish = By.CssSelector("#finish");
        public void CheckOut()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#first-name")).SendKeys("secret");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("last-name")).SendKeys("hh");
            Thread.Sleep(1000);
            driver.FindElement(PostalCode).SendKeys("759900");
            driver.FindElement(Continue).Click();
            driver.FindElement(Finish).Click();


        }
    }
}
