using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

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

        public static IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }
      
        public static IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
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

        public static string ElementIsVisible(By xpath,string text, int second)
        {
           IWebElement element =  FindElement(xpath);
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
