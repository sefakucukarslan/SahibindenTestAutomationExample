using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowNunitProjectExample.Models.BaseModels;
using SpecFlowNunitProjectExample.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowNunitProjectExample.Models
{
    public class MainPageModel : BaseModel
    {

        public void ShowAllOfThemClick()
        {
            Driver.FindElement(By.XPath("//li[@class='category-3517']//label[@class='open-categories']")).Click(); ;
        }

        public void IsVisibleVehicleCategory(string catName)
        {
            string result = Driver.ElementIsVisible(By.XPath("//a[contains(text(),'"+ catName +"')]"),10);
            Assert.IsNull(result, "Element bulunamadı");
        }

        public void IsVisibleRealEstateCategory(string catName)
        {
            string result = Driver.ElementIsVisible(By.XPath("//a[contains(text(),'" + catName + "')]"), 10);
            Assert.IsNull(result, "Element bulunamadı");
        }

        public void IsVisibleLogo()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[@class='logo']")).Displayed, "Logo not found!");
        }

        public void IsVisibleDetailSearch()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[contains(text(),'Detaylı Arama')]")).Displayed, "Detail Search not found!");
        }

        public void IsVisibleSignIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[@id='secure-login']")).Displayed, "Sign In not found!");
        }

        public void IsVisibleSignOut()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//li[@class='register-text']/a")).Displayed, "Sign Out not found!");
        }

        public void IsVisibleFreeAdv()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[@id='post-new-classified']")).Displayed, "Free Advertise not found!");
        }

        public void IsVisibleSearchBar()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//input[@id='searchText']")).Displayed, "Search Bar not found!");
        }

        public void SearchBarClick()
        {
            Driver.FindElement(By.XPath("//input[@id='searchText']")).Click();
        }

        public void IsVisibleSearchBarButton()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//input[@id='searchText']")).Displayed, "Search Bar Button not found!");
        }

        public void IsVisibleSearchBarCloseButton()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//span[@id='clearSearchPhrase']")).Displayed, "Search Bar Close Button not found!");
        }

        public void IsVisibleAds()
        {
           Assert.IsTrue(Driver.FindElements(By.XPath("//ul[@class='vitrin-list clearfix']/li")).Count()>0, "Ads not found!");
        }
    }
}
