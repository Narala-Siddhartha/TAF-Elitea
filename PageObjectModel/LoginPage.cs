using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class LoginPage
    {
        private By username = By.XPath("//input[@name='user-name']");
        private By password = By.XPath("//input[@name='password']");
        private By loginButton = By.XPath("//input[@name='login-button']");
    public void EnterUsername(IWebDriver driver, string user)
        {
            var element = driver.FindElement(username);
            element.Clear();
            element.SendKeys(user);
        }

        public void EnterPassword(IWebDriver driver, string pass)
        {
            var element = driver.FindElement(password);
            element.Clear();
            element.SendKeys(pass);
        }

        public void ClickLoginButton(IWebDriver driver)
        {
            driver.FindElement(loginButton).Click();
        }
    }
}
public void EnterUsername(IWebDriver driver, string user)
        {
            var element = driver.FindElement(username);
            element.Clear();
            element.SendKeys(user);
        }

        public void EnterPassword(IWebDriver driver, string pass)
        {
            var element = driver.FindElement(password);
            element.Clear();
            element.SendKeys(pass);
        }

        public void ClickLoginButton(IWebDriver driver)
        {
            driver.FindElement(loginButton).Click();
        }
    }
}
