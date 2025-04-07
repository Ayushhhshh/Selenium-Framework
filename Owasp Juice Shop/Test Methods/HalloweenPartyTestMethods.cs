using OpenQA.Selenium.Support.UI;
using Candy_Mapper.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Owasp_Juice_Shop.Reports;

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
            ExtentReporting.LogInfo("Clicked on Halloween Party Button");
        }
        public bool VerifyHalloweenPartyPageIsLoaded()
        {
            Thread.Sleep(1000);
            bool result = HostingParty.Displayed;
            ExtentReporting.LogInfo("Halloween Party Page is Loaded");

            return result;
        }
        public void ClickOnHostingParty()
        {
            Thread.Sleep(1000);
            HostingParty.Click();
            ExtentReporting.LogInfo("Clicked on Hosting party");
        }
        public bool VerifyPartyThemePageIsLoaded()
        {
            Thread.Sleep(1000);
            bool result = PartyTheme.Displayed;
            ExtentReporting.LogInfo("Party Theme page is loaded");

            return result;
        }
        public void ClickOnGhostsButton()
        {
            Thread.Sleep(1000);
            Ghosts.Click();
            ExtentReporting.LogInfo("Selected Ghost option");

        }
        public bool VerifyEmailInputPageIsLoaded()
        {
            Thread.Sleep(1000);
            bool result = GetNotifiedElement.Displayed;
            ExtentReporting.LogInfo("Email input page is loaded");

            return result;
        }
        public void InputEmail(string email)
        {
            Thread.Sleep(1000);
            EmailInput.SendKeys(email);
            ExtentReporting.LogInfo("Input data in Email Input");
        }
        public void ClickOnRemindMeButton()
        {
            Thread.Sleep(1000);
            RemindMeButton.Click();
            ExtentReporting.LogInfo("Clicked on Remind Me Button");
            Thread.Sleep(1000);
        }
    }
}
