using SpecFlowNunitProjectExample.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowNunitProjectExample.Steps.BaseSteps
{
    public class BaseStep
    {
        [Before]
        public void DriverStart()
        {
            Driver.DriverStart();
        }

        [After]
        public void DriverQuit()
        {
            Driver.DriverQuit();
        }

        [StepDefinition(@"Main page open")]
        public void OpenPage()
        {
            Driver.GoToUrl("https://www.sahibinden.com/");
        }
    }
}
