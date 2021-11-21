using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumOne.Pages
{
    class LoginPage:DriverHelper
    {

        IWebElement UsernameEnter => Driver.FindElement(By.Id("UserName"));
        IWebElement passwordEnter => Driver.FindElement(By.Id("Password"));
        IWebElement LonginBtn => Driver.FindElement(By.XPath("//input[@value='Log in']"));
      

      public void EnterUsernameAndPassword(string username, string password)
        {
            UsernameEnter.SendKeys(username);
            passwordEnter.SendKeys(password);
        }

        public void ClickLoginBtn()
        {
            LonginBtn.Click();
        }



    }
}
