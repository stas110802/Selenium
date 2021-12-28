using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome.ChromeDriverExtensions;

namespace Selenium
{
    public class SeleniumWebDriver
    {
        public SeleniumWebDriver()
        {
            _driver = new ChromeDriver($"{_location}\\Files\\");
        }
        /// <summary>
        /// Create object with proxy autorization
        /// </summary>
        public SeleniumWebDriver(string host, int port, string login, string password) 
        {
            _driver = new ChromeDriver($"{_location}\\Files\\");
            var options = new ChromeOptions();
            options.AddHttpProxy(host, port, login, password);
        }
        /// <summary>
        /// Create object without proxy autorization
        /// </summary>        
        public SeleniumWebDriver(string host, string port)
        {
            var path = $"{host}:{port}";

            var proxy = new Proxy
            {
                HttpProxy = path,
                SslProxy = path,
                FtpProxy = path,
                Kind = ProxyKind.Manual,
                IsAutoDetect = false
            };

            var options = new ChromeOptions()
            {
                Proxy = proxy
            };
            options.AddArgument("ignore-certificate-errors");

            _driver = new ChromeDriver($"{_location}\\Files\\", options);                 
        }

        private string _location = Environment.CurrentDirectory;
        private IWebDriver _driver;

        public void ClickButton(string url, string xpath = null)
        {
            _driver.Navigate().GoToUrl(url);
            IWebElement query = _driver.FindElement(By.XPath(xpath));
            query.Click();          
            Thread.Sleep(20000);
            _driver.Quit();
        }
    }
}
