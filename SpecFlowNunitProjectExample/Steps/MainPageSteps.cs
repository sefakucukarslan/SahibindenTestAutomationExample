using SpecFlowNunitProjectExample.Models;
using SpecFlowNunitProjectExample.Steps.BaseSteps;
using TechTalk.SpecFlow;

namespace SpecFlowNunitProjectExample.Steps
{
    [Binding,Scope(Feature ="MainPage")]
    public class MainPageSteps : BaseStep
    {
        MainPageModel model;

        public MainPageSteps()
        {
            model = new MainPageModel();
        }

        [StepDefinition(@"Show all of them click")]
        public void ShowAllOfThemClick()
        {
            model.ShowAllOfThemClick();
        }

        [StepDefinition(@"Is visible '(.*)' vehicles category")]
        public void IsVisibleVehicleCategory(string catName)
        {
            model.IsVisibleVehicleCategory(catName);
        }
        
        [StepDefinition(@"Is visible '(.*)' real estate category")]
        public void IsVisibleRealEstateCategory(string catName)
        {
            model.IsVisibleRealEstateCategory(catName);
        }
        
        [StepDefinition(@"Is visible logo")]
        public void IsVisibleLogo()
        {
            model.IsVisibleLogo();
        }
        
        [StepDefinition(@"Is visible Detail Search")]
        public void IsVisibleDetailSearch()
        {
            model.IsVisibleDetailSearch();
        }
        
        [StepDefinition(@"Is visible Sign In")]
        public void IsVisibleSignIn()
        {
            model.IsVisibleSignIn();
        }
        
        [StepDefinition(@"Is visible Sign Out")]
        public void IsVisibleSignOut()
        {
            model.IsVisibleSignOut();
        }
        
        [StepDefinition(@"Is visible Free Advertise")]
        public void IsVisibleFreeAdv()
        {
            model.IsVisibleFreeAdv();
        }
        
        [StepDefinition(@"Is visible Search Bar")]
        public void IsVisibleSearchBar()
        {
            model.IsVisibleSearchBar();
        }
        
        [StepDefinition(@"Search Bar click")]
        public void SearchBarClick()
        {
            model.SearchBarClick();
        }
        
        [StepDefinition(@"Is visible Search Bar search button")]
        public void IsVisibleSearchBarButton()
        {
            model.IsVisibleSearchBarButton();
        }
        
        [StepDefinition(@"Is visible Search Bar close button")]
        public void IsVisibleSearchBarCloseButton()
        {
            model.IsVisibleSearchBarCloseButton();
        }
        
        [StepDefinition(@"Is visible Ads")]
        public void IsVisibleAds()
        {
            model.IsVisibleAds();
        }

        
    }
}
