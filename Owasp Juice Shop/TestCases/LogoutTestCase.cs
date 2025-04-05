using Candy_Mapper.Test_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Mapper.TestCases
{
    internal class LogoutTestCase : LogoutTestMethods
    {
        public LogoutTestCase(IWebDriver driver) : base(driver)
        {
        }

        public void Logout()
        {
            ClickOnAccountButton();
            ClickOnSignOutButton();
            ClickOnAccountButtonOnHomePage();
            Assert.IsTrue(VerifyLogoutSuccessfully());
        }
    }
}
