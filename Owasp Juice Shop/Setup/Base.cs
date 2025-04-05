using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using Candy_Mapper;
using Candy_Mapper.TestData;
using Candy_Mapper.Pages;
using Owasp_Juice_Shop.Reports;
using System.Drawing.Text;
using NUnit.Framework.Interfaces;
using Owasp_Juice_Shop.Setup;

namespace Candy_Mapper.Setup
{
    public class Base
    {
        public IWebDriver driver;
        protected Browser Browser {  get; private set; }

        [SetUp]
        public void Setup()
        {
            ExtentReporting.InitializeReport();
            ExtentReporting.CreateTest(TestContext.CurrentContext.Test.Name);
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://candymapper.com/");
            LoginPageSelectors pageSelectors = new LoginPageSelectors(driver);

            Browser = new Browser(driver);
        }

        [TearDown] 
        public void TearDown()
        {
            EndTest();
            ExtentReporting.EndReporting();
            driver.Dispose();  
            
        }
        //[OneTimeTearDown]
        //public void EndReport()
        //{
        //}
        private void EndTest()
        {
            var teststatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message  = TestContext.CurrentContext.Result.Message; 

            switch(teststatus)
            {
                case TestStatus.Failed:
                    ExtentReporting.LogFail($"Test has failed {message}");
                    break;

                case TestStatus.Skipped:
                    ExtentReporting.LogInfo($"Test skipped{message}");
                    break;
                default:
                    break;
            }

            ExtentReporting.LogScreenshot("Ending test", Browser.GetScreenshot());
        }
    }
}
