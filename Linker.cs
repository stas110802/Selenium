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
        private IWebDriver web;// = new ChromeDriver(@"C:\chromedriver_win32\");
        private IWebElement webElement;
        private ChromeOptions chromeOptions = new ChromeOptions();
        public bool GoogleSuxcess()
        {
            
            web = new ChromeDriver(@"C:\chromedriver_win32\", chromeOptions);
            web.Navigate().GoToUrl("https://coinmarketcap.com/currencies/usd-coin/");
            Thread.Sleep(30000);
            webElement = web.FindElement(By.XPath("//button[contains(text(),'Good')]"));
            webElement.Click();

            return false;
        }
        public void IpTest()
        {
            web = new ChromeDriver(@"C:\chromedriver_win32\", chromeOptions);
            web.Navigate().GoToUrl("https://2ip.ru");
        }
        public void PoxyIn()
        {
            Proxy proxy = new Proxy();

            proxy.HttpProxy = "217.77.225.170:8080";
            proxy.SslProxy = "217.77.225.170:8080";
            proxy.FtpProxy = "217.77.225.170:8080";
            chromeOptions.Proxy = proxy;

            
        }
    }
}