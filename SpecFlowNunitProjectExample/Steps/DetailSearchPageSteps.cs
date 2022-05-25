using SpecFlowNunitProjectExample.Models;
using SpecFlowNunitProjectExample.Steps.BaseSteps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
