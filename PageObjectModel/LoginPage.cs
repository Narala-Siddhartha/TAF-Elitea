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
    }
}
