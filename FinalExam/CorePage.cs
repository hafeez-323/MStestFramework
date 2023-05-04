using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    public class CorePage
    {
        public static IWebDriver driver;
            public static void  SeleniumInit()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
        }
    }
}
