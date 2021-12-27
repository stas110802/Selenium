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
    public class CryptoCom
    {
        /// <summary>
        /// Create object without proxy
        /// </summary>
        public CryptoCom(string host, int port, string login, string password) 
        {
            _driver = new ChromeDriver("C:\\Files\\");
            var options = new ChromeOptions();
            options.AddHttpProxy(host, port, login, password);
        }
        public CryptoCom(string host, string port)
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
            
            _driver = new ChromeDriver("C:\\Files\\", options);                 
        }

        private IWebDriver _driver;

        public void Start()
        {
            _driver.Navigate().GoToUrl(@"https://socproxy.ru/ip");
            //IWebElement query = _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[4]/div[1]/div[3]/div[2]/button[1]"));
            //query.Click();          
            //query.SendKeys(Keys.Enter);
            Thread.Sleep(50000);

            _driver.Quit();
        }
    }
}
