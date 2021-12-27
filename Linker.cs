using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace Selenium
{
    class Linker
    {
        private IWebDriver web = new ChromeDriver(@"C:\chromedriver_win32\");
        private IWebElement webElement;
        public bool GoogleSuces()
        {
            web.Navigate().GoToUrl("https://coinmarketcap.com/currencies/usd-coin/");
            Thread.Sleep(30000);
            webElement = web.FindElement(By.XPath("//button[contains(text(),'Good')]"));
            webElement.Click();

            return false;
        }
    }
}