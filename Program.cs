using System;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            //var beta = new CryptoCom();
            //beta.Start();

            Linker linker = new Linker();
            linker.PoxyIn();
            linker.IpTest();
           
        }
    }
}
