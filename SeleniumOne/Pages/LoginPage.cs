using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumOne.Pages
{
    class LoginPage:DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        public void ClickLogin() => lnkLogin.Click();

        public void EnterUserNameAndPassword(string username, string password)
        {
            Driver.FindElement(By.Id("UserName")).SendKeys(username);
            Driver.FindElement(By.Id("Password")).SendKeys(password);
            
        }

        public void LoginClick()
        {
            Driver.FindElement(By.XPath("//input[@value='Log in']")).Click();
        }



    }
}
