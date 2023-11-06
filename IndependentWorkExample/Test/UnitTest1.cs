using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using NUnit.Framework;
using NSelene;
using static NSelene.Selene;
using System.Diagnostics;

namespace Example2
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        WebDriverWait wait;
        HomeGoogle hg;
        Navigation n;
        SwagLabsHome slh;
        ValuesToEnter vte;


        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--lang=ru-ru");
            driver = new ChromeDriver(options);
            wait = new WebDriverWait(driver, new TimeSpan(0, 4, 0));
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Manage().Window.Maximize();

            hg = new HomeGoogle(driver, wait);
            n = new Navigation(driver, wait);
            slh = new SwagLabsHome(driver, wait);
            vte = new ValuesToEnter();
        }

        [Test]
        public void Search()
        {
            n.Go("https://www.google.ru/");
            hg.GoogleSearch(vte.Selenium); 
        }

        [Test]
        public void Authorization()
        {
            n.Go("https://www.saucedemo.com/");
            slh.UserNameSet(vte.Name);
            slh.PasswordSet(vte.Password);
            slh.LoginClick();
            slh.CheckError(vte.Error1);
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
            driver = null;
        }
    }
}
