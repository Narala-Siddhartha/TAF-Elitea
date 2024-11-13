using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UtilsLayer;

namespace UserInterfaceTAF.Hooks
{
    [Binding]
    public class SpecFlowHooks
    {
        private IWebDriver driver;
        private WebDriverUtilities webDriverUtilities;

        [BeforeScenario]
        public void BeforeScenario()
        {
            webDriverUtilities = new WebDriverUtilities();
            driver = webDriverUtilities.InitializeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}