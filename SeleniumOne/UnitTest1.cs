using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumOne.Pages;

namespace SeleniumOne
{
    public class Tests : DriverHelper
    {

        //public IWebDriver 
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https:demowf.aspnetawesome.com");
            CustomControl.EnterText(Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Apple");
            CustomControl.Click(Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Cauliflower']")));
            CustomControl.SelectByText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Broccoli");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();

        }

        [Test]
        public void LoginTest()
        {
            //Driver.Navigate().GoToUrl("http://eaapp.somee.com");
            //HomePage homePage = new HomePage();
            //LoginPage loginPage = new LoginPage();
            //homePage.ClickLogin();
            //loginPage.EnterUserNameAndPassword("admin", "password");
            //loginPage.LoginClick();
            //Assert.That(homePage.IsLogOffExist, Is.True, "No Logg Off Button");
            Assert.Pass();
        }
 
    }
}