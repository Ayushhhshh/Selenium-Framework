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
            Thread.Sleep(1000);
            crossButton.Click();
            ExtentReporting.LogInfo("Clicked on Cross Button");
        }
        public void ClickOnAccountButton()
        {
            Thread.Sleep(1000);
            accountButton.Click();
            ExtentReporting.LogInfo("Clicked on Account Button");
        }
        public void ClickOnSignInButton()
        {

            Thread.Sleep(1000);
            signInButton.Click();
            ExtentReporting.LogInfo("Clicked on Sign In Button");
        }
        public void InputData(string email, string password)
        {

            Thread.Sleep(1000);
            emailInput.SendKeys(email);
            Thread.Sleep(1000);
            passwordInput.SendKeys(password);
            ExtentReporting.LogInfo("Input Email and password");
        }
        public void ClickOnSignInSubmitButton()
        {

            Thread.Sleep(1000);
            signInSubmitButton.Click();
            ExtentReporting.LogInfo("Clicked on Submit Button");
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
