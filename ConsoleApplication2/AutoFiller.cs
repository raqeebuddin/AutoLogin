using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver _driver = new ChromeDriver();

            _driver.Navigate().GoToUrl("https://staging3.mediacentrecore.com/Account/Login?ReturnUrl=%2F");

            IWebElement userName = _driver.FindElement(By.Id("Username"));

            // Enter something to search for
            userName.SendKeys("userOne");

            IWebElement password = _driver.FindElement(By.Id("Password"));

            password.SendKeys("passwordOne");

            
            _driver.Close();




        }
    }
}
