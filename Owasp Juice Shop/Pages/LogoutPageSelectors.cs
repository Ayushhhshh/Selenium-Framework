using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework; // Ensure you have the NUnit package for testing
using OpenQA.Selenium.Support.UI;
using Candy_Mapper.Setup; // Add this for WebDriverWait


namespace Candy_Mapper.Pages 
{
    public class LogoutPageSelectors : Base
    {
        private new IWebDriver driver;

        public LogoutPageSelectors(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement accountButton => driver.FindElement(By.XPath("//*[@id=\"bs-5\"]"));
        public IWebElement accountButtonOnHomepage => driver.FindElement(By.XPath("//*[@id=\"4\"]"));
        public IWebElement signOutButton => driver.FindElement(By.XPath("(//p[contains(text(),'Sign out')])[1]"));
        public IWebElement signInButton => driver.FindElement(By.XPath("(//a[contains(text(),'Sign In')])[1]"));



    }
}