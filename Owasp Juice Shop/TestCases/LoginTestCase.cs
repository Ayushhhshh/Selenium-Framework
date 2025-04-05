using Candy_Mapper.Test_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candy_Mapper.Setup;
using Owasp_Juice_Shop.Reports;

namespace Candy_Mapper.TestCases
{
    internal class LoginTestCase : LoginTestMethods
    {
        public LoginTestCase(IWebDriver driver) : base(driver)
        {
        }

        public void Login(string email, string password)
        {
            try
            {
                ExtentReporting.LogInfo("Starting Test");
                ClickOnCrossButton();
                ClickOnAccountButton();
                ClickOnSignInButton();
                InputData(email, password);
                ClickOnSignInSubmitButton();
                Assert.IsTrue(VerifyLoginSuccessfully());
                ExtentReporting.LogPass("Logged In Successfully");
            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail("Testcase failed");
                throw;
            }
        }
    }
}
