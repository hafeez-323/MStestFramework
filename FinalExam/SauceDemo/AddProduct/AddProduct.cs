using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.SauceDemo.AddProduct
{
    public class AddProduct : CorePage
    {
        By AddToCart = By.Id("add-to-cart-sauce-labs-backpack");
        By ShoppingCart = By.Id("shopping_cart_container");
        By Checkout = By.Id("checkout");


        public void AddProduct1()
        {

            driver.FindElement(AddToCart).Click();
            driver.FindElement(ShoppingCart).Click();
            driver.FindElement(Checkout).Click();
            

        }
    }
}
