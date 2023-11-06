using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class SwagLabsHome
    {
        IWebDriver driver;
        WebDriverWait wait;
        By userNameXPath;
        By passwordXPath;
        By loginButtonXPath;
        By errorAuthorizationXPath;

        public SwagLabsHome(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
            userNameXPath = By.XPath("//*[@id='user-name']");
            passwordXPath = By.XPath("//*[@id='password']");
            loginButtonXPath = By.XPath("//*[@id='login-button']");
            errorAuthorizationXPath = By.XPath("//*[@data-test='error']");
        }

        public void UserNameSet(string value1)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(userNameXPath));
            driver.FindElement(userNameXPath).SendKeys(value1);
        }

        public void PasswordSet(string value1)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(passwordXPath));
            driver.FindElement(passwordXPath).SendKeys(value1);
        }

        public void LoginClick()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(loginButtonXPath));
            driver.FindElement(loginButtonXPath).Click();
        }

        public void CheckError(string value1)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(errorAuthorizationXPath));
            NUnit.Framework.Assert.AreEqual(driver.FindElement(errorAuthorizationXPath).Text, value1);
        }
    }
}
