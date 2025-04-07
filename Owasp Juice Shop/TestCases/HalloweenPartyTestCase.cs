using Candy_Mapper.Test_Methods;
using OpenQA.Selenium;
using Owasp_Juice_Shop.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Mapper.TestCases
{
    internal class HalloweenPartyTestCase : HalloweenPartyTestMethods
    {
        public HalloweenPartyTestCase(IWebDriver driver) : base(driver)
        {
        }

        public void HostAHalloweenParty(string email)
        {
            try
            {
            ExtentReporting.LogInfo("Starting Test");
            ClickOnHalloweenParty();
            Assert.IsTrue(VerifyHalloweenPartyPageIsLoaded());
            ClickOnHostingParty();
            Assert.IsTrue(VerifyPartyThemePageIsLoaded());
            ClickOnGhostsButton();
            Assert.IsTrue(VerifyEmailInputPageIsLoaded());
            InputEmail(email);
            ClickOnRemindMeButton();
            ExtentReporting.LogPass("Hosted a prty successfully");
            }
            catch (Exception ex)
            {
                ExtentReporting.LogFail("Testcase failed");
                throw;
            }
        }
    }
}
