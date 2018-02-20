using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
namespace ConsoleApplication2
{
    class ProgramOne
    {
        public void test()
        {
            IWebDriver Driver;
            // Open a frefox browser
            string driverPath = "C:\\Users\\raqeeb.uddin\\Desktop\\New folder\\packages\\Selenium.Firefox.WebDriver.0.19.1\\driver\\";


            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(driverPath);
            service.FirefoxBinaryPath = (@"C:\Program Files\Mozilla Firefox\firefox.exe");
            Driver = new FirefoxDriver(service);


            //Maximise the Browser
            Driver.Manage().Window.Maximize();

            //Navigate to the url
            Driver.Navigate().GoToUrl("https://staging3.mediacentrecore.com");

            //Driver.Navigate().GoToUrl("https://staging3.mediacentrecore.com/Account/Login?ReturnUrl=%2F");

            //type in the username 
            Driver.FindElement(By.XPath(".//*input[@id='username']")).SendKeys("admina");

            //Enter the password
            Driver.FindElement(By.XPath(".//*input[@='password']")).SendKeys("password");

            //Press Login
            Driver.FindElement(By.XPath(".//*type[@='submit']")).Click();

            //As an OT Location User
            Driver.FindElement(By.XPath(".//*input[@id='username']")).SendKeys("Noopur_OTuser");

            //Enter Noopur_OTUser password
            Driver.FindElement(By.XPath(".//*input[@='password']")).SendKeys("UniquePass45$$");

            //Select the basket


        }
    }
}
