﻿/*
 * project = PageFactoryUsingFacebook
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Sample.page;
using Selenium_Sample.Post;
using SeleniumExtras.PageObjects;

namespace Selenium_Sample.DoActions
{
    public class ActionsDone
    {
        public static Login_page login;

        public static void AssertAfterLauching(IWebDriver driver)
            {
                string title1 = "Facebook – log in or sign up";
                string title = driver.Title;
                Assert.AreEqual(title1, title);
            }
        public static void LoginToFacebook(IWebDriver driver)
        {
            login = new Login_page(driver);
            
            login.email.SendKeys("ucs17139@rmd.ac.in");
            System.Threading.Thread.Sleep(2000);

            login.password.SendKeys("123456789ABCD");
            System.Threading.Thread.Sleep(2000);

            login.loginButton.Click();
            System.Threading.Thread.Sleep(2000);

        }
    }
}