using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SpecFlowNunitProjectExample.Models.BaseModels;
using SpecFlowNunitProjectExample.WebDriver;
using System;
using System.Collections.Generic;

namespace SpecFlowNunitProjectExample.Models
{
    public class DetailSearchPageModel : BaseModel
    {
        public void ClickDetailSearchButton()
        {
            Driver.FindElementXPath("//a[contains(text(),'Detaylı Arama')]").Click();
        }

        public void IsVisibleDetailSearchText(string value)
        {
            Assert.IsNull(Driver.ElementIsVisible(By.XPath("//div[@class='categoryWrapper']/h2"), 5),"Element not found!");
            Assert.IsTrue(Driver.FindElementXPath("//div[@class='categoryWrapper']/h2").Text.Equals(value), "Text not found!");
        }

        public void IsCategorySelectedAll()
        {
            Assert.IsTrue(Driver.FindElementXPath("//li/span[text()='Tümü']").Selected, "Tümü not selected!");
        }

        public void IsVisibleAllCategoryElements()
        {
            Assert.IsTrue(Driver.FindElements(By.XPath("//div[@class='category-list']//li")).Count == 10, "They are not equal!");
        }

        public void IsCityDropdownEnable()
        {
            Assert.IsTrue(Driver.FindElementXPath("//a[@class='faceted-select']").Enabled, "City is not enable");
        }

        public void IsDistrictDropdownDisable()
        {
            //Assert.IsFalse(Driver.FindElementXPath("//a[@class='faceted-select passive']").Enabled, "District is enable");

           Assert.IsTrue(Driver.IsElementClickable(By.XPath("//a[@class='faceted-select passive']"), 5), "District is not clickable!");
        }

        public void IsVisibleAdvertDateAll()
        {
            Assert.IsTrue(Driver.FindElementXPath("//div/span[contains(text(),'Tümü')]").Displayed, "Advert date is not visible");
        }

        public void IsVisibleSearchWord()
        {
            Assert.IsTrue(Driver.FindElementXPath("//input[@class='inputDefault wordInput']").Displayed, "Search Bar not found!");
        }

        public void IsSortbyDropdownEnable()
        {
            Assert.IsTrue(Driver.FindElementXPath("//div/span[contains(text(),'Fiyata göre (Önce en yüksek)')]").Enabled, "Sort by is not enable");
        }
        public void IsVisibleSearchButton(string value)
        {
            Assert.IsTrue(Driver.FindElementXPath("//button[contains(text(),'" + value + "')]").Displayed, "Search button not found");
        }
        public void FirstSectionOfCategory(string value)
        {
            Driver.FindElementXPath("//span[contains(text(),'" + value + "')]").Click();
            Driver.ForceWait(2);
        }
        public void SecondSectionOfCategory(string value)
        {
            Driver.FindElementXPath("//span[contains(text(),'" + value + "')]").Click();
            Driver.ForceWait(2);
        }

        public void ThirdSectionOfCategory(string value)
        {
            Driver.FindElementXPath("//span[contains(text(),'" + value + "')]").Click();
            Driver.ForceWait(2);
        }
        public void FourthSectionOfCategory(string value)
        {
            Assert.IsTrue(Driver.FindElementXPath("//span[contains(text(),'" + value + "')]").Displayed,"Not found!");
            Driver.ForceWait(2);
        }
        public void ClickToCity()
        {
            Driver.FindElementXPath("//li[@data-address='city']/a").Click();
            Driver.ForceWait(2);
        }
        public void SetSearchCity(string value)
        {
            Driver.FindElementXPath("//div[@class='address-filter']/input[@placeholder='İl']").SendKeys(value);
            Driver.ForceWait(2);
        }
        public void ChooseCity(string value)
        {
            Driver.FindElementXPath("//a[contains(text(),'"+ value +"')]").Click();
            Driver.ForceWait(2);
        }
        public void CloseSearchCity()
        {
            Driver.FindElementXPath("//li[@data-address='city']//a[@class='collapse-pane']").Click();
        }
        public void IsTrueSearchCity(string value)
        {
            Assert.IsTrue(Driver.FindElementXPath("//li/a[@title='"+ value +"']").Displayed);
        }
        public void ClickDistrict()
        {
            Driver.FindElementXPath("//li[@data-address='town']/a").Click();
        }
        public void SetSearchDistrict(string value)
        {
            Driver.ForceWait(1);
            Driver.FindElementXPath("//div[@class='address-filter']/input[@placeholder='İlçe']").SendKeys(value);
        }
        public void CloseSearchDistrict()
        {
            Driver.FindElementXPath("//li[@data-address='town']//a[@class='collapse-pane']").Click();
        }
        public void ClickSearchButton()
        {
            Driver.ForceWait(3);
            Driver.FindElementXPath("//form[@id='detailedSearchForm']//button").SendKeys(Keys.Enter);
        }

    }
}
