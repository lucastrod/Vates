using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VatesPruebaTecnica.Pages;

namespace VatesPruebaTecnica
{
    class Program
    {
        static IWebDriver LaunchBrowser()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");
            options.AddExcludedArgument("enable-automation");
            var chromeDriverService = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory);
            chromeDriverService.HideCommandPromptWindow = true;

            var driver = new ChromeDriver(chromeDriverService, options);
            return driver;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("User Login");
            var webDriver = LaunchBrowser();
            try
            {
                var start = new LoginPage(webDriver);
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Login...");
                #region Parameters
                var user = "standard_user";
                var pw = "secret_sauce";
                #endregion
                start.Login(user, pw);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while executing automation");
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                webDriver.Quit();
                Console.WriteLine("Login Succesfully");
                Console.ReadKey();
            }
        }
    }
}
