using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework; // Ensure you have the NUnit package for testing
using OpenQA.Selenium.Support.UI;
using Candy_Mapper.Setup; // Add this for WebDriverWait


namespace Candy_Mapper.Pages 
{
    public class LoginPageSelectors : Base
    {
        private new IWebDriver driver;

        public LoginPageSelectors(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement crossButton => driver.FindElement(By.Id("popup-widget25042-close-icon"));
        public IWebElement accountButton => driver.FindElement(By.XPath("(//a[@data-aid='MEMBERSHIP_ICON_DESKTOP_RENDERED'])[1]"));
        public IWebElement signInButton => driver.FindElement(By.XPath("(//a[contains(text(),'Sign In')])[1]"));
        public IWebElement emailInput => driver.FindElement(By.XPath("//input[@name='email']"));
        public IWebElement passwordInput => driver.FindElement(By.XPath("//input[@name='password']"));
        public IWebElement signInSubmitButton => driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement HelloCandy => driver.FindElement(By.XPath("//span[contains(text(),'lebone8476@bmixrcom')]"));
    }
}