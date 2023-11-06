using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example2
{
    class Navigation
    {
        IWebDriver driver;
        WebDriverWait wait;

        public Navigation(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void Go(string value1)
        {
            driver.Url = value1;

        }
    }
}
