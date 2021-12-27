using System;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            var beta = new SeleniumWebDriver("217.77.225.170", "8080");
            beta.ClickButton(@"https://socproxy.ru/ip");

            //Linker linker = new Linker();
            //linker.PoxyIn();
            //linker.IpTest();          
        }
    }
}
