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

            var proxy = new Proxy();
            proxy.HttpProxy = path;
            proxy.SslProxy = path;
            proxy.FtpProxy = path;
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;

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
            //IWebElement query = _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[4]/div[1]/div[3]/div[2]/button[1]"));
            //query.Click();          
            //query.SendKeys(Keys.Enter);
            Thread.Sleep(50000);

            _driver.Quit();
        }
    }
}
