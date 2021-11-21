using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumOne.Pages
{
    class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));


       // IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogout => Driver.FindElement(By.LinkText("Log off"));
       public void ClickLogin() => lnkLogin.Click();

        public bool IsLogoutExist() => lnkLogout.Displayed;

    }
}