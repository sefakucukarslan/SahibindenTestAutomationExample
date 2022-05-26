using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SpecFlowNunitProjectExample.WebDriver
{
    public static class Driver
    {
        public static IWebDriver driver; 
        private static WebDriverWait wait; 

        public static void DriverStart()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public static void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public static void DriverQuit()
        {
            driver.Quit();
        }

        public static IWebElement FindElementXPath(string xPath)
        {
            return driver.FindElement(By.XPath(xPath));
        }
        
        public static IWebElement FindElementId(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public static void ForceWait(int second)
        {
            Thread.Sleep(second * 1000);
        }
        public static IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }
        
        public static bool IsElementClickable(By xpath,int second)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
            wait.Until(ExpectedConditions.ElementToBeClickable(xpath));
            return true;
        }


        public static string ElementIsVisible(By xpath, int second)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                wait.Until(ExpectedConditions.ElementIsVisible(xpath));
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }        
    }
}
