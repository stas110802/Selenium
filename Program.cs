using System;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var beta = new SeleniumWebDriver();
            beta.ClickButton(@"https://crypto.com/price/icon", "/html/body/div[1]/div[3]/div/div/div[3]/div[1]/div[3]/div[2]/button[1]");
            // test commit
        }
    }
}
