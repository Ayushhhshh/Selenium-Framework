﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owasp_Juice_Shop.Setup
{
    public class Browser
    {
        private IWebDriver driver;

        public Browser(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetScreenshot()
        {
            var file = ((ITakesScreenshot)driver).GetScreenshot();
            var img = file.AsBase64EncodedString;

            return img;
        }
    }
}
