using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework; // Ensure you have the NUnit package for testing
using OpenQA.Selenium.Support.UI;
using Candy_Mapper.Setup; // Add this for WebDriverWait


namespace Candy_Mapper.Pages 
{
    public class HalloweenPartyPageSelectors : Base
    {
        private new IWebDriver driver;

        public HalloweenPartyPageSelectors(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement HalloweenParty => driver.FindElement(By.XPath("(//a[contains(text(),'Halloween Party')])[1]"));
        public IWebElement HostingParty => driver.FindElement(By.XPath("//a[contains(text(),'I Am Hosting A Party')]"));
        public IWebElement PartyTheme => driver.FindElement(By.XPath("//h1[@role='heading' and @aria-level='1' and @data-aid='SECTION_TITLE_RENDERED' and text()='Party Theme']"));
        public IWebElement Ghosts => driver.FindElement(By.XPath("//a[contains(text(),'Ghosts')]"));
        public IWebElement GetNotifiedElement => driver.FindElement(By.XPath("//*[@id='f57ec2c1-8945-465c-bb49-d6c99552bd6a']/div/section/div/h2"));

        public IWebElement EmailInput => driver.FindElement(By.XPath("//input[@data-ux='InputFloatLabel']"));

        public IWebElement RemindMeButton => driver.FindElement(By.XPath("//button[contains(text(),'Remind Me')]"));

    }
}