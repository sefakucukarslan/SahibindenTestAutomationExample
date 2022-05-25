using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowNunitProjectExample.Models.BaseModels;
using SpecFlowNunitProjectExample.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowNunitProjectExample.Models
{
    public class DetailSearchPageModel : BaseModel
    {
        public void ClickDetailSearchButton()
        {
            Driver.FindElement(By.XPath("//a[contains(text(),'Detaylı Arama')]")).Click();
        }

        public void IsVisibleDetailSearchText(string value)
        {
            Assert.IsNull(Driver.ElementIsVisible(By.XPath("//div[@class='categoryWrapper']/h2"), 5),"Element not found!");
            Assert.IsTrue(Driver.FindElement(By.XPath("//div[@class='categoryWrapper']/h2")).Text.Equals(value), "Text not found!");
        }
    }
}
