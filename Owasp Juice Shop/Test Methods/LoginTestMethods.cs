using OpenQA.Selenium.Support.UI;
using Candy_Mapper.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;
using Owasp_Juice_Shop.Reports;

namespace Candy_Mapper.Test_Methods
{
    [TestFixture]
    public class LoginTestMethods : LoginPageSelectors
    {
        public LoginTestMethods(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnCrossButton()
        {
            ExtentReporting.LogInfo("Click on Cross Button");
            Thread.Sleep(1000);
            crossButton.Click();
        }
        public void ClickOnAccountButton()
        {
            ExtentReporting.LogInfo("Click on Account Button");
            Thread.Sleep(1000);
            accountButton.Click();
        }
        public void ClickOnSignInButton()
        {
            ExtentReporting.LogInfo("Click on Sign In Button");

            Thread.Sleep(1000);
            signInButton.Click();
        }
        public void InputData(string email, string password)
        {
            ExtentReporting.LogInfo("Input Email and password");

            Thread.Sleep(1000);
            emailInput.SendKeys(email);
            Thread.Sleep(1000);
            passwordInput.SendKeys(password);
        }
        public void ClickOnSignInSubmitButton()
        {
            ExtentReporting.LogInfo("Click on Submit Button");

            Thread.Sleep(1000);
            signInSubmitButton.Click();
            Thread.Sleep(1000);
        }
        public bool VerifyLoginSuccessfully()
        {

            Thread.Sleep(3000);
            bool result = HelloCandy.Displayed;
            return result;
        }

    }
}
