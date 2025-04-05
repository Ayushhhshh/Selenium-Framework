using OpenQA.Selenium.Support.UI;
using Candy_Mapper.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;

namespace Candy_Mapper.Test_Methods
{
    [TestFixture]
    public class LogoutTestMethods : LogoutPageSelectors
    {
        public LogoutTestMethods(IWebDriver driver) : base(driver)
        {
        }
        
        public void ClickOnAccountButton()
        {
            Thread.Sleep(1000);
            accountButton.Click();
        }
        public void ClickOnAccountButtonOnHomePage()
        {
            Thread.Sleep(1000);
            accountButtonOnHomepage.Click();
        }
        public void ClickOnSignOutButton()
        {
            Thread.Sleep(1000);
            signOutButton.Click();
        }

        public bool VerifyLogoutSuccessfully()
        {
            Thread.Sleep(1000);
            bool result = signInButton.Displayed;

            return result;
        }

    }
}
