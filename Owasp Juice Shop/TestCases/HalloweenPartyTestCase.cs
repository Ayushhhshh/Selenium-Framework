using Candy_Mapper.Test_Methods;
using OpenQA.Selenium;
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
            ClickOnHalloweenParty();
            Assert.IsTrue(VerifyHalloweenPartyPageIsLoaded());
            ClickOnHostingParty();
            Assert.IsTrue(VerifyPartyThemePageIsLoaded());
            ClickOnGhostsButton();
            Assert.IsTrue(VerifyEmailInputPageIsLoaded());
            InputEmail(email);
            ClickOnRemindMeButton();
        }
    }
}
