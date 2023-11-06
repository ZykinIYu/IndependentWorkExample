using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example2
{
    class HomeGoogle
    {
        IWebDriver driver;
        WebDriverWait wait;
        By searchWindowLocator;
        By buttonSearchLocator;
        By seleniumClickLocator;
        public HomeGoogle(IWebDriver driver, WebDriverWait wait) {
            this.driver = driver;
            this.wait = wait;
            searchWindowLocator = By.CssSelector("[name = 'q']");
            buttonSearchLocator = By.XPath("//div[5]/center/input[1]");
        }

        public void GoogleSearch(string value2)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(searchWindowLocator));
            driver.FindElement(searchWindowLocator).SendKeys(value2);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(buttonSearchLocator));
            driver.FindElement(buttonSearchLocator).Click();
            Thread.Sleep(3000);
        }
    }
}
