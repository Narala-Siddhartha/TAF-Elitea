using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectModel;
using TechTalk.SpecFlow;
using UtilsLayer;

namespace UserInterfaceTAF.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private WebDriverUtilities webDriverUtilities;

        public LoginStepDefinitions()
        {
            webDriverUtilities = new WebDriverUtilities();
            driver = webDriverUtilities.InitializeDriver();
            loginPage = new LoginPage();
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            webDriverUtilities.GoToUrl(driver, "https://www.saucedemo.com");
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            loginPage.EnterUsername(driver, username);
            loginPage.EnterPassword(driver, password);
        }

        [When("I enter invalid username '(.*)' and password '(.*)'")]
        public void WhenIEnterInvalidUsernameAndPassword(string username, string password)
        {
            loginPage.EnterUsername(driver, username);
            loginPage.EnterPassword(driver, password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLoginButton(driver);
        }

        [Then("I should be redirected to the products page at '(.*)'")]
        public void ThenIShouldBeRedirectedToTheProductsPage(string expectedUrl)
        {
            Assert.AreEqual(expectedUrl, driver.Url);
        }

        [Then("I should see an error message")]
        public void ThenIShouldSeeAnErrorMessage()
        {
            var errorMessage = driver.FindElement(By.CssSelector("h3[data-test='error']")).Text;
            Assert.IsTrue(errorMessage.Contains("Epic sadface"));
        }
    }
}