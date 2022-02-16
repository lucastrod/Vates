using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VatesPruebaTecnica.Pages
{
    class LoginPage
    {
        private IWebDriver webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        private IWebElement inpUsername => webDriver.FindElement(By.Id("user-name"));

        private IWebElement inpPassword => webDriver.FindElement(By.Id("password"));

        private IWebElement btnLogin => webDriver.FindElement(By.Id("login-button"));


        public void Login(string username, string password)
        {
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com/");

            inpUsername.SendKeys(username);

            inpPassword.SendKeys(password);

            btnLogin.Click();

        }
    }
}
