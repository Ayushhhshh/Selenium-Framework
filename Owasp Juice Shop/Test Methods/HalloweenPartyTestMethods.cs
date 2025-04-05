using OpenQA.Selenium.Support.UI;
using Candy_Mapper.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Candy_Mapper.Test_Methods
{
    [TestFixture]
    public class HalloweenPartyTestMethods : HalloweenPartyPageSelectors
    {
        public HalloweenPartyTestMethods(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnHalloweenParty()
        {
            Thread.Sleep(1000);
            HalloweenParty.Click();
        }
        public bool VerifyHalloweenPartyPageIsLoaded()
        {
            Thread.Sleep(1000);
            bool result = HostingParty.Displayed;

            return result;
        }
        public void ClickOnHostingParty()
        {
            Thread.Sleep(1000);
            HostingParty.Click();
        }
        public bool VerifyPartyThemePageIsLoaded()
        {
            Thread.Sleep(1000);
            bool result = PartyTheme.Displayed;

            return result;
        }
        public void ClickOnGhostsButton()
        {
            Thread.Sleep(1000);
            Ghosts.Click();
        }
        public bool VerifyEmailInputPageIsLoaded()
        {
            Thread.Sleep(1000);
            bool result = GetNotifiedElement.Displayed;

            return result;
        }
        public void InputEmail(string email)
        {
            Thread.Sleep(1000);
            EmailInput.SendKeys(email);
        }
        public void ClickOnRemindMeButton()
        {
            Thread.Sleep(1000);
            RemindMeButton.Click();
            Thread.Sleep(1000);
        }
    }
}
