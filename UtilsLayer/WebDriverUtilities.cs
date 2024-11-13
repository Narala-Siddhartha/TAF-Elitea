using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UtilsLayer
{
    public class WebDriverUtilities
    {
        public IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        public void GoToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(IWebDriver driver, By by)
        {
            return driver.FindElement(by);
        }

        public void Clear(IWebElement element)
        {
            element.Clear();
        }

        public void SendKeys(IWebElement element, string keys)
        {
            element.SendKeys(keys);
        }
    }
}