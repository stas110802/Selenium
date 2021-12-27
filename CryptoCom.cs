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
        public CryptoCom() 
        {
            _driver = new ChromeDriver("C:\\Files\\");
        }
        public CryptoCom(string host, int port, string login, string password)
        {            
            var options = new ChromeOptions();
            options.AddHttpProxy(host, port, login, password);
            _driver = new ChromeDriver("C:\\Files\\", options);                 
        }

        private IWebDriver _driver;

        public void Start()
        {
            _driver.Navigate().GoToUrl(@"https://crypto.com/price/warship-battles");
            IWebElement query = _driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div/div[4]/div[1]/div[3]/div[2]/button[1]"));
            query.Click();          
            //query.SendKeys(Keys.Enter);
            Thread.Sleep(5000);

            _driver.Quit();
        }
    }
}
