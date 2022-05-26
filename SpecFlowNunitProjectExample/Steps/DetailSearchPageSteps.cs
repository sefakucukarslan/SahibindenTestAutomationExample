using SpecFlowNunitProjectExample.Models;
using SpecFlowNunitProjectExample.Steps.BaseSteps;
using TechTalk.SpecFlow;

namespace SpecFlowNunitProjectExample.Steps
{
    [Binding,Scope(Feature ="DetailSearchPage")]
    public class DetailSearchPageSteps : BaseStep
    {

        DetailSearchPageModel model;
        public DetailSearchPageSteps()
        {
            model = new DetailSearchPageModel();
        }

        [StepDefinition(@"Click detail search button")]
        public void ClickDetailSearchButton()
        {
            model.ClickDetailSearchButton();
        }
        
        [StepDefinition(@"Is visible '(.*)' text")]
        public void IsVisibleDetailSearchText(string value)
        {
            model.IsVisibleDetailSearchText(value);
        }

        [StepDefinition(@"Is category selected all")]
        public void IsCategorySelectedAll()
        {
            model.IsCategorySelectedAll();
        }

        [StepDefinition(@"Is visible all category elements")]
        public void IsVisibleAllCategoryElements()
        {
            model.IsVisibleAllCategoryElements();
        }
        
        [StepDefinition(@"Is city dropdown enable")]
        public void IsCityDropdownEnable()
        {
            model.IsCityDropdownEnable();
        }
        
        [StepDefinition(@"Is district dropdown disable")]
        public void IsDistrictDropdownDisable()
        {
            model.IsDistrictDropdownDisable();
        }
        
        [StepDefinition(@"Is visible Advert date All")]
        public void IsVisibleAdvertDateAll()
        {
            model.IsVisibleAdvertDateAll();
        }
        
        [StepDefinition(@"Is visible Search word")]
        public void IsVisibleSearchWord()
        {
            model.IsVisibleSearchWord();
        }
        
        [StepDefinition(@"Is Sort by dropdown enable")]
        public void IsSortbyDropdownEnable()
        {
            model.IsSortbyDropdownEnable();
        }
        
        [StepDefinition(@"Is visible '(.*)' button")]
        public void IsVisibleSearchButton(string value)
        {
            model.IsVisibleSearchButton(value);
        }
        
        [StepDefinition(@"The first section of the category is '(.*)'")]
        public void FirstSectionOfCategory(string value)
        {
            model.FirstSectionOfCategory(value);
        }
        
        [StepDefinition(@"The second section of the category is '(.*)'")]
        public void SecondSectionOfCategory(string value)
        {
            model.SecondSectionOfCategory(value);
        }
        
        [StepDefinition(@"The third section of the category is '(.*)'")]
        public void ThirdSectionOfCategory(string value)
        {
            model.ThirdSectionOfCategory(value);
        }
        
        [StepDefinition(@"Fourth part of the category is '(.*)' selected")]
        public void FourthSectionOfCategory(string value)
        {
            model.FourthSectionOfCategory(value);
        }
        
        [StepDefinition(@"Click to city")]
        public void ClickToCity()
        {
            model.ClickToCity();
        }
        
        [StepDefinition(@"City search bar write '(.*)'")]
        public void SetSearchCity(string value)
        {
            model.SetSearchCity(value);
        }
        
        [StepDefinition(@"Choose '(.*)' section")]
        public void ChooseCity(string value)
        {
            model.ChooseCity(value);
        }
        
        [StepDefinition(@"Close city search bar")]
        public void CloseSearchCity()
        {
            model.CloseSearchCity();
        }

        [StepDefinition(@"Is true search city '(.*)'")]
        public void IsTrueSearchCity(string value)
        {
            model.IsTrueSearchCity(value);
        }
        
        [StepDefinition(@"Click to District")]
        public void ClickDistrict()
        {
            model.ClickDistrict();
        }
        
        [StepDefinition(@"District search bar write '(.*)'")]
        public void SetSearchDistrict(string value)
        {
            model.SetSearchDistrict(value);
        }
        
        [StepDefinition(@"Close district search bar")]
        public void CloseSearchDistrict()
        {
            model.CloseSearchDistrict();
        }
        
        [StepDefinition(@"Click Search Button")]
        public void ClickSearchButton()
        {
            model.ClickSearchButton();
        }

    }
}
